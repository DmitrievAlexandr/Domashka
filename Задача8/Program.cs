Console.WriteLine("Введите число:");
            try
            {
                var N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Четные числа из интервала 1 до " + N + ": ");
                for (int i = 2; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Значение не является числом");
            }
