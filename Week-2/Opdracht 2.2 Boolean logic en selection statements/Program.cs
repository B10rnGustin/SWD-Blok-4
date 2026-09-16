bool hasDriverLicence = true;
bool hasCar = true;

int age = 26;
int minimumAge = 18;

bool isAdult = (age >= minimumAge);

bool canDriveOwnCar = isAdult && hasDriverLicence && hasCar;
bool mayHaveOwnCar = hasDriverLicence || hasCar;

if (canDriveOwnCar)
{
    Console.WriteLine("Deze persoon mag zelfstandig in een auto rijden.");
}
else
{
    Console.WriteLine("Deze persoon mag niet zelfstandig in een auto rijden.");
}

if (mayHaveOwnCar)
{
    Console.WriteLine("Deze persoon mag een eigen auto bezitten.");
}
else
{
    Console.WriteLine("Deze persoon heeft waarschijnlijk geen auto.");
}

bool cannotDriveOwnCar = !canDriveOwnCar;
Console.WriteLine(cannotDriveOwnCar);

if (!hasCar)
{
    Console.WriteLine("Deze persoon heeft geen eigen auto.");
}
else
{
    Console.WriteLine("Deze persoon heeft wel een eigen auto.");
}

if (canDriveOwnCar)
{
    Console.WriteLine("Deze persoon mag zelfstandig rijden in zijn eigen auto.");
}
else if (hasDriverLicence && !hasCar)
{
    Console.WriteLine("Deze persoon heeft een rijbewijs, maar geen eigen auto.");
}
else if (!hasDriverLicence && hasCar)
{
    Console.WriteLine("Deze persoon heeft een auto, maar mag er niet in rijden.");
}
else
{
    Console.WriteLine("Deze persoon heeft geen rijbewijs en geen auto.");
}