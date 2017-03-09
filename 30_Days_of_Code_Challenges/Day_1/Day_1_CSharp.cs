 
        // Declare second integer, double, and String variables.
        int j = i;
        double e = d;
        string t = s;

        // Read and save an integer, double, and String to your variables.
        int k = Int32.Parse(Console.ReadLine());
        double f = Double.Parse(Console.ReadLine());
        string u = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(j + k);

        // Print the sum of the double variables on a new line.
        Console.WriteLine((e + f).ToString("F1"));
        
        // Concatenate and print the String variables on a new line
        Console.WriteLine(t + u);

        // The 's' variable above should be printed first.
        
