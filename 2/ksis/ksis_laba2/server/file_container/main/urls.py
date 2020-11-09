from django.conf.urls import url

from . import views

urlpatterns = [
    url(r'^upload/$', views.upload, name='upload'),
    url(r'^file_list/$', views.file_list, name='file_list'),
    url(r'^get_file/$', views.get_file, name='get_file'),
    url(r'^save/$', views.save, name='save'),
    url(r'^create_folder/$', views.create_folder, name='create_folder'),
    url(r'^delete/$', views.delete, name='delete'),
    url(r'^paste/$', views.paste, name='paste'),
]