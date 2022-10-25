using System;
using System.Collections.Generic;

namespace Faker.Net
{
    public interface IFakerFactory
    {
        ICollection<TEntity> Setup<TEntity>(Type type, int size = 1);
        //IEnumerable<TEntity> Setup<TEntity>(Type type, int size);

    }
}

