using System; 

namespace MycosQuiz
{
    public class EmployeeData
    {
        public class boxData
        {
            public string first_name {get; set;}
            public string last_name {get; set;}
            public string date_of_birth {get; set;}
            public string start_work_date {get; set;}
            public string salary {get; set;}
            public string pvd_fund_rate {get; set;}
            public void resetData()
            {
                first_name = "";
                last_name = "";
                date_of_birth = "";
                start_work_date = "";
                salary = "";
                pvd_fund_rate = "";
            }
        }  
    }
}