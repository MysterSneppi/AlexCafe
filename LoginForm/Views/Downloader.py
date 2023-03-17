import requests
import os

# Функция для скачивания папок и подпапок с сайта
def download_directory(url, local_path):
    # Получаем список всех файлов в директории
    response = requests.get(url)
    files = response.text.splitlines()
    
    # Проходимся по каждому файлу в директории
    for file in files:
        file_url = f"{url}/{file}"
        file_path = os.path.join(local_path, file)
        
        # Если файл это директория, то создаем папку и рекурсивно вызываем функцию для загрузки файлов из этой директории
        if file.endswith('/'):
            os.makedirs(file_path, exist_ok=True)
            download_directory(file_url, file_path)
        # Если файл это файл, то загружаем его
        else:
            response = requests.get(file_url)
            with open(file_path, 'wb') as f:
                f.write(response.content)

# Пример использования функции
url = 'https://files.dumpforums.to/Russia'
local_path = 'C:/Downloads/files'

download_directory(url, local_path)
