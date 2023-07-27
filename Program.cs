void randomNumber()
{
    int randomNumber = new Random().Next(1, 100);
    Console.WriteLine(randomNumber);
    int inputNumberUser = 0;
    do
    {
        inputNumberUser = int.Parse(Console.ReadLine()!);
        if (inputNumberUser > randomNumber)
        {
            Console.WriteLine("Número digitado é maior");
        }

        if (inputNumberUser < randomNumber)
        {
            Console.WriteLine("Número digitado é menor!");
        }

        if (inputNumberUser == randomNumber)
        {
            Console.WriteLine("Parabéns!! Número é igual ao gerado randomicamente!");
        }
    } while (inputNumberUser != randomNumber);
}
randomNumber();

void createList()
{
    List<String> listOfString = new List<String>();
    listOfString.Add("Murillo is a happy man");
    listOfString.Add("Murillo is a software developer");
    Dictionary<String, List<int>> subMurillo = new Dictionary<String, List<int>>();
    foreach (var s in listOfString)
    {
        Console.WriteLine(s);
        subMurillo.Add(s, new List<int>(new Random().Next()));
        foreach (var dicMurillo in subMurillo)
        {
            Console.WriteLine(dicMurillo.Value);
        }
    }

}

createList();