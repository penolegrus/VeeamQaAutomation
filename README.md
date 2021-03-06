# VeeamQaAutomation
Тестовое задание на позицию Junior Qa Automation

# Задание 1

Написать на C# утилиту, которая мониторит процессы Windows и закрывает те процессы, которые работают слишком долго.

- На входе три параметра: название процесса, допустимое время жизни (в минутах) и частота
проверки (в минутах)

- Утилита запускается из командной строки. При старте она считывает три входных параметра и
начинает мониторить процессы с указанной частотой. Если процесс живет слишком долго – завершает его и выдает сообщение в лог.
Пример запуска:

monitor.exe notepad 5 1

С такими параметрами утилита раз в минуту проверяет, не живет ли процесс notepad больше пяти
минут, и &quot;убивает&quot; его, если живет.

Пример запуска приложения:

Скачиваем репозиторий на компьютер, открываем cmd и открываем путь к папке VeeamQaAutomation\VeeamTask1\bin\Debug\netcoreapp3.1

Далее запускаем утилиту с необходимыми аргументами, например "VeeamTask1 Notepad 1 1" (Процесс Notepad будет жить 1 минуту и проверять каждую 1 минуту)

# Задание 2

С помощью Selenium WebDriver выполнить следующую процедуру:

- Зайти на страницу https://careers.veeam.ru/vacancies и развернуть браузер во весь экран.

- Из списка отделов выбрать Разработка продуктов, из списка языков выбрать Английский.

- Подсчитать количество выданных вакансий и сравнить с ожидаемым результатом.

Примечания:

- Желательно параметризовать значения входных параметров и ожидаемого количества вакансий,

чтобы этот код можно было использовать для разного набора параметров.

- Браузер можно использовать любой.

Пример запуска теста:

Тест выполнен с использованием паттерна Page Factory

Открываем проект VeeamTask2.sln, далее открываем обозреватель тестов и запускаем тест под названием AssertCount

Параметры можно поменять в переменных:
- expectcount - ожидаемое количество вакансий в классе MainTest.cs
- departure - название отдела в классе CarrerPage.cs
