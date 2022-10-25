using System;
using Faker.Net.Enums;

namespace Faker.Net.Attributes
{
    public class FakeAttribute : Attribute
    {
        public FakerType type { get; set; }
        public FakeAttribute(FakerType fakerType)
        {
            type = fakerType;
        }
    }
}

