using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class Task4
{
    static int CalculateDays(DateTime inDateStart, DateTime inDateEnd)
    {
        int DaysCounter = 0;

        do
        {
            DaysCounter++;
            if (inDateEnd > inDateStart) inDateEnd = inDateEnd.AddDays(-1);
            else inDateEnd = inDateEnd.AddDays(1);
        }
        while (inDateEnd.Date != inDateStart.Date);

        return DaysCounter;
    }

    static void Main()
    {
        System.Globalization.CultureInfo objCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Clone() as System.Globalization.CultureInfo;
        objCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
        System.Threading.Thread.CurrentThread.CurrentCulture = objCulture;

        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime dateStart = DateTime.Parse(string.Format("01-01-{0}",startYear));
        DateTime dateEnd = DateTime.Parse(string.Format("31-12-{0}", endYear));

        DateTime[] dates = new DateTime[CalculateDays(dateStart,dateEnd)];
        for (int i = 0; i < dates.Length; i++) dates[i] = dateStart.AddDays(i);

        int resultIndex = 0;
        for (int i = 0; i < dates.Length; i++)
        {
            int sum = 0;
            string currentDate = dates[i].ToString();

            for (int j = 0; j < 9; j++)
            {
                if (j == 2 || j == 5) continue;
                for (int k = j + 1; k < 10; k++)
                {
                    if (k == 2 || k == 5) continue;
                    sum += (int)(currentDate[j] - '0') * (int)(currentDate[k] - '0');
                    if (sum > magicWeight) break;
                }
                if (sum > magicWeight) break;
            }
            if (sum == magicWeight)
            {
                dates[resultIndex] = dates[i];
                resultIndex++;
            }
        }

        if (resultIndex > 0)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < resultIndex; i++) sb.AppendLine(string.Format("{0:dd-MM-yyyy}", dates[i]));

            Console.WriteLine(sb.ToString());
        }
        else Console.WriteLine("No");
    }
}

