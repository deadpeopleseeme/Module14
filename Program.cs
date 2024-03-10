namespace Module14LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>
            {
                // добавляем контакты
                new("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new("Сергей", "Брин", 799900000013, "serg@example.com"),
                new("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };

            while (true)
            {
                Console.WriteLine("Введите номер страницы телефонной книги: ");
                // Читаем введенный с консоли символ
                var input = Console.ReadKey().KeyChar;

                // проверяем, число ли это
                var parsed = int.TryParse(input.ToString(), out int pageNumber);

                // если не соответствует критериям - показываем ошибку
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.Clear();
                    Console.WriteLine($"Страницы {input} не существует!\n");
                }
                // если соответствует - запускаем вывод
                else
                {
                    Console.Clear();

                    // пропускаем нужное количество элементов и берем 2 для показа на странице
                    var pageContent = phoneBook.Skip((pageNumber - 1) * 2).Take(2);
                    var pageContentSorted = from e in pageContent orderby e.Name, e.LastName select e;

                    // выводим результат
                    foreach (var entry in pageContentSorted)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

                    Console.WriteLine();
                }
            }
        }
    }
}
