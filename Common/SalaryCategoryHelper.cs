namespace SmartBiz.API.Common;

public static class SalaryCategoryHelper
{
    public static string GetSalaryCategory(decimal salary)
    {
        return salary switch
        {
            < 20000 => "Low Salary",
            < 40000 => "Average Salary",
            < 60000 => "Good Salary",
            _ => "High Salary"
        };
    }
}