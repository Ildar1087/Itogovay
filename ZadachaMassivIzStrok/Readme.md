Согласно заданию, была составлена блок схема для решения задачи.
По этой блок схеме написана программа, реализации алгоритма решения.
Было решено предоставить пользователю создать количественный массив из "k" элементов и 
 число ограничений длины массива задать переменной "о".
Далее была создана функция AddMassString. В ней реализовано создание массива элементов из
введеных ранее значений пользователем - "k" и "о".
далее полученный массив был направлен в функцию FiltrMass. Там производился отбор элементов по значению "о",
с дальнейшей записью их в новый массив tempArray, который возращал значение посредствам метода return.
Полученный результат отправлялся в функцию PrintResults, по средствам которой обеспечивается вывод результирующих
значений в консоль, согласно заданию, т.е. "Значения из массива меньше или равны {o} символам:"
