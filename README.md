_Задача:_
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []


_Решение:_

* Объявляем два массива (исходный и новый).
* Считаем количество элементов в массиве, длина которых меньше или равна 3 символам (при помощи счетчика count).
* Создаем новый массив, длина которого равна количеству подсчитанных элементов.
* Наполняем новый массив элементами, длина которых меньше или равна 3 символам.
* Выводим на печать исходный и новый массив.