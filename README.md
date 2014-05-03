INUnit
======

Inline .Net Unit testing.


Example:

``` csharp
using InlineUnit;

[Assert.AreEqual(arguments: new object[] { 5 }, expected: 6)]
public int AddOne(int number)
{
    return number + 1;
}
```