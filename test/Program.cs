 int x = 45;
            string s = "";
            while (x > 0)
            {
                s = ((x % 2 == 0) ? "0" : "1") + s;
                x /= 2;
            }
            Console.Write(s);
            Console.ReadKey();