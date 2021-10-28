using System;

public class PersonInfo
{
    public PersonInfo()
    {
    }
    public string Surname { get; set; }
    public string Name { get; set; }
    /*public string Middlename
    {
        get
        {
            if (Middlename.Equals(null))
            {
                return "default";
            }
            else
            {
                return Middlename;
            }
        }
        set
        {

        }
    }*/
    public string Middlename { get; set; }
    public string Street { get; set; }
    public string Phone { get; set; }
    public int[] IdArr { get; set; }

    public string[] ValueArr(string Surname, string Name, string Middlename, string Street, string Phone)
    {
        string[] arr = { $"{Surname}", $"{Name}", $"{Middlename}", $"{Street}", $"{Phone}" };
        return arr;
    }
}
