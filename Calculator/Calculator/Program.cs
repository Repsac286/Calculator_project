using Calculator;

metoder m = new metoder();

string input = Console.ReadLine();
int.TryParse(input, out int input_a);
Console.WriteLine("+");
input = Console.ReadLine();
int.TryParse(input, out int input_b);
Console.WriteLine(m.add(input_a, input_b));