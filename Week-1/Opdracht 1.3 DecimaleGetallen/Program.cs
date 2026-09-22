/*float myFloat = 0.1f;
double myDouble = 0.1;
decimal myDecimal = 0.1m;


Console.WriteLine($"Float:   {myFloat,10}");
Console.WriteLine($"Double:  {myDouble,10}");
Console.WriteLine($"Decimal: {myDecimal,10}");*/


/*double myDouble = 0;
decimal myDecimal = 0;

for (int i = 0; i < 10; i++)
{
    myDouble += 0.1;
    myDecimal += 0.1m;
}

Console.WriteLine($"Double:  {myDouble,20}");
Console.WriteLine($"Decimal: {myDecimal,20}");

Console.ReadKey();*/

/*Console.WriteLine("Bytes float: " + sizeof(float));
Console.WriteLine("Bytes double: " + sizeof(double));
Console.WriteLine("Bytes decimal: " + sizeof(decimal));

Dit komt doordat decimal een hoge precisie heeft voor decimale getallen en een groot bereik heeft.
Console.ReadKey();*/

/*float myFloatValue = 5.5f;
double myDoubleValue = myFloatValue;

Console.WriteLine(myFloatValue);
Console.WriteLine(myDoubleValue);

double myBigDouble = 9.99;
float mySmallFloat = (float)myBigDouble;

Console.WriteLine(myBigDouble);
Console.WriteLine(mySmallFloat);

Console.ReadKey();

Bij float naar double hoef je niet te casten, omdat double meer precisie heeft dan float. 
Bij double naar float moet je wel casten, omdat float minder precisie heeft en er daardoor informatie verloren kan gaan.*/

/*decimal priceDecimal = 19.999m;
Console.WriteLine("Before: " + priceDecimal);
decimal roundedDecimal = Math.Round(priceDecimal, 2);
Console.WriteLine("Rounded price: " +  roundedDecimal);*/