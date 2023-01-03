using Evidence;
Text text = new Text();

char ukon = '0';

while (ukon != '4')
{
    text.TextUvodni();
    text.VypisMozneUkony();
    ukon = Console.ReadKey().KeyChar;
    Console.WriteLine();
    
    switch (ukon)
    {
        case '1':
            text.ZapisNovehoPojistence();
            break;
        case '2':
            text.VyhledejPojistence();
            break;
        case '3':
            text.VypisPojistene();
            break;
        case '4':
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }

}


