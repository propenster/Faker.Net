using System;
using Faker.Net.Attributes;

namespace Faker.Net
{
    public class Class1
    {
        [Fake(Enums.FakerType.Name)]
        public string Name { get; set; }
        [Fake(Enums.FakerType.City)]
        public string City { get; set; }
        [Fake(Enums.FakerType.Phone)]
        public string Phone { get; set; }
    }
}

