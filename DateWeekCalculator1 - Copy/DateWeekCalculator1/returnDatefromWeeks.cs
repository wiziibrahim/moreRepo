using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{
    class returnDatefromWeeks
    {
        public static string returnDate(int day, int noOfweeksDays, string month)
        {
            string monthCheck4 = "January March May July August October December";//months containing 31 days
            var monthCheck5 = "April June September November Null Null Null";//months containing 30 days
            string[] monthCheckSplitWhSpace11 = monthCheck4.Split(' ');//converts string monthCheck to an array
            var monthCheckSplitWhsSpace12 = monthCheck5.Split(' ');
            string monthCheck6 = "February Null Null Null Null Null Null";
            var monthCheckSplitWhSpace13 = monthCheck6.Split(' ');
            string JanuaryToDecember = "January February March April May June July August September October November December";

            int i;
            int k;
            int m;
            int countDays = day;
            int countDownWeeks = noOfweeksDays;

            for (i = 0; i < 7; i++)
            {
                //Console.WriteLine("main for loop count - " + i);
                if (month == monthCheckSplitWhSpace11[i])//if month matches a month with 31 days
                {
                    for (k = 0; k <= 4; k++)
                    {
                        countDays = countDays + 7;
                        Console.WriteLine("day - " + countDays + ", month - " + monthCheckSplitWhSpace11[i]);
                        countDownWeeks = countDownWeeks - 7;
                        if (countDownWeeks == 0)
                        {
                            if (countDays > 31)
                            {
                                countDays = countDays - 31;
                                string[] nextMonth = JanuaryToDecember.Split(' ');
                                for (m = 0; m < 11; m++)
                                {
                                    if (monthCheckSplitWhSpace11[i] == nextMonth[m])
                                    {
                                        month = nextMonth[m + 1];
                                        m = 11;
                                    }
                                }
                                return countDays + " " + month;
                            }
                            else
                            {
                                Console.WriteLine("31 days month  \n" + "day - " + countDays + "\n" + "month - " + month);
                                return countDays + " " + monthCheckSplitWhSpace11[i];
                            }
                        }

                        if (countDays > 31)
                        {
                            countDays = countDays - 31;
                            string[] nextMonth = JanuaryToDecember.Split(' ');
                            for (m = 0; m < 11; m++)
                            {
                                if (monthCheckSplitWhSpace11[i] == nextMonth[m])
                                {
                                    month = nextMonth[m + 1];
                                    m = 11;
                                    Console.WriteLine("\nEnd of the month reached\n" + "Day of next month - " + countDays + "\n" + "Next month - " + month + "\n");
                                    k = 4;
                                    i = -1;
                                }
                            }
                           // Console.WriteLine("End of the month reached,  day - " + countDays + "  month - " + month);
                            //Console.WriteLine("Week count - " + countDownWeeks + ",   k count = " + k);
                        }
                    }
                }

               
                else if (month == monthCheckSplitWhsSpace12[i])//if month matches a month with 30 days
                {
                    for (k = 0; k <= 4; k++)
                        {
                            countDays = countDays + 7;
                            countDownWeeks = countDownWeeks - 7;
                            if (countDownWeeks == 0)
                            {
                                if (countDays > 30)
                                {
                                    countDays = countDays - 30;
                                    string[] nextMonth = JanuaryToDecember.Split(' ');
                                    for (m = 0; m < 11; m++)
                                    {
                                        if (month == nextMonth[m])
                                        {
                                            month = nextMonth[m + 1];
                                            m = 11;
                                        }
                                    }
                                    Console.WriteLine("30 days month  \n" + "day - " + countDays + "\n" + "month - " + month + "\n");
                                    return countDays + " " + month;
                                }
                                else
                                {
                                    return countDays + " " + month;
                                }
                            }


                            if (countDays > 30)
                            {
                                countDays = countDays - 30;
                                string[] nextMonth = JanuaryToDecember.Split(' ');
                                for (m = 0; m < 11; m++)
                                {
                                    if (month == nextMonth[m])
                                    {
                                        month = nextMonth[m + 1];
                                        m = 11;
                                    Console.WriteLine("30 days month  \n" + "day - " + countDays + "\n" + "month - " + month);
                                    k = 4;
                                    i = -1;
                                    }
                                }
                            }
                        }
                }
                else if (month == monthCheckSplitWhSpace13[i])//if month matches a month with 28 days
                {
                    //Console.WriteLine("end of the month second check,  day - " + countDays + "  month - " + month);
                    //int n = (28 - countDays) / 7;
                    Console.WriteLine("28 days month");
                    for (k = 0; k <= 4; k++)
                    {
                        Console.WriteLine("day - " + countDays + ", month - " + monthCheckSplitWhSpace13[i]);
                        countDays = countDays + 7;
                                countDownWeeks = countDownWeeks - 7;
                        //Console.WriteLine("final result,  "+ "day  -"+ countDays + "weeks count - " + countDownWeeks);
                        if (countDownWeeks == 0)
                        {
                                    if (countDays > 28)
                                    {
                                        countDays = countDays - 28;
                                        string[] nextMonth2 = JanuaryToDecember.Split(' ');
                                Console.WriteLine("final result,  " + countDays + "month - " + month);
                                for (m = 0; m < 11; m++)
                                        {
                                            if (monthCheckSplitWhSpace13[i] == nextMonth2[m])
                                            {
                                                month = nextMonth2[m + 1];
                                                m = 11;
                                            }
                                        }
                                        Console.WriteLine("28 days month  \n" + "day - " + countDays + "\n" + "month - " + month);
                                        return countDays + " " + month;
                                    }
                                    else
                                    {
                                        return countDays + " " + monthCheckSplitWhSpace13[i];
                                    }
                                }

                                if (countDays > 28)
                                {
                                    countDays = countDays - 28;
                                    string[] nextMonth3 = JanuaryToDecember.Split(' ');
                                    for (m = 0; m < 11; m++)
                                    {
                                        if (monthCheckSplitWhSpace13[i] == nextMonth3[m])
                                        {
                                            month = nextMonth3[m + 1];
                                            m = 11;
                                            Console.WriteLine("\nEnd of the month reached\n" + "Day of next month - " + countDays + "\n" + "Next month - " + month + "\n");
                                            k = 4;
                                            i = -1;
                                        }
                                    }

                                }
                    }
                }                
            }
            return "Invalid data entered";
        }
    }
}
