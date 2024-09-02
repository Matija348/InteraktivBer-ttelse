
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