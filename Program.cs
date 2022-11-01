namespace Ezednevnik
{
    internal class Program
    {
        static DateTime num = DateTime.Now;
        static int LevoPravo = 0;
        static int Woder = 2;
        static void Main(string[] args)
        {
            TheNote a = new TheNote()
            {
                Data = 29,
                Name = "Посидеть на кроватке",
                Podrobno = "Подумать о том, что ты очень ленив"
            };
            TheNote.zametka.Add(a);
            TheNote b = new TheNote()
            {
                Data = 29,
                Name = "Пойти погулять",
                Podrobno = "Позвать друзей, ой точнее уговорить их"
            };
            TheNote.zametka.Add(b);
            TheNote c = new TheNote()
            {
                Data = 29,
                Name = "Сгонять на соревы",
                Podrobno = "Проиграть и поехать домой, выходной всё-таки"
            };
            TheNote.zametka.Add(c);
            TheNote d = new TheNote()
            {
                Data = 30,
                Name = "Сделать с#",
                Podrobno = "Закрыть VisualStudio и понять что ты ТУПОЙЙЙ"
            };
            TheNote.zametka.Add(d);
            TheNote e = new TheNote()
            {
                Data = 30,
                Name = "Поспать, отоспаться",
                Podrobno = "Лечь в 5 встать в 5.05"
            };
            TheNote.zametka.Add(e);
            TheNote f = new TheNote()
            {
                Data = 30,
                Name = "Убраться",
                Podrobno = "Шутка, СПАТЬЬЬЬЬЬ"
            };
            TheNote.zametka.Add(f);
            TheNote g = new TheNote()
            {
                Data = 31,
                Name = "Отдохнуть",
                Podrobno = "Поехать в тех в свой грёбанный выходной, просидеть там 2 пары что бы послали куда подальше и поехать пить детское шомпанское)"
            };
            TheNote.zametka.Add(g);
            TheNote h = new TheNote()
            {
                Data = 31,
                Name = "Душевные разгоры",
                Podrobno = "Понять что ты философ, но очень тупой для всего этого"
            };
            TheNote.zametka.Add(h);
            TheNote i = new TheNote()
            {
                Data = 1,
                Name = "Придти в курилочкку на 30-миинутке",
                Podrobno = "Забиться с Софией Аликсеевной, что сделаю тортики до срока сдачи"
            };
            TheNote.zametka.Add(i);
            TheNote j = new TheNote()
            {
                Data = 1,
                Name = "Сделать тортики",
                Podrobno = "ааа, не понимаю как и что, а потом лежать всю ночь и думать как сделать эти ваши тортики(можно я просто приготовлю их вам)"
            };
            TheNote.zametka.Add(j);
            TheNote k = new TheNote()
            {
                Data = 1,
                Name = "Сидеть разбираться с тортиками",
                Podrobno = "Ничего не понимать, но что-то пытаться делать и со всеми усилиями написать эти ТТОРТИКИИИИ"
            };
            TheNote.zametka.Add(k);
            while (true)
            {
                Bykva();
                Clava();
                Strelka();
            }
        }
         private static void Bykva()
        {
            int Nomer = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Дела на:{num.AddDays(LevoPravo).Day}.{num.AddDays(LevoPravo).Month}.{num.AddDays(LevoPravo).Year}");
            foreach (var num1 in TheNote.zametka)
            {
                if (num1.Data == num.AddDays(LevoPravo).Day)
                {
                    Nomer++;
                    Console.SetCursorPosition(4, Nomer + 1);
                    num1.Nomer = Nomer;
                    Console.Write($"{num1.Nomer}.{num1.Name}\n");
                }
            }

        }
        private static void Clava()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    LevoPravo--;
                    break;
                case ConsoleKey.RightArrow:
                    LevoPravo++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Woder < 3)
                    {
                        Woder = 2;
                    }
                    else
                    {
                        Woder--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Woder > 3)
                    {
                        Woder = 4;
                    }
                    else
                    {
                        Woder++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    Console.SetCursorPosition(2, 6);
                    Console.WriteLine(" ВВсего хорошего!");
                    System.Environment.Exit(0);
                    break;
            }
        }
        private static void Pometka()
        {
            int Nomer = 0;
            Console.Clear();
            foreach (var num1 in TheNote.zametka)
            {
                if (num1.Data == num.AddDays(LevoPravo).Day)
                {
                    Nomer++;
                    num1.Nomer = Nomer;
                    if (Nomer == Woder - 1)
                    {
                        Console.Write($"  {num1.Name}\n");
                        Console.Write(" " + num1.Podrobno);
                    }
                }
            }
        }
        private static void Strelka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Woder);
            Console.Write("-->");
        }
    }
}