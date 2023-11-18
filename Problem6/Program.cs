using System;
using System.Collections.Generic;


        Dictionary<string, List<string>> companies = new ();

        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] inputArray = input.Split(" -> ");
            string company = inputArray[0];
            string employeeId = inputArray[1];

            if (!companies.ContainsKey(company))
            {
                companies[company] = new List<string>();
            }
            if (!companies[company].Contains(employeeId))
            {
                companies[company].Add(employeeId);
            }
            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, List<string>> CurrentCompany in companies)
        {
            Console.WriteLine(CurrentCompany.Key);
            foreach (string currentEmployeeId in CurrentCompany.Value)
            {
                Console.WriteLine($"-- {currentEmployeeId}");
            }
}
//              Вариант от CHAT GPT
//        using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

//        string input;
//        while ((input = Console.ReadLine()) != "End")
//        {
//            string[] tokens = input.Split(" -> ");
//            string companyName = tokens[0];
//            string employeeId = tokens[1];

//            if (!companies.ContainsKey(companyName))
//            {
//                companies[companyName] = new HashSet<string>();
//            }

//            companies[companyName].Add(employeeId);
//        }

//        foreach (var company in companies)
//        {
//            Console.WriteLine($"{company.Key}");
//            foreach (var employeeId in company.Value)
//            {
//                Console.WriteLine($"-- {employeeId}");
//            }
//        }
//    }
//}


