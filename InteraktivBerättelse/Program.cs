{
    
    {
        // Introduktion
        Console.WriteLine("Du befinner dig i en mystisk skog och stöter på en korsning.");
        Console.WriteLine("Vill du gå till vänster eller höger? (vänster/höger)");

        // Användarens första beslut
        string val1 = Console.ReadLine().ToLower();

        // Kollar användarens första val
        if (val1 == "vänster")
        {
            // Användaren valde att gå till vänster
            Console.WriteLine("Du går till vänster och stöter på en drake! Vill du springa eller kämpa? (springa/kämpa)");
            string val2 = Console.ReadLine().ToLower();

            // Kollar användarens andra val efter att ha gått vänster
            if (val2 == "springa")
            {
                // Användaren valde att springa
                Console.WriteLine("Du springer för ditt liv och lyckas komma undan, men du hittar aldrig skatten.");
                Console.WriteLine("SLUT: Du överlevde, men missade skatten.");
            }
            else if (val2 == "kämpa")
            {
                // Användaren valde att kämpa
                Console.WriteLine("Du kämpar modigt mot draken och besegrar den! Bakom draken hittar du en skatt.");
                Console.WriteLine("SLUT: Du besegrade draken och blev rik.");
            }
            else
            {
                // Hantering av ogiltigt val
                Console.WriteLine("Ogiltigt val. Spelet avslutas.");
            }
        }      
        else if (val1 == "höger")
        {
            // Användaren valde att gå till höger
            Console.WriteLine("Du går till höger och möter en mystisk trollkarl. Vill du lyssna eller ignorera honom? (lyssna/ignorera)");
            string val2 = Console.ReadLine().ToLower();

            // Kollar användarens andra val efter att ha gått höger
            if (val2 == "lyssna")
            {
                // Användaren valde att lyssna
                Console.WriteLine("Trollkarlen ger dig en gåva som gör dig till kung över hela riket!");
                Console.WriteLine("SLUT: Du blev kung och levde lycklig i alla dina dagar.");
            }
            else if (val2 == "ignorera")
            {
                // Användaren valde att ignorera
                Console.WriteLine("Du ignorerar trollkarlen och går vidare, men går vilse i skogen.");
                Console.WriteLine("SLUT: Du hittar aldrig vägen ut och går vilse för alltid.");
            }
            else
            {
                // Hantering av ogiltigt val
                Console.WriteLine("Ogiltigt val. Spelet avslutas.");
            }
        }
        else
        {
            // Hantering av ogiltigt val vid första beslutet
            Console.WriteLine("Ogiltigt val. Spelet avslutas.");
        }
    }
}   

Console.ReadLine();