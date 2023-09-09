int wheightObjectOne, wheightObjectTwo, speedObjectOne, speedObjectTwo;

   
            Console.Write("Diga a velocidade do objeto 1 (m/s): ");
                speedObjectOne = int.Parse(Console.ReadLine());                             
              
            Console.WriteLine("Diga o peso do objeto 1");

                wheightObjectOne = int.Parse(Console.ReadLine());

            Console.Write("Diga a velocidade do objeto 2: ");

                speedObjectTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("diga o peso do objeto 2");

                wheightObjectTwo = int.Parse(Console.ReadLine());



                int fator1 = wheightObjectOne * speedObjectOne; 
                int fator2 = wheightObjectTwo * speedObjectTwo;
                int sfator = fator1 + fator2;
                int svs = wheightObjectOne + wheightObjectTwo;
                int resultado = sfator / svs;

        if (wheightObjectOne > wheightObjectTwo)  
        Console.WriteLine("O objeto 2 se choca com o objeto 1 e se move em direção contrária a: " + resultado + "m/s");

        else if (wheightObjectTwo > wheightObjectOne) 
        Console.WriteLine("O objeto 2 bate no objeto 1 e os dois objetos se movem na mesma direção a: " + resultado + "m/s");
        
        else if (wheightObjectTwo == wheightObjectOne)
        Console.WriteLine("Os dois objetos se chocam e se movem em direções contrárias a " + resultado + "m/s");
