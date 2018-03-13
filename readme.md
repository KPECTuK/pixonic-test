#### Текст задания ####

  Необходимо сделать игровую симуляцию для MOBA-подобной игры.
В игре участвуют 4 игрока (две команды 2х2).
У каждого игрока есть по одному герою. Герой выбирается случайно при старте игры.
Герои игроков могут автоматически атаковать друг друга.

У автоатаки есть:

- радиус действия, зависящий от типа героя;
- количество наносимого урона;
- скорость атаки (базовое значение раз в секунду).

В игре есть следующие герои:

##### Герой 1 #####

Здоровье: 100 HP
Скорость передвижения: 2 у.е.
Радиус атаки: 2 уе.
Количество наносимого урона: 5 уе.
При автоатаке накладывает эффект замедления cooldown атаки противника в 2 раза на 1 сек (автоатака противника срабатывает раз в 1,5 секунды). Эффект не стекается.

##### Герой 2 #####

Здоровье: 100 HP
Скорость передвижения: 2 у.е.
Радиус атаки: 10 уе.
Количество наносимого урона: 2 уе.
При автоатаке замедляет скорость передвижения противника в 2 раза на 1 сек.

##### Герой 3 #####

Здоровье: 100 HP
Скорость передвижения: 2 у.е.
Радиус атаки: 2 уе.
Количество наносимого урона: 2 уе.
Имеет ауру, находясь в которой, союзник получает шанс сделать удар критическим (аура имеет радиус действия 5 уе, с вероятностью 50% увеличивает урон автоатаки в 2 раза).


На вход в игровую симуляцию (один тик) приходят:

- массив из четырех векторов (x,y) - направление перемещения героев;
- время прошедшее с предыдущего тика симуляции.

Требования к реализации:

- должен быть написан на языке C#;
- код должен быть гибким и масштабируемым (количество героев и умению будет постоянно расти);
- код должен быть тестируемым (пригодным для покрытия unit-тестами).