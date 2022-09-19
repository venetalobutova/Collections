namespace Collections.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]

    public void Test_Collection_EmptyConstructor()

    {
        //Arrange

        var nums = new Collection<int>();

        //Act

        Assert.That(nums.Count == 0, "Count property");
        //Assert.That(nums.Capacity == 0, "Capacity property");
        Assert.That(nums.Capacity, Is.EqualTo(16));
        Assert.That(nums.ToString() == "[]");

        //Assert


    }

    [Test]

    public void Test_Collection_SingleItem()

    {
        //Arrange

        var nums = new Collection<int>(5);

        //Act

        Assert.That(nums.Count == 1, "Count property");
        Assert.That(nums.Capacity, Is.EqualTo(16));
        Assert.That(nums.ToString() == "[5]");

        //Assert
    }

    [Test]

    public void Test_Collection_MultipleItems()

    {
        //Arrange

        var nums = new Collection<int>(5, 6);

        //Act

        Assert.That(nums.Count == 2, "Count property");
        Assert.That(nums.Capacity, Is.EqualTo(16));
        Assert.That(nums.ToString() == "[5, 6]");

        //Assert
    }

    [Test]

    public void Test_Collection_Add()

    {
        //Arrange

        var nums = new Collection<int>();

        //Act

        nums.Add(7);

        //Assert

        Assert.That(nums.Count == 1, "Count property");
        Assert.That(nums.Capacity, Is.EqualTo(16));
        Assert.That(nums.ToString() == "[7]");
    }

    [Test]

    public void Test_Collection_AddRange()

    {
        //Arrange

        var items = new int[] {6, 7, 8};
        var nums = new Collection<int>();

        //Act

        nums.AddRange(items);

        //Assert

        Assert.That(nums.Count == 3, "Count property");
        Assert.That(nums.Capacity, Is.EqualTo(16));
        Assert.That(nums.ToString() == "[6, 7, 8]");
    }
}