using FindDistinctValues;

Console.WriteLine("Enter values seperated by ',' and press enter: ");
input:  var stream = Console.ReadLine();

if (string.IsNullOrWhiteSpace(stream))
{
    Console.WriteLine();
    goto input;
}

string[] inputs = stream.Split(',');
var inputList = inputs.ToList();
Console.WriteLine(inputList.Count);
var results = Logic<string>.GetDistinct(inputList);
Console.WriteLine(results.Count);

foreach (var result in results)
{
    Console.WriteLine(result.Trim());
}

 
