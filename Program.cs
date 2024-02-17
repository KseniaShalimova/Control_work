string[] StartArray = { "Hello", "2", ":-)" };
int u = CalculateNumberOfElementsResultArray(StartArray);
string[] ResultArray = CreateResultArray(StartArray, u);
OutputArray(ResultArray, u);

int CalculateNumberOfElementsResultArray(string[] StartArray)
{
    int u = 0;
    foreach (string e in StartArray)
    {
        if (e.Length <= 3)
        {
            u += 1;
        }
    }
    return u;
}

string[] CreateResultArray(string[] StartArray, int u)
{
    string[] ResultArray = new string[u];
    int i = 0;
    foreach (string e in StartArray)
    {
        if (e.Length <= 3)
        {
            ResultArray[i] = e;
            i += 1;
        }
    }
    return ResultArray;
}

void OutputArray(string[] ResultArray, int u)
{
    Console.Write("[");
    foreach (string e in ResultArray)
    {
        if (e != ResultArray[u - 1])
        {
            Console.Write($"{e}, ");
        }
        else
        {
            Console.Write(e);
        }
    }
    Console.Write("]");
}