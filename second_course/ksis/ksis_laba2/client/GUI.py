from tkinter import *
from tkinter.filedialog import askopenfilename
from API import Api
import json


class GUI:

    def __init__(self):
        self.folder = '(папка):'
        self.path = ['/']
        self.old_path = ''
        self.old_name = ''
        self.to_delete = '0'
        self.api = Api('http://127.0.0.1:8000', 'admin', 'admin')
        self.root = Tk()

        self.root.geometry("400x250")

        self.listbox = Listbox(self.root, width=30, height=15)
        self.listbox.pack(side=LEFT)
        self.listbox.bind('<Double-1>', lambda x: self.listbox_click())
        self.fill_listbox()

        self.frame = Frame(self.root)
        self.frame.pack(side=LEFT)

        self.upload = Button(self.frame, text="Загрузить", command=self.upload)
        self.upload.pack()

        self.new_folder = Button(self.frame, text="Новая папка", command=self.new_folder)
        self.new_folder.pack()

        self.delete = Button(self.frame, text="Удалить", command=self.delete)
        self.delete.pack()

        self.copy = Button(self.frame, text="Копировать", command=self.copy_object)
        self.copy.pack()

        self.take = Button(self.frame, text="Вырезать", command=self.take)
        self.take.pack()

        self.paste = Button(self.frame, text="Вставить", command=self.paste)
        self.paste.pack()

        self.root.mainloop()
        pass

    def copy_object(self):
        self.old_name = self.get_file_name()
        self.old_path = "/".join(self.path)

    def take(self):
        self.copy_object()
        self.to_delete = '1'

    def paste(self):
        self.api.paste(self.path, self.old_name, self.old_path, self.old_name, self.to_delete)
        self.old_path = ''
        self.old_name = ''
        self.to_delete = '0'
        self.fill_listbox()

    def get_file_name(self):
        item = self.listbox.get('active')
        if item.find(self.folder) != -1:
            item = item.split(':')[1]
        return item

    def delete(self):
        self.api.delete(self.get_file_name(), self.path)
        self.fill_listbox()

    def fill_listbox(self):
        self.listbox.delete(0, END)
        out = self.api.file_list("/".join(self.path))
        files, directories = out.content.decode('utf-8').split('$')
        self.listbox.insert(END, "/")

        if len(directories) > 0:
            for item in directories.split(','):
                self.listbox.insert(END, self.folder + item)

        for item in files.split(','):
            self.listbox.insert(END, item)

    def upload(self):
        filepath = askopenfilename(initialdir="/home/oleg", title="Select file",
                                   filetypes=(("text", "*.txt"), ("all files", "*.*")))
        filename = filepath.split('/')[-1]
        files = {'file': (filename, open(filepath, 'rb'))}
        output = self.api.upload(file=files, path=self.path)
        self.listbox.insert(END, output.content.decode('utf-8'))
        self.fill_listbox()
        pass

    def new_folder(self):
        new_folder_modal = Toplevel(self.root)
        self.entry = Entry(new_folder_modal)
        self.entry.pack()

        create = Button(new_folder_modal, text="Создать", command=self.create_folder)
        create.pack()
        pass

    def create_folder(self):
        name = self.entry.get()
        self.api.create_folder(name, self.path)
        self.fill_listbox()

    def listbox_click(self):
        item = self.listbox.get('active')  # get clicked item
        folder = ''
        if item.find(self.folder) > -1:
            self.path.append(item.split(':')[1])
            self.fill_listbox()
            return
        if item == '/':
            if len(self.path) > 1:
                self.path.pop()
            self.fill_listbox()
            return
        else:
            self.file_modal(item)

    def file_modal(self, item):
        top = Toplevel(self.root)
        self.text = Text(top)
        self.text.pack()

        file = self.api.file_get_content(self.path, item)
        self.text.delete('1.0', END)
        self.text.insert(END, file.content.decode('utf-8'))

        save = Button(top, text="Сохранить", command=self.save)
        save.pack()

    def save(self):
        item = self.listbox.get('active')
        text = self.text.get("1.0", END)
        self.api.save(text, self.path, item)
        self.fill_listbox()
        pass
