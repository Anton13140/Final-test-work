# Итоговая тестовая работа

## Задача.

Написать программу, которая из имеющегося массива из строкдлина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, обойтись исключительно массивами.
Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод).

## Решение. 

* Объявляем массив **array** и **productArray** типа **String**. С помощью терминала запрашиваем длину массива **array** и задаем элементы массива при помощи метода **FillArray()**, результат метода передаем в массив **array**.
* Вызываем метод **SortArray()** с аргументом **array**. При помощи цикла **for** метода, отсеиваем длину строки массива в соответствии с заданием и помещаем его в новый массив **newArray**. По завершению цикла, при помощи функции **Array.Resize** создаем новый массив с необходимой длинной. Результат метода передаем в массив **productArray**. Ниже блок-схема **SortArray()**
![блок-схема SortArray](https://downloader.disk.yandex.ru/preview/97dc576b5a697baaa26934893f72fa2c41b4d7af859ae489ec450025a034d834/6392a00e/QSDbNKsdDs6HsEPoTPj-qci4Jafj1Mcn7mTfYZ6Qqh6d7Q8V4ZtQ42zW_GuQBC4ciRzGFClDa54NBQxHhtOVoQ%3D%3D?uid=0&filename=BD.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=0&tknv=v2&size=2048x2048)

* Вызываем метод **PrintArray()** с аргументом **newArray**, который выводит массив в терминал.