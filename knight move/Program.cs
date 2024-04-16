using System.Security.Cryptography.X509Certificates;

namespace knight_move
{
    internal class Program
    {
        public struct Point
        {
            public int Number;
            public int Letter;
            public Point(int x, int y)
            {
                
                Number = x;
                Letter = y;
            }
            public static bool isValid(int x , int y)
            {
                if(x>0 && x < 9)
                {
                    if(y <9 && y > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public static void KnightCan(int startNum,int startLet,int lastNum,int lastLet,ref int counts)
        {
            Point startPoint = new Point(startNum,startLet);
            Point lastPoint = new Point(lastNum, lastLet);
            
            int[] dx1 = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] dy1 = { -1, -2, -2, -1, 1, 2, 2, 1 };
            int[] dx2 = { -1, -1, 1, 1, 2, 2, -2, -2 };
            int[] dy2 = { -2, 2, -2, 2, -1, 1, -1, 1 };
            int[] dx3 = { -2, 2, -1, 1, 2, 1, -2, -1 };
            int[] dy3 = { -1, 1, -2, 2, -1, -2, 1, 2 };
            int[] dx4 = { -1, -1, -2, 2, 1, 1, -2, 2 };
            int[] dy4 = { 2, -2, 1, 1, 2, -2, -1, -1 };
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            int howmuchVariant = 1;
            if (lastNum < startNum + 3 && lastNum > startNum - 3 && lastLet < startLet + 3 && lastLet > startLet - 3)/*ete nuyn taracqi mej en 5 i 5ivra*/
            {
                for (int i = 0; i < 8; i++)/*mek qayl*/
                {
                    if (Point.isValid((startPoint.Number + dx1[i]), startPoint.Letter + dy1[i]))
                    {
                        Point next1Point = new Point(startPoint.Number + dx1[i], startPoint.Letter + dy1[i]);/*hajordi koordinatna*/
                        if (lastPoint.Number == next1Point.Number && lastPoint.Letter == next1Point.Letter && howmuchVariant == 1)/*ete hamynkav hasel enq*/
                        {
                            howmuchVariant++;
                            makingChase(startPoint.Number, letters[startPoint.Letter - 1], $"k{counts}");
                            counts++;
                            makingChase(next1Point.Number, letters[next1Point.Letter - 1], $"k{counts}");
                            break;
                        }
                    }
                }
                for (int i = 0; i < 8; i++)/*2 qayl*/
                {
                    if (Point.isValid((startPoint.Number + dx1[i]), startPoint.Letter + dy1[i]))
                    {
                        Point next1Point = new Point(startPoint.Number + dx1[i], startPoint.Letter + dy1[i]);/*hajordi koordinatna*/
                        
                        for (int j = 0; j < 8; j++) /*2 qayl*/
                        {
                            if (Point.isValid((next1Point.Number + dx2[j]), next1Point.Letter + dy2[j]))
                            {
                                Point next2Point = new Point(next1Point.Number + dx2[j], next1Point.Letter + dy2[j]);
                                if (next2Point.Number == lastPoint.Number && next2Point.Letter == lastPoint.Letter && howmuchVariant == 1)
                                {
                                    howmuchVariant++;
                                    makingChase(startPoint.Number, letters[startPoint.Letter - 1], $"k{counts}");
                                    counts++;
                                    makingChase(next1Point.Number, letters[next1Point.Letter - 1], $"k{counts}");
                                    counts++;
                                    makingChase(next2Point.Number, letters[next2Point.Letter - 1], $"k{counts}");
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < 8; i++)/*3 qayl*/
                {
                    if (Point.isValid((startPoint.Number + dx1[i]), startPoint.Letter + dy1[i]))
                    {
                        Point next1Point = new Point(startPoint.Number + dx1[i], startPoint.Letter + dy1[i]);/*hajordi koordinatna*/
                        
                        for (int j = 0; j < 8; j++) /*2 qayl*/
                        {
                            if (Point.isValid((next1Point.Number + dx2[j]), next1Point.Letter + dy2[j]))
                            {
                                Point next2Point = new Point(next1Point.Number + dx2[j], next1Point.Letter + dy2[j]);
                                
                                for (int k = 0; k < 4; k++)/*3 qayl*/
                                {
                                    if (Point.isValid(next2Point.Number + dx3[k], next2Point.Letter + dy3[k]))
                                    {
                                        Point next3Point = new Point(next2Point.Number + dx3[k], next2Point.Letter + dy3[k]);
                                        if (next3Point.Number == lastPoint.Number && next3Point.Letter == lastPoint.Letter && howmuchVariant == 1)
                                        {
                                            howmuchVariant++;
                                            makingChase(startPoint.Number, letters[startPoint.Letter - 1], $"k{counts}");
                                            counts++;
                                            makingChase(next1Point.Number, letters[next1Point.Letter - 1], $"k{counts}");
                                            counts++;
                                            makingChase(next2Point.Number, letters[next2Point.Letter - 1], $"k{counts}");
                                            counts++;
                                            makingChase(next3Point.Number, letters[next3Point.Letter - 1], $"k{counts}");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < 8; i++) /*4 qayl*/
                {
                    if (Point.isValid((startPoint.Number + dx1[i]), startPoint.Letter + dy1[i]))
                    {
                        Point next1Point = new Point(startPoint.Number + dx1[i], startPoint.Letter + dy1[i]);/*hajordi koordinatna*/
                       
                        for (int j = 0; j < 8; j++) 
                        {
                            if (Point.isValid((next1Point.Number + dx2[j]), next1Point.Letter + dy2[j]))
                            {
                                Point next2Point = new Point(next1Point.Number + dx2[j], next1Point.Letter + dy2[j]);
                                
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Point.isValid(next2Point.Number + dx3[k], next2Point.Letter + dy3[k]))
                                    {
                                        Point next3Point = new Point(next2Point.Number + dx3[k], next2Point.Letter + dy3[k]);
                                        
                                        for (int p = 0; p < 8; p++)
                                        {
                                            if (Point.isValid(next3Point.Number + dx4[p], next3Point.Letter + dy4[p]))
                                            {
                                                Point next4Point = new Point(next3Point.Number + dx4[p], next3Point.Letter + dy4[p]);
                                                if (next4Point.Number == lastPoint.Number && next4Point.Letter == lastPoint.Letter && howmuchVariant == 1)
                                                {
                                                    howmuchVariant++;
                                                    makingChase(startPoint.Number, letters[startPoint.Letter - 1], $"k{counts}");
                                                    counts++;
                                                    makingChase(next1Point.Number, letters[next1Point.Letter - 1], $"k{counts}");
                                                    counts++;
                                                    makingChase(next2Point.Number, letters[next2Point.Letter - 1], $"k{counts}");
                                                    counts++;
                                                    makingChase(next3Point.Number, letters[next3Point.Letter - 1], $"k{counts}");
                                                    counts++;
                                                    makingChase(next4Point.Number, letters[next4Point.Letter - 1], $"k{counts}");
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }


            }
            else if (startLet +2 < lastLet-2 || startLet -2 >lastLet - 2) /*vor yndhanor chunen*/
            {
                int[,] arr = new int[8,8];
                KnightStartCan(startNum, startLet,ref arr);
                
                for(int i =4; i < 8; i++)
                {
                    for(int j = 0; j < 8; j++)
                    {
                        if(Math.Abs(startNum - lastNum)< Math.Abs(startLet - lastLet))/*aravelutyuna tali */
                        {
                            if(8-i<startNum+2 && 8-i > startNum - 2 && arr[i,j] == 1) /*amenakarch qayly*/
                            {
                                makingChase(i , letters[j+1], $"k{counts}");
                            }
                        }
                    }
                }

            }
            

            
            else
            {
                
                string all = TheSamePoint(startNum, startLet, lastNum, lastLet);
                int reachNum = int.Parse(Convert.ToString(all[0]));
                int reachLet = int.Parse(Convert.ToString(all[1]));
                KnightCan(startNum, startLet, reachNum, reachLet,ref counts);
                KnightCan(reachNum, reachLet, lastNum, lastLet,ref counts);
            }
        }
        public static void KnightStartCan(int startNum, int startLet ,ref int[,] chessBordForStart)/*5 5 i vra urde qani qayla*/
        {
            chessBordForStart = new int[8, 8];
            int[] dx1 = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] dy1 = { -1, -2, -2, -1, 1, 2, 2, 1 };
            int[] dx2 = { -2, -1, 0, 1, 2, 1, 0, -1 };
            int[] dy2 = { 0, 1, 2, 1, 0, -1, -2, -1 };
            int[] dx3 = { -1, 0, 1, 0 };
            int[] dy3 = { 0, 1, 0, -1 };
            int[] dx4 = { -2, -2, 2, 2 };
            int[] dy4 = { -2, 2, 2, -2 };
            

            Point startPoint = new Point(startNum, startLet);
            for (int i = 0; i < 8; i++)
            {
                if (Point.isValid((startPoint.Number + dx1[i]), startPoint.Letter + dy1[i]))
                {
                    Point next1Point = new Point(startPoint.Number + dx1[i], startPoint.Letter + dy1[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number-1, next1Point.Letter-1] = 1;
                }
            }
            for(int i = 0; i < 8; i++)
            {
                if (Point.isValid((startPoint.Number + dx2[i]), startPoint.Letter + dy2[i]))
                {
                    Point next1Point = new Point(startPoint.Number + dx2[i], startPoint.Letter + dy2[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 2;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (Point.isValid((startPoint.Number + dx3[i]), startPoint.Letter + dy3[i]))
                {
                    Point next1Point = new Point(startPoint.Number + dx3[i], startPoint.Letter + dy3[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 3;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (Point.isValid((startPoint.Number + dx4[i]), startPoint.Letter + dy4[i]))
                {
                    Point next1Point = new Point(startPoint.Number + dx4[i], startPoint.Letter + dy4[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 4;
                }
            }

           
        }
        public static void KnightEndCan(int lastNum, int lastLet,ref int[,] chessBordForStart)/*verjnakety qani qala 5 5 i vra*/
        {
            chessBordForStart = new int[8, 8];
             
            int[] dx1 = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] dy1 = { -1, -2, -2, -1, 1, 2, 2, 1 };
            int[] dx2 = { -2, -1, 0, 1, 2, 1, 0, -1 };
            int[] dy2 = { 0, 1, 2, 1, 0, -1, -2, -1 };
            int[] dx3 = { -1, 0, 1, 0 };
            int[] dy3 = { 0, 1, 0, -1 };
            int[] dx4 = { -2, -2, 2, 2 };
            int[] dy4 = { -2, 2, 2, -2 };

            Point lastPoint = new Point(lastNum, lastLet);
            for (int i = 0; i < 8; i++)
            {
                if (Point.isValid((lastPoint.Number + dx1[i]), lastPoint.Letter + dy1[i]))
                {
                    Point next1Point = new Point(lastPoint.Number + dx1[i], lastPoint.Letter + dy1[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 1;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (Point.isValid((lastPoint.Number + dx2[i]), lastPoint.Letter + dy2[i]))
                {
                    Point next1Point = new Point(lastPoint.Number + dx2[i], lastPoint.Letter + dy2[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 2;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (Point.isValid((lastPoint.Number + dx3[i]), lastPoint.Letter + dy3[i]))
                {
                    Point next1Point = new Point(lastPoint.Number + dx3[i], lastPoint.Letter + dy3[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 3;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (Point.isValid((lastPoint.Number + dx4[i]), lastPoint.Letter + dy4[i]))
                {
                    Point next1Point = new Point(lastPoint.Number + dx4[i], lastPoint.Letter + dy4[i]);/*hajordi koordinatna*/
                    chessBordForStart[next1Point.Number - 1, next1Point.Letter - 1] = 4;
                }
            }          
        }
        public static string TheSamePoint(int startNum,int startLet,  int lastNum,int lastLet)
        {
            int[,] arrForStart = new int[8, 8];
            int[,] arrForLast = new int[8, 8];
            
            KnightStartCan(startNum, startLet, ref arrForStart);
            KnightEndCan(lastNum, lastLet, ref arrForLast);
            int min = 10;/*senc enq dnum vor mtni cikli mej*/
            int minForRows = 0;/*i eri hamar*/
            int minForColums = 0;/*j eri hamr*/
            

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if ( arrForStart[i,j]>0  && arrForLast[i,j]>0)
                    {

                       
                        if (min > arrForStart[i, j] + arrForLast[i, j])
                        {
                            min = arrForStart[i, j] + arrForLast[i, j];
                            minForRows = i;
                            minForColums = j;
                        }
                    }
                }
            }
            return ($"{minForRows+1}{minForColums+1}");
        }
        

        static void makingChase( int inputNum, char inputLet, string inputFigur)
        {
            int[,] boardSize = new int[10, 10];
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0 && i < 8)/*tverna tpum*/
                    {
                        Console.Write(8 - i);
                    }
                    else if (i == 8 && j >= 0)/*tareri hamra*/
                    {
                        Console.Write($"  {letters[j]}");
                    }
                    if ((i + j) % 2 == 0 && i < 8)
                    {

                        Console.BackgroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (8 - i == inputNum && letters[j] == inputLet) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigur + " ");
                    }
                    else if (i != 8 && j >= 0)
                    {
                        Console.Write("   ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(TheSamePoint(3, 3, 6, 5));
            //Console.WriteLine(TheSamePointForLast(3, 3, 6, 5));
            int count = 0;
            KnightCan(3, 1, 3, 8,ref count);
        }
    }
}
