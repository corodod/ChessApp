Задача 2

Базовый класс: шахматная фигура (реализовать свойства цвет фигуры, положения фигуры на доске, метод сделать ход, указывается куда, если ход возможен, то меняются свойства положения фигуры, данный метод должен вызывать защищённый абстрактный (protected) метод, который проверяет возможность перехода в заданное положение - перекрывается в производных классах).

Производные классы: Ферзь, Ладья, Слон. 
В данных классах перекрывается метод, который проверяет возможность перехода в заданное положение.








Задача 4 

Необходимо с помощью рефлексии реализовать возможность создания  и вызова методов данных классов на форме.
В программе необходимо предусмотреть ввод пути к библиотеке классов, программа должна загрузить её, найти все классы, которые реализуют нужный интерфейс. 
Получить всю информацию о данных классах, вывести список названий классов. 
При выборе класса на форму должны динамически подгружаться все методы класса с возможностью ввода параметров пользователем. 
При нажатии кнопки «Выполнить» должен создаваться объект и выполняться выбранный метод.

Обязательно: 

Классы реализуются в отдельном модуле. 
Программа оформляется в соответствии с требованиями к разработке ПО (отступы, названия переменных и т.п.). 
В конструкторе класса могут и должны быть настроены значения полей и свойств класса, но инициализация значений должна быть вне класса. 
Например, не следует в конструкторе класса задавать в списке какие-то значения, или какое-то имя студента, если они не передаются в конструктор через параметр.
Программа должна быть оконным приложением.
Желательно придерживаться модели MVVM.
