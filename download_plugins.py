import codecs
import json
import os
import shutil
import zipfile

import requests


class Plugin:
    def __init__(self, json_dict):
        base_url_for_file = "https://api.getwox.com/media/"
        self.name = json_dict['name']
        self.username = json_dict['created_by']['username']
        self.language = json_dict['language'].lower()
        self.github = json_dict['github']
        self.modified_date = json_dict['modified_date']
        # e.g. plugin/D2D2C23B084D411DB66FE0C79D6C2A6D/Wox.Plugin.DoubanMovie-c0318e2c-0c2a-4c8c-a017-9d291b847d1d.wox
        self.file_name = json_dict['plugin_file'].split('/')[2]
        self.file_url = "{}{}".format(base_url_for_file, json_dict['plugin_file'])
        self.file_path = os.path.join(self.language, self.file_name)

    def __repr__(self):
        properties = ('{0} = {1}'.format(k, v) for k, v in self.__dict__.items())
        return '\n'.join(properties)


def download():
    url = "https://api.getwox.com/plugin/?page_size=100"
    r = requests.get(url, verify=False)
    data = r.json()
    plugins = [Plugin(p) for p in data['results']]

    for plugin in plugins:
        print(plugin)

        if not os.path.exists(plugin.language):
            os.makedirs(plugin.language)
        plugin_downloaded = requests.get(plugin.file_url, verify=False, stream=True)

        if os.path.exists(plugin.file_path):
            os.remove(plugin.file_path)
        with open(plugin.file_path, 'wb') as f:
            shutil.copyfileobj(plugin_downloaded.raw, f)


def extract_dll():
    dir_path = "csharp"
    dll_path = 'DLLs'
    if not os.path.exists(dll_path):
        os.makedirs(dll_path)

    for file_name in os.listdir(dir_path):
        file_path = os.path.join(dir_path, file_name)
        with zipfile.ZipFile(file_path, "r") as z:
            with z.open('plugin.json', 'rU') as j:
                reader = codecs.getreader("utf-8-sig")
                config = json.load(reader(j))
                execute_file_name = config['ExecuteFileName']

                for name in z.namelist():
                    if name.lower() == execute_file_name.lower():
                        z.extract(name, dll_path)


if __name__ == "__main__":
    download()
    extract_dll()
