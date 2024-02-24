using Data.Mockup.Library;
using Data.Mockup.Library.Models;
using Common.Extensions.Library;
using System.Globalization;

try
{
    var dataGenerator = new DataGenerator();
    var people = dataGenerator.GetPeople(10, CultureInfo.CreateSpecificCulture("en-US"));
    var numbers = Enumerable.Range(1, 10).ToList();

    numbers.ToJson().SaveToDisk("numbers.txt");
    people.ToJson().SaveToDisk("people_json.txt");
    var numbersFromSavedFile = (List<int>)"numbers.txt".LoadFromFile().FromJson<List<int>>();
    var peopleFromSavedFile = (List<PersonDto>)"people_json.txt".LoadFromFile().FromJson<List<PersonDto>>();

    foreach (var num in numbersFromSavedFile)
    {
        Console.WriteLine(num);
    }

    foreach (var person in peopleFromSavedFile)
    {
        Console.WriteLine(person.FirstName);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
