/// <summary>
/// A member in the bowling tournament 
/// </summary>
class Member
{
    /// <summary>
    /// legal first name
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// legal last name
    /// </summary>
    public string? LastName { get; set;}

    /// <summary>
    /// Player handicap
    /// </summary>
    public int Handicap { get; set; }

    /// <summary>
    /// Player average score
    /// </summary>
    public double Average { get; set; }

    /// <summary>
    /// Players date of birth (players must be 18 or older)
    /// </summary>
    public DateOnly DateofBirth { get; set; }//DateOnly returns the day/month/year

    public bool IsCurrentMember { get; set; }

    /// <summary>
    /// Players phone number
    /// </summary>
    public string? Phone {  get; set; }

    public Gender BowlersGender{ get; set; }
    /// <summary>
    /// Players gender identity
    /// </summary>
    public enum Gender
    {
        Male, Female, Other
    }


    public int Game1 { get; set; }
    public int Game2 { get; set; }
    public int Game3 { get; set; }
    public int Game4 { get; set; }
    ///You could also do: public List<int> GameScores { get; set; }
    ///
    public int GetTotalScore//better to have this as a method rather than just a get/set
    {                       // as you would have to update the scores manually that way
        get
        {
            return Game1 + Game2 + Game3 + Game4;
        }
    }
}