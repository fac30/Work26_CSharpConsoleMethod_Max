string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

RSVP(name: "Rebecca", partySize: 1, allergies: "none", inviteOnly: true);
RSVP(name: "Nadia", partySize: 2, allergies: "Nuts", inviteOnly: true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP(name: "Tony", partySize: 1, allergies: "Jackfruit", inviteOnly: true);
RSVP(name: "Noor", partySize: 4, allergies: "none", inviteOnly: false);
RSVP(name: "Jonte", partySize: 2, allergies: "Stone fruit", inviteOnly: false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}