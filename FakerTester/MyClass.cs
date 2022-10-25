using System;
using Faker.Net.Attributes;
using Faker.Net.Enums;

namespace FakerTester
{
    public class MyClass
    {
        [Fake(FakerType.Name)]
        public string Name { get; set; }
        [Fake(FakerType.City)]
        public string City { get; set; }
        [Fake(FakerType.Phone)]
        public string Phone { get; set; }
    }
}

