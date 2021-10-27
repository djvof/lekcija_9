
namespace Classwork
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

}
