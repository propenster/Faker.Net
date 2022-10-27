using System.Reflection;
using Faker.Net.Attributes;
using Faker.Net.Enums;

namespace Faker.Net.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void FakerFactory_SetupMethod_Returns_Right_CountOf_ICollections()
    {
        TestModel ts = new TestModel();
        var fakerFactory = new FakerFactory();
        var fakeResult = fakerFactory.Setup<TestModel>(ts.GetType(), 5);
        //TestDelegate setupAction = () => fakerFactory.Setup<TestModel>(typeof(ts), 5);
        Assert.AreEqual(fakeResult.Count, 5);
    }
    [Test]
    public void FakerFactory_SetupMethod_Throws_ArgumentNullException_If_TypeParam_Null()
    {
        //TestModel ts = null;
        var fakerFactory = new FakerFactory();
        TestDelegate setupAction = () => fakerFactory.Setup<TestModel>(null, 5);
        Assert.Throws<ArgumentNullException>(setupAction);
    }

    [Test]
    public void FakerFactory_SetupMethod_Returns_Not_Null()
    {
        TestModel ts = new TestModel();
        var fakerFactory = new FakerFactory();
        var fakeSetup = fakerFactory.Setup<TestModel>(ts.GetType(), 5);

        Assert.NotNull(fakeSetup);
    }


    [Test]
    public void FakerFactory_SetupMethod_Returns_The_Right_Type_ICollection_Of_TEntity()
    {
        TestModel ts = new TestModel();
        var fakerFactory = new FakerFactory();
        var fakeSetup = fakerFactory.Setup<TestModel>(ts.GetType(), 5); //as ICollection<TestModel>; 

        Assert.That(fakeSetup, Is.AssignableTo<ICollection<TestModel>>());

    }

    [Test]
    [Fake(fakerType: FakerType.Name)]
    public void FakerFactory_SetupMethod_Faker_Attribute_Property_Values_Are_Correct()
    {
        TestModel ts = new TestModel();
        var fakerFactory = new FakerFactory();
        var fakeSetup = fakerFactory.Setup<TestModel>(ts.GetType(), 5); //as ICollection<TestModel>;


        Assert.That(MethodBase.GetCurrentMethod(),
Has.Attribute<FakeAttribute>().Property("type").TypeOf<FakerType>() &
        Has.Attribute<FakeAttribute>().Property("type").EqualTo(FakerType.Name));
        
    }

    [Test]
    public void FakerFactory_ModelClass_Property_City_Is_Decorated_With_FakeAttribute()
    {
        TestModel ts = new TestModel();

        //Attribute.IsDefined(property, typeof(FakeAttribute))


        Assert.IsTrue(Attribute.IsDefined(
            ts.GetType().GetProperties().FirstOrDefault(x => x.Name == nameof(ts.City)),
            typeof(FakeAttribute)));
        
    }
    [Test]
    public void FakerFactory_ModelClass_Property_Name_Is_Decorated_With_FakeAttribute()
    {
        TestModel ts = new TestModel();

        //Attribute.IsDefined(property, typeof(FakeAttribute))

        Assert.IsTrue(Attribute.IsDefined(
            ts.GetType().GetProperties().FirstOrDefault(x => x.Name == nameof(ts.Name)),
            typeof(FakeAttribute)));

    }
    [Test]
    public void FakerFactory_ModelClass_Property_HouseAddress_Is_Not_Decorated_With_FakeAttribute()
    {
        TestModel ts = new TestModel();

        //Attribute.IsDefined(property, typeof(FakeAttribute))

        Assert.IsFalse(Attribute.IsDefined(
            ts.GetType().GetProperties().FirstOrDefault(x => x.Name == nameof(ts.HouseAddress)),
            typeof(FakeAttribute)));
    }

    [Test]
    public void FakerFactory_Setup_Method_Does_Not_Populate_HouseAddress_Field()
    {
        TestModel ts = new TestModel();
        var fakerFactory = new FakerFactory();
        var fakeSetup = fakerFactory.Setup<TestModel>(ts.GetType(), 2); //as ICollection<TestModel>;

        var result = fakeSetup.First();
        var lastResult = fakeSetup.Last();
        Assert.IsEmpty(result.HouseAddress);

        Assert.IsEmpty(lastResult.HouseAddress);
    }

    [Test]
    public void FakerFactory_Setup_Method_Populates_FakeAttribute_Decorated_Fields()
    {
        TestModel ts = new TestModel();
        var fakerFactory = new FakerFactory();
        var fakeSetup = fakerFactory.Setup<TestModel>(ts.GetType(), 2); //as ICollection<TestModel>;

        var result = fakeSetup.First();
        var lastResult = fakeSetup.Last();
        Assert.IsNotEmpty(result.Name);
        Assert.IsNotEmpty(result.City);
        Assert.IsNotEmpty(result.Phone);
        Assert.IsEmpty(result.HouseAddress);

        Assert.IsNotEmpty(lastResult.Name);
        Assert.IsNotEmpty(lastResult.City);
        Assert.IsNotEmpty(lastResult.Phone);
        Assert.IsEmpty(lastResult.HouseAddress);
    }

}
