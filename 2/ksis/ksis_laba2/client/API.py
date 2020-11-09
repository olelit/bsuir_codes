import requests
from django.views.decorators.csrf import csrf_exempt


class Api:

    def __init__(self, address, login, password):
        self.address = address

    def get_item_path(self, path, item, op):
        return requests.get(self.join_address_and_operation(op), params={
            'path': "/".join(path),
            'name': item
        })

    def copy(self, path, item):
        return self.get_item_path(path, item, 'copy')

    def paste(self, path, item, old_path, old_name, to_delete):
        return requests.get(self.join_address_and_operation('paste'), params={
            'path': "/".join(path),
            'name': item,
            'old_path': old_path,
            'old_name': old_name,
            'to_delete': to_delete
        })

    def upload(self, path, file=None):
        return requests.post(self.join_address_and_operation('upload'), data={
            'path': "/".join(path)
        }, files=file)

    def save(self, text, path, item):
        return requests.post(self.join_address_and_operation('save'), data={
            'path': "/".join(path),
            'text': text,
            'name': item,
        })

    def create_folder(self, name, path):
        return self.get_item_path(path, name, 'create_folder')

    def file_list(self, path):
        return requests.get(self.join_address_and_operation('file_list'), params={'path': path})

    def join_address_and_operation(self, operation):
        return "{0}/{1}/".format(self.address, operation)

    def file_get_content(self, path, file_name):
        return self.get_item_path(path, file_name, 'get_file')

    def delete(self, name, path):
        return requests.get(self.join_address_and_operation('delete'), params={
            'path': "/".join(path),
            'name': name,
        })
