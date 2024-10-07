// See https://aka.ms/new-console-template for more information

{
double radie=2.4;
	Console.WriteLine("Cirkelns omkrets: "+CirkelOmkrets(radie));
	Console.WriteLine("Cirkelns area: "+CirkelArea(radie));
}

double CirkelOmkrets(double r)
{
    double o = r * 2 * Math.PI;
    return o; 
}

double CirkelArea(double r)
{
    double a = r * r * Math.PI; 
    return a;
}
