using System;


namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper = 0;
            int mprivius = 0;
          int   nprivius = 0;
            int b = 0;
            int win = 0;
            int[] similarm = new int[49];
            int[] similarn = new int[49];
            int g;
            int player = 1;
            Console.WriteLine("Нажмите 1 чтоб играть");
            g = Convert.ToInt32(Console.ReadLine());
            int[,] pol = new int[7, 7];
            Random rand = new Random();
            if (g == 1)
            {
                Console.WriteLine("Введите имя игрока 1 ");
                string name1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите имя игрока 2 ");
                string name2 = Convert.ToString(Console.ReadLine());


                for (int i = 0; i < pol.GetLength(0); i++)
                {
                    for (int j = 0; j < pol.GetLength(1); j++)

                    {
                        pol[i, j] = rand.Next(100) ;
                        Console.Write($"\t\t*");
                    }

                    Console.WriteLine("\n\n");
                }
                
                do
                {

                    if (player == 1)
                    {
                        Console.WriteLine($"Делайте свой ход игрок: \n" + name1);
                    }
                    else
                    {
                        Console.WriteLine($"Делайте свой ход игрок: \n" + name2);
                    }

                    int m = Convert.ToInt16(Console.ReadLine());
                    int n = Convert.ToInt16(Console.ReadLine());
                    // similarm[b + 1] = m;
                    //similarn[b + 1] = n;
                    /*if (b ==1)
                    {
                        similarm[b] = mprivius;
                        similarn[b] = nprivius;
                       
                        
                                if (similarm[b] == similarm[b + 1] && similarn[b] == similarn[b + 1])
                                {
                                    oper= 1;
                                }
                            
                        
                    }
                    */
                    if (n >= 7 && m >= 7)
                    {
                        Console.WriteLine("Ход может быть только 0-6");

                    }
                    else if (oper == 1)
                    {
                        Console.WriteLine("нельзя делать ход");
                    }

                    else if (pol[n, m] == 1 || pol[n, m] == 2)
                    {
                        
                        
                            Console.WriteLine("Нельзя сделать ход здесь");
                        
                    }
                    else 
                    {


                        win = checkwin(pol, win);

                        switch (player)
                        {


                            case 1:
                                pol[m, n] = 1;
                                player = 2;
                                break;
                            case 2:
                                pol[m, n] = 2;
                                player = 1;
                                break;
                        }

                        for (int i = 0; i < pol.GetLength(0); i++)
                        {
                            for (int j = 0; j < pol.GetLength(1); j++)

                            {


                                if (pol[i, j] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                                    Console.Write("\t\t*");
                                    Console.ResetColor();

                                }
                                else if (pol[i, j] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                                    Console.Write("\t\t*");
                                    Console.ResetColor();
                                }
                                else if (pol[i, j] != 1 && pol[i, j] != 2)
                                {
                                    Console.Write("\t\t*");
                                }
                            }
                            Console.WriteLine("\n\n");
                        }

                    }
                    b++;
                    mprivius = m;
                    nprivius = n;
                }
                while(win!=1);
                Console.WriteLine("Вы победелили");
                Console.WriteLine(player);







            }

        }
        static int checkwin (int[,] pol,int win=0)

        {


            


            for (int i = 0; i < pol.GetLength(0); i++)
            {

                for (int j = 0; j < pol.GetLength(1); j++)
                {
                    

                        //горизонт
                        if (pol[i, 0] == pol[i, 1]& pol[i, 0] == pol[i, 2] & pol[i, 0] == pol[i, 3])
                            
                                {
                                   // if (pol[i, 0] != 0)
                                    
                                        win = 1;
                                    
                                }
                        if (pol[i, 3] == pol[i, 4] & pol[i, 3] == pol[i, 5] & pol[i, 3] == pol[i, 6])
                            
                                {
                        // if (pol[i, 3] != 0)

                        win = 1;
                                

                            }
                        if (pol[i, 1] == pol[i, 2] & pol[i, 1] == pol[i, 3] & pol[i, 1] == pol[i, 4])
                         
                                {
                        //  if (pol[i, 1] != 0)

                        win = 1;
                                
                            }
                        if (pol[i, 2] == pol[i, 3] & pol[i, 2] == pol[i, 4] & pol[i, 2] == pol[i, 5])
                            
                                {
                        // if (pol[i, 2] != 0)
                        win = 1;
                            }




                        //вертикаль
                        if (pol[0, j] == pol[1, j] & pol[0, j] == pol[2, j] & pol[0, j] == pol[3, j])
                            
                                {
                        // if (pol[0, j] != 0)
                        win = 1;
                            }
                        if (pol[3, j] == pol[4, j] & pol[3, j] == pol[5, j] & pol[3, j] == pol[6, j])
                           
                                {
                        //if (pol[3, j] != 0)
                        win = 1;
                            }

                        if (pol[1, j] == pol[2, j] & pol[1, j] == pol[3, j] & pol[1, j] == pol[4, j])
                            
                                {
                        // if (pol[1, j] != 0)
                        win = 1;
                            }
                        if (pol[2, j] == pol[3, j] & pol[2, j] == pol[4, j] & pol[2, j] == pol[5, j])
                            
                                {
                        // if (pol[2, j] != 0)
                        win = 1;
                            }





                        //диагональ
                        if (pol[0, 0] == pol[1, 1] & pol[0, 0] == pol[2, 2] & pol[0, 0] == pol[3, 3])
                           
                                {
                        //  if (pol[0, 0] != 0)
                        win = 1;
                            }
                        if (pol[1, 0] == pol[2, 1] & pol[1, 0] == pol[3, 2] & pol[1, 0] == pol[4, 3])
                            
                                {
                        //if (pol[1, 0] != 0)
                        win = 1;
                            }
                        if (pol[2, 0] == pol[3, 1] & pol[2, 0] == pol[4, 2] & pol[2, 0] == pol[5, 3])
                            
                                {
                        //if (pol[2, 0]!= 0)
                        win = 1;
                            }
                        if (pol[3, 0] == pol[4, 1] & pol[3, 0] == pol[5, 2] & pol[3, 0] == pol[6, 3])
                           
                                {
                        //if (pol[i, j] != 0)
                        win = 1;
                            }

                        //диагональ 2
                        if (pol[0, 0] == pol[1, 1]& pol[0, 0] == pol[2, 2]& pol[0, 0] == pol[3, 3])
                           
                                {
                        // if (pol[0, 0] != 0)
                        win = 1;
                    }
                        if (pol[0, 1] == pol[1, 2] & pol[0, 1] == pol[2, 3] & pol[0, 1] == pol[3, 4])
                            
                                {
                        // if (pol[0, 1] != 0)
                        win = 1;
                            }
                        if (pol[0, 2] == pol[1, 3] & pol[0, 2] == pol[2, 4] & pol[0, 2] == pol[3, 5])
                            
                                {
                        // if (pol[0, 2] != 0)
                        win = 1;
                            }
                        if (pol[0, 3] == pol[1, 4] & pol[0, 3] == pol[2, 5] & pol[0, 3] == pol[3, 6])
                           
                            {
                        //if (pol[0, 3] != 0)
                        win = 1;
                            }









                    

                }
            }
            return win;
        }
        static void playerx(int player, int[,] pol,int m,int n)
        {
            switch(player)
            {


                case 1:
                    pol[m, n]=1;
                    player = 2;
                    break;
                case 2:
                    pol[m, n] = 2;
                    player = 1;
                    break;
            }
        }
    }
}

