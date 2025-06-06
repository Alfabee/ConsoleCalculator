# ConsoleCalculator

Простий консольний калькулятор на C#, розроблений у рамках лабораторної роботи №1 з Git.

## 🔧 Функціонал

- Базові операції: додавання, віднімання, множення, ділення
- Логування результатів у файл (`log.txt`)
- Перевірка ділення на 0 через валідатор

## 📁 Структура

├── Calculator.cs # Реалізація ICalculator
├── ICalculator.cs # Інтерфейс калькулятора
├── Logger.cs # Реалізація ILogger
├── ILogger.cs # Інтерфейс логера
├── Validator.cs # Реалізація IValidator
├── IValidator.cs # Інтерфейс валідатора
├── Program.cs # Точка входу
├── log.txt # Журнал операцій
├── .gitignore
└── README.md

markdown
Копіювати
Редагувати

## 💻 Використання

1. Запусти програму
2. Введи два числа
3. Отримай результат і переглянь запис у `log.txt`

## 📚 Гілки

- `master` — основна стабільна версія
- `feature/logger` — логування операцій
- `feature/validator` — захист від ділення на нуль

## ✍️ Автор

> Ім'я: Alfabee  
> Лабораторна робота №1  
> Дисципліна: Засоби командної розробки ПЗ (Git)
