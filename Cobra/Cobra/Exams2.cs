using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class Exams2
    {
        private int chem, phy, maxmarks, passmarks;
        private int invalidmarks, failed;

        public Exams2()
        {
            maxmarks = 100;
            passmarks = 50;
        }

        public Exams2(int M, int P)
        {
            maxmarks = M;
            passmarks = P;
        }

                public void physics(int p)
                {
                    if (p >= 0 && p < maxmarks)
                    {
                        phy = p;
                        if (p < 60)
                        {
                            failed = 1;
                        }
                    }
                    else
                    {
                        invalidmarks = -1;
                        Console.WriteLine("Invalid physics marks. " + maxmarks + " are the the maximum marks");
                    }
                }
                        public void chemistry(int c)
                        {
                            if (c >= 0 && c < maxmarks)
                            {
                                phy = c;
                                if (c < 60)
                                {
                                    failed = 1;
                                }
                            }
                            else
                            {
                                invalidmarks = -1;
                                Console.WriteLine("Invalid Chemistry marks. " + maxmarks + " are the the maximum marks");
                            }

                        }
                                            public void showresults()
                                            {
                                                float total, per;
                                                total = phy + chem;
                                                per = total * 100 / 450;
                                                if (invalidmarks == 0)
                                                {
                                                    if (failed == 0)
                                                    {
                                                        Console.WriteLine("Your total marks are: " + total);
                                                        Console.WriteLine("Your percentage is: " + per);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("you have failed the exam");
                                                    }


                                                }
                                            }
    }
}
