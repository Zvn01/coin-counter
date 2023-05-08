double input_money;
double[] muenzen = new double[] { 5, 2, 1, 0.5, 0.2, 0.1, 0.05 };
double[] muenzCount = new double[muenzen.Length];

try
{
    Console.Write("Bitte wählen Sie einen Geldbetrag aus, der in Münzgeld gewechselt werden kann: ");
    input_money = Convert.ToDouble(Console.ReadLine());

    for (int i = 0; i < muenzen.Length; i++)
    {
        while (input_money >= muenzen[i])
        {
            input_money -= (double)muenzen[i];
            muenzCount[i]++;
        }
    }

    Console.WriteLine("Für den gewählten Geldbetrag benötigen Sie: ");
    for (int i = 0; i < muenzCount.Length; i++)
    {
        if (muenzCount[i] > 0)
        {
            Console.WriteLine(muenzCount[i] + " x " + muenzen[i] + " CHF");
        }      
    }
}
catch (FormatException error)
{
    Console.WriteLine(error.Message);
}