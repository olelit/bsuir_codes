import datetime
import os

from django.conf import settings
from django.core.files.base import ContentFile
from django.core.files.storage import FileSystemStorage
from django.http import HttpResponse
from django.middleware.csrf import get_token
from django.views.decorators.csrf import ensure_csrf_cookie, csrf_exempt
import os
import shutil
import json
from django.core import serializers
from django.http import JsonResponse
from django.contrib.auth import authenticate


# Create your views here.
@csrf_exempt
def upload(request):
    file = request.FILES['file']
    path = join_path(request.POST['path'], file.name)
    fs = FileSystemStorage(location=join_path(request.POST['path']))  # defaults to   MEDIA_ROOT
    filename = fs.save(file.name, file)
    file_not_exists(path)
    return HttpResponse(filename)


def get_file(request):
    full_path = join_path(request.GET['path'], request.GET['name'])
    output = ''
    with open(full_path, 'r') as file:
        output = file.readlines()

    return HttpResponse(output)


def write_file(path, text):
    with open(path, 'w+') as file:
        output = file.write(text)
    file_not_exists(path)


def file_not_exists(path):
    while not os.path.exists(path):
        wait = 1


def file_exists(path):
    while os.path.exists(path):
        wait = 1


@csrf_exempt
def save(request):
    full_path = join_path(request.POST['path'], request.POST['name'])
    text = request.POST['text']
    write_file(full_path, text)

    return HttpResponse(200)


def file_list(request):
    path = request.GET['path']
    files = []
    directories = []
    path = join_path(path)
    for (dirpath, dirnames, filenames) in os.walk(path):
        if dirnames != []:
            directories.append(dirnames)
        files.append(filenames)

    output = str(",".join(files[0])) + "$"
    if len(directories) > 0 and directories[0] != []:
        output += str(",".join(directories[0]))

    return HttpResponse(output)


def join_path(path, filename=''):
    filename = filename.replace('/', '')
    return settings.BASE_DIR + settings.MEDIA_ROOT + path + "/" + filename


def delete(request, path=""):
    if path == "":
        path = join_path(request.GET['path'], request.GET['name'])

    if os.path.isfile(path):
        os.remove(path)
    else:
        shutil.rmtree(path)

    file_exists(path)

    return HttpResponse(200)


def create_folder(request):
    path = join_path(request.GET['path'], request.GET['name'])
    os.mkdir(path)
    file_not_exists(path)
    return HttpResponse(200)


def paste(request):
    old_path = join_path(request.GET['old_path'], request.GET['old_name'])
    path = join_path(request.GET['path'], request.GET['name'])
    to_delete = request.GET['to_delete']
    text = ''

    with open(old_path, 'r') as file:
        text = file.read()

    write_file(path, text)

    if to_delete == '1':
        delete(request, old_path)

    return HttpResponse(200)
