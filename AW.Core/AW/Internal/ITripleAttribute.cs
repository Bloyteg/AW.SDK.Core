
namespace AW
{
    internal interface ITripleAttribute<out T, TValue>
    {
        TValue FirstValue { get; }
        TValue SecondValue { get; }
        TValue ThirdValue { get; }

        T FromValues(TValue first, TValue second, TValue third);
    }
}
