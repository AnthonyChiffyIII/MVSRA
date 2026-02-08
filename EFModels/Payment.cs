using System.ComponentModel.DataAnnotations;

namespace MVSRA.Server.EFModels;

public class Payment
{
    #region Properties
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public int MaxAge { get; set; } = 20;

    public double CenterReferee { get; set; } = 0.0;

    public double AssistantReferee { get; set; } = 0.0;

    public double FourthOfficial { get; set; } = 0.0;
    #endregion

    #region CalculatedProperties
    public string AgeGroup => MaxAge > 19 ? "Adult" : $"U{MaxAge}";

    public int BirthYear => DateTime.Now.Year - MaxAge;
    #endregion

    public Payment()
    {

    }

    public Payment(int maxAge, double centerReferee, double assistantReferee, double fourthOfficial = 0.0)
    {
        MaxAge = maxAge;
        CenterReferee = centerReferee;
        AssistantReferee = assistantReferee;
        FourthOfficial = fourthOfficial;
    }
}
