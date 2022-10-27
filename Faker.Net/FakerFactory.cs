using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Faker.Net.Attributes;
using Faker.Net.Engine;
using Faker.Net.Enums;

namespace Faker.Net
{
    public class FakerFactory : IFakerFactory
    {

        private object GetPropertyValueFromFakerType(FakerType fakerType)
        {

            switch (fakerType)
            {
                case FakerType.Address:
                    return Address.AddressString();
                case FakerType.Name:
                    return (object)Name.NameString();
                case FakerType.EmailAddress:
                    return (object)EmailAddress.EmailString();
                case FakerType.Sentence:
                    return (object)Sentence.SentenceString();
                case FakerType.TextParagraph:
                    return (object)TextParagraph.TextParagraphString();
                case FakerType.City:
                    return (object)City.CityString();
                case FakerType.ImageUrl:
                    return (object)ImageUrl.ImageUrlString();
                case FakerType.Country:
                    return (object)Country.CountryString();
                case FakerType.IpAddress:
                    return (object)IPAddress.IPAddressString();
                case FakerType.Phone:
                    return (object)Phone.PhoneString();
                case FakerType.Website:
                    return (object)Url.UrlString();
                case FakerType.Url:
                    return (object)Url.UrlString();
                case FakerType.Guid:
                    return (object)Guid.NewGuid();
                case FakerType.GuidString:
                    return (object)Guid.NewGuid().ToString();
                case FakerType.DateTime:
                    return (object)DateTime.UtcNow;
                case FakerType.Numeric:
                    return (object)new Random().Next(011111111, 999999999);
                case FakerType.ZipCode:
                    return (object)ZipCode.ZipCodeString();

                default:

                    throw new FormatException($"Invalid FakerType enum format {nameof(fakerType)}");

            }

            throw new FormatException($"Invalid FakerType enum format {nameof(fakerType)}");


        }

        public ICollection<TEntity> Setup<TEntity>(Type type, int size = 1)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));
            //if (type is null) throw new ArgumentNullException(nameof(type));

            ICollection<TEntity> list = new List<TEntity>();

            PropertyInfo[] properties = type.GetProperties();

            //list of model...
            var setupList = new List<TEntity>();
            //var entity = new TEntity();

            var countYet = 0;
            for(countYet = 0; countYet <size; countYet++)
            {
                TEntity ent = Activator.CreateInstance<TEntity>();
                PropertyInfo[] pis = ent.GetType().GetProperties();

                foreach (PropertyInfo property in pis)
                {
                    //only do this for ONLY props decorated with FakerAttribute
                    if (!Attribute.IsDefined(property, typeof(FakeAttribute))) continue;

                    var pInfo = typeof(TEntity).GetProperty(property.Name)
                                 .GetCustomAttribute<FakeAttribute>();

                    var fakerType = pInfo.type;

                    var value = GetPropertyValueFromFakerType(fakerType);

                    property.SetValue(ent, value, null);
                }

                list.Add(ent);

            }

            return list;


            


        }
    }
}

