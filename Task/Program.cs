int size = 0;

while(size <= 0) {
    Console.Write("How many lines do you want to input? ");
    size = Convert.ToInt32(Console.ReadLine());
}

string[] array = new string[size];
string[] newArray = {};
int counter = 0;

for (int i = 0; i < array.Length; i += 1) {
    Console.Write($"Input {i + 1} line: ");
    array[i] = Convert.ToString(Console.ReadLine());

    if (array[i].Length <= 3) {
        Array.Resize(ref newArray, counter + 1);
        newArray[counter] = array[i];
        counter += 1;
    }
}

Console.WriteLine("Starting Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("New array: ");
Console.WriteLine($"[{string.Join(", ", newArray)}]");