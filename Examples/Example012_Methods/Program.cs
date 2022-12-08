// Type 1:


// void Method1()
//{
//     Console.WriteLine("Autor ...");
// }
// Method1();


// Type 2:


// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Tex massage..");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
    
// }
// Method21(count: 4, msg: "Tex massage..");


// Type 2:


int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


