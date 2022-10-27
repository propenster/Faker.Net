using System;
using Faker.Net.Attributes;
using Faker.Net.Enums;

namespace Faker.Net.Tests
{
    public class TestModel
    {
        [Fake(FakerType.Name)]
        public string Name { get; set; }
        [Fake(FakerType.City)]
        public string City { get; set; }
        [Fake(FakerType.Phone)]
        public string Phone { get; set; }
        public string HouseAddress { get; set; } = string.Empty;
    }
}

