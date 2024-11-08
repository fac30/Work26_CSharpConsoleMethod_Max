string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string corporateDomain = "contoso.com";
string externalDomain = "hayworth.com";

displayEmails(corporate, corporateDomain);
displayEmails(external, externalDomain);

void displayEmails(string[,] names, string domain)
{
    for (int i = 0; i < names.GetLength(0); i++)
    {
        string firstName = names[i, 0].Substring(0, 2).ToLower();
        string lastName = names[i, 1].ToLower();
        Console.WriteLine(firstName + lastName + domain);
    }
}