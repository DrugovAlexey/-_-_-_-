Итоговая контрольная работа по первому  блоку обучения по программе Разработчик.
Выполнила: Другова Ольга

Задание:
1. Создать репозиторий на GitHub (выполнено)
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод) (добавлена блок схема)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md) (данный файл)
4. Написать программу, решающую поставленную задачу (файл залит в репазиторий)
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
(несколько коммитов при создании кода, несколько Push в данный репазиторий)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Мною был выбран метод заранее наполненного массива - "hello_world", "2", "Russia", ":-)" , "123", "654654", "Fine"
Алгоритм решения:
1.	Создаем строковый массив;
2.	Выводим созданный массив. 
3.	Создаем второй метод, в котором указываем строковый массив.
4.	Создаем цикл для перебора элементвов массива. Ищем элементы с тремя и менее символами.
5.	Если условие удовлетворяется, то из ячейки нового массива произойдёт запись текущего элемента в ячейку исходного массива.
6.	Выводим полученный результат.
