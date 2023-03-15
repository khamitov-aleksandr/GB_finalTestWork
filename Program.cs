// Programm that take from the existing array of strings forms an array of strings
// whose length is less or equal to 3 characters.
Console.Clear();

string[] array = FillArray();
string[] result = FindLessThanThree(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThanThree(string[] input, int n) {
    string[] output = new string[CountLessThanThree(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThanThree(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }
    return count;
}

string[] FillArray() {
    Console.Write("Enter values separated by spaces: ");
    return (Console.ReadLine()!).Split(" ");
}
