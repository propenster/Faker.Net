using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Faker.Net.Attributes;
using Faker.Net.Enums;

namespace Faker.Net
{
    public class FakerFactory : IFakerFactory
    {

        private object GetPropertyValueFromFakerType(FakerType fakerType)
        {


            switch (fakerType)
            {
                case FakerType.Name:
                    return (object)"John Smith";
                case FakerType.Sentence:

                    return (object)"Lorem ipsum dolor consecatum";
                case FakerType.Text:
                    return (object)"Lorem ipsum dolor consecatumLorem ipsum dolor consecatumLorem ipsum dolor consecatumLorem ipsum dolor consecatumLorem ipsum dolor consecatumLorem ipsum dolor consecatumLorem ipsum dolor consecatumLorem ipsum dolor consecatum";
                case FakerType.City:
                    return (object)"Tokyo";
                case FakerType.ImageUrl:
                    return (object)"https://sw.amazon.com/23232iewu31u2i23i32.png";
                case FakerType.Country:
                    return (object)"Nigeria";
                case FakerType.IpAddress:
                    return (object)"100.100.100.101";
                case FakerType.Phone:
                    return (object)"+8102020020202";
                case FakerType.Website:
                    return (object)"https://www.github.com";

                case FakerType.Guid:
                    return (object)Guid.NewGuid();
                case FakerType.GuidString:
                    return (object)Guid.NewGuid().ToString();
                case FakerType.DateTime:
                    return (object)DateTime.UtcNow;
                case FakerType.Numeric:
                    return (object)new Random().Next(100000);

                default:

                    break;





            }

            return null;


        }

        public ICollection<TEntity> Setup<TEntity>(Type type, int size = 1)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

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

