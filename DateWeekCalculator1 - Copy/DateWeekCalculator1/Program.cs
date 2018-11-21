using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{

class Program
{
    static void Main(string[] args)
    {
            LoginData loginID = new LoginData();//login class LoginData
            Console.WriteLine("\n\n\n");
            Console.Write("\t\t\t");
            Console.WriteLine("Enter username:");
            Console.Write("\t\t\t");
            String Username = Console.ReadLine();
            Console.Write("\t\t\t");
            Console.WriteLine("Enter Password:");
            Console.Write("\t\t\t");
            String Password = Console.ReadLine();

            String account = LoginData.loginInfo(Username, Password);
            if (account=="locked")
            {
                //Console.ReadKey();
                return;
            }
            else
            {
                Console.Write("\t\t\t");
                Console.WriteLine(account);
            }

            string months = "January February March April May June July August September October November December";
        var splitMonths = months.Split(' ');//split the string months into an array by whitespace ' '
                                            /*Console.WriteLine(splitMonths[0]);//return string in position 0 which is January
                                            Console.WriteLine(splitMonths[0].Length);//prints to console length of January
                                            Console.WriteLine(months.Length);//prints to console length of string month
                                            var whiteSpace = months.IndexOf(' ');//evaluate the position of the first whitespace in string months
                                            //Console.WriteLine(whiteSpace);// print the position represented by the first whitespace in months
                                            var L = months.LastIndexOf(Console.ReadLine());
                                            Console.WriteLine(L);*/

        Console.WriteLine("\n\n");//create new line in console
        Console.Write("\t\t\t");//create tab in console
        Console.WriteLine("Enter the Month of the year:");
        Console.Write("\t\t\t");
        string newMonth = Console.ReadLine();//enter month of the year on Console and store in newMonth
        int ii;
        for (ii = 0; ii < 12; ii++)
        {
            //Console.WriteLine(splitMonths[ii]);
            if (newMonth == splitMonths[ii])//if  newMonth is equal to the matching month in the for loop
                                            //execute the code below. The purpose of this code is to determine the number of the particular month
                                            //in the year. If April was entered on the console then ii+1 should be 4.
            {
                Console.Write("\t\t\t");
                Console.WriteLine("Month Entered is - " + splitMonths[ii]);
                Console.Write("\t\t\t");
                Console.WriteLine("Month " + (ii + 1) + " of the year");

                Console.ReadKey();
                Console.WriteLine("\n\n");
                Console.Write("\t\t\t");
                Console.WriteLine("Months to Year End as Follows:");
                Console.WriteLine("\n");
                int startMonthCal;
                for (startMonthCal = ii + 1; startMonthCal < 12; startMonthCal++)//display the remaining months of the year                                                                                //starting from month determined in for loop above. 
                {
                    Console.Write("\t\t\t");
                    Console.WriteLine(splitMonths[startMonthCal]);
                }
                //Console.ReadKey();
                // return;//at end of result return to start of code. 
                Console.WriteLine("\n");
                Console.Write("\t\t\t");
                Console.WriteLine("Enter date of the month");
                Console.Write("\t\t\t");
                int enterDateData = int.Parse(Console.ReadLine()); //Convert number string from console to integer
                    weeksCalculation33 getDate44 = new weeksCalculation33();
                string showDateResult = weeksCalculation33.getDate(enterDateData, splitMonths[ii]); //execute method getDate with two parameters (date and month)               
                string[] NewDate = showDateResult.Split(' ');
                    Console.Write("\t\t\t");
                    Console.WriteLine("Date Entered is - " + NewDate[0] + " " + NewDate[1]);
                    Console.Write("\t\t\t");
                    Console.WriteLine("Days to end of " + NewDate[1] + " = " + NewDate[2]);
                int UU = int.Parse(NewDate[2]);
                    //Console.WriteLine(UU);
                    Console.WriteLine("\n\n\n");
                    Console.Write("\t\t\t");
                    Console.WriteLine("Enter number of weeks");
                    Console.Write("\t\t\t");
                    int weekstoDays = int.Parse(Console.ReadLine()) * 7;// convert weeks into integer and get total no of days
                    Console.Write("\t\t\t");
                    Console.WriteLine("Number of weeks = " + weekstoDays + "days");
                    //Console.WriteLine("date - " + enterDateData);

                    string result = returnDatefromWeeks.returnDate(enterDateData, weekstoDays, newMonth);
                    Console.WriteLine("\n\nShow final result " + result);


                    string monthCheck4 = "January March May July August October December";//months containing 31 days
                    var monthCheck5 = "April June September November Null Null Null";//months containing 30 days
                    string[] monthCheckSplitWhSpace11 = monthCheck4.Split(' ');//converts string monthCheck to an array
                    var monthCheckSplitWhsSpace12 = monthCheck5.Split(' ');
                    string monthCheck6 = "February Null Null Null Null Null Null";
                    var monthCheckSplitWhSpace13 = monthCheck6.Split(' ');


                    //actualWeeksCalc.getDate2();

                    int iv;
                    for (iv=0; iv<7;iv++)
                    {
                        if (NewDate[1] == monthCheckSplitWhSpace11[iv])
                        {
                           //Console.WriteLine("NewDate - " + NewDate[1]);
                            //Console.WriteLine("monthCheckSplitWhSpace11[iv] - " + monthCheckSplitWhSpace11[iv]);
                            iv = 7;
                            //actualWeeksCalc.getDate2(enterDateData, weekstoDays, iv, NewDate[1], monthCheckSplitWhSpace11[iv], splitMonths[ii]);
                            //Console.WriteLine("NewDate - " + NewDate[1]);
                            //Console.WriteLine("monthCheckSplitWhSpace11[iv] - " + monthCheckSplitWhSpace11[iv]);
                            
                            int vi;
                            int enterDateData33 = enterDateData;                           
                            int firstWeek2 = weekstoDays;
                            //Console.WriteLine("weektoDays " + weekstoDays);
                            for (vi=0; vi<=weekstoDays; vi=vi+7)
                            {
                                if (enterDateData33 <=31 && firstWeek2 == 0)
                                {
                                    //Console.WriteLine(enterDateData33 + " " + splitMonths[ii]);
                                    firstWeek2 = 0;
                                    vi = weekstoDays;
                                    Console.ReadKey();
                                    return;
                                }                                
                                //Console.WriteLine("Display date "+ enterDateData33);
                                int enterDateData44 = enterDateData33 + 7;
                                
                                int firstWeek22 = firstWeek2;
                                Console.WriteLine("firstWeek22 " + firstWeek22);
                                if (enterDateData44>31)
                                {
                                    int firstWeek33 = firstWeek2;
                                    Console.WriteLine("firstWeek33 " + firstWeek33);
                                    
                                    enterDateData33 = enterDateData44 - 31;//enterDateData33
                                    Console.WriteLine("enterDateData44 ="+ enterDateData33);
                                    int vii;
                                    int viii;
                                    for (vii = 0; vii <= 7; vii=vii+1)
                                    {
                                        if (splitMonths[ii + 1] == monthCheckSplitWhSpace13[vii])
                                        {
                                            vii = 7;
                                            for (viii=0 ; viii<= firstWeek22; viii= viii+ 7)
                                            {
                                                if (enterDateData33 <= 28 && firstWeek2 == 7)
                                                {
                                                    Console.WriteLine(enterDateData33 + " " + splitMonths[ii + 1]);
                                                    firstWeek2 = 7;
                                                    viii = firstWeek2;
                                                    Console.ReadKey();
                                                    return;
                                                } else
                                                enterDateData33 = enterDateData33 + 7;
                                                Console.WriteLine(enterDateData33);

                                                firstWeek2 = firstWeek2 - 7; 
                                                Console.WriteLine("firstWeek2 - " + firstWeek2);
                                                Console.WriteLine("viii - " + viii);
                                                if (enterDateData33 > 28)
                                                {
                                                    enterDateData33 = enterDateData33 - 28;

                                                }
                                            }
                                        }                                       
                                        else if(splitMonths[ii + 1] == monthCheckSplitWhsSpace12[vii] || splitMonths[ii + 1]==monthCheckSplitWhSpace11[4])
                                        {
                                            vii = 7;
                                            for (viii = 0; viii <= firstWeek22; viii = viii + 7)
                                            {
                                                if (enterDateData33 <= 30 && firstWeek2 == 7)
                                                {
                                                    Console.WriteLine(enterDateData33 + " " + splitMonths[ii + 1]);
                                                    firstWeek2 = 7;
                                                    viii = firstWeek2;
                                                    Console.ReadKey();
                                                    return;
                                                }
                                                enterDateData33 = enterDateData33 + 7;
                                                firstWeek2 = firstWeek2 - 7;                                                
                                            }
                                        }
                                        Console.ReadKey();
                                    }
                                }
                                enterDateData33 = enterDateData33 + 7;
                                firstWeek2 = firstWeek2 - 7;                                
                            }
                        }
                        else if (NewDate[1]==monthCheckSplitWhsSpace12[iv])
                        {
                            if (weekstoDays < 30)
                            {
                                int actualDate = weekstoDays + enterDateData;
                                Console.WriteLine(actualDate + " " + NewDate[1]);
                                iv = 7;
                            }
                        }
                        else if(NewDate[1] == monthCheckSplitWhSpace13[iv])
                        {
                            if (weekstoDays < 28)
                            {
                                int actualDate = weekstoDays + enterDateData;
                                Console.WriteLine(actualDate + " " + NewDate[1]);
                                iv = 7;
                            }
                        }
                    }              
                Console.ReadKey();
            }
        }
    }    
}
}
