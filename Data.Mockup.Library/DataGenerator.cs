using Bogus;
using Bogus.Extensions;
using Data.Mockup.Library.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mockup.Library
{
    public class DataGenerator
    {
        public IEnumerable<PersonDto> GetPeople(int count, CultureInfo cultureInfo = null)
        {
            if (count <= 0) return Enumerable.Empty<PersonDto>();
            cultureInfo ??= new CultureInfo("en-US");

            var addressGenerator = new Faker<AddressDto>(cultureInfo.ToBogusLocale())
                .RuleFor(a => a.Id, _ => Guid.NewGuid())
                .RuleFor(a => a.City, f => f.Address.City())
                .RuleFor(a => a.Country, f => f.Address.Country())
                .RuleFor(a => a.PostalCode, f => f.Address.ZipCode())
                .RuleFor(a => a.Street, f => f.Address.StreetName());

            var personGenerator = new Faker<PersonDto>(cultureInfo.ToBogusLocale())
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                .RuleFor(p => p.LastName, f => f.Person.LastName)
                .RuleFor(p => p.Email, f => f.Person.Email)
                .RuleFor(p => p.PhoneNumber, f => f.Person.Phone)
                .RuleFor(p => p.Address, f => addressGenerator.Generate());

            return personGenerator.Generate(count);
        }
    }
}
