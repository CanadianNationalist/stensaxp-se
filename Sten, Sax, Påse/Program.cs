bool loop = true;
int xpoäng= 0;
int ypoäng = 0;
Console.WriteLine("Sten-sax-påse startar...");
while(loop)
{
    Console.WriteLine("Sten, sax eller påse? 1: sten 2: påse 3:sax");
    int xval = Convert.ToInt32(Console.ReadLine());
    Random slumpval = new Random();
    int yval = slumpval.Next(1,4);
    switch (yval)
    {
        case 1:
        if(xval == 1)
        {
            Console.WriteLine("Du valde sten, datorn valde sten");
            Console.WriteLine("Det blev lika");
        }
        else if(xval == 1)
        {
            Console.WriteLine("Du valde papper, datorn valde sten");
            Console.WriteLine("Du vann"); 
            ypoäng ++;
        }
        else if(xval == 1)
        {
            Console.WriteLine("Du valde sax, datorn valde sten");
            Console.WriteLine("Datorn vann"); 
            xpoäng ++;
        }
        break;

        case 2:
        if(xval == 2)
        {
            Console.WriteLine("Du valde sax, datorn valde sax");
            Console.WriteLine("Det blev lika");
        }
        else if(xval == 2)
        {
            Console.WriteLine("Du valde sten, datorn valde sax");
            Console.WriteLine("Du vann"); 
            ypoäng++;
        }
        else if(xval == 2)
        {
            Console.WriteLine("Du valde papper, datorn valde sax");
            Console.WriteLine("Datorn vann"); 
            xpoäng++;
        }
        break;

        case 3:
        if(xval == 3)
        {
            Console.WriteLine("Du valde påse, datorn valde påse");
            Console.WriteLine("Det blev lika");
        }
        else if(xval == 3)
        {
            Console.WriteLine("Du valde sax, datorn valde påse");
            Console.WriteLine("Du vann"); 
            xpoäng++;
        }
        else if(xval == 3)
        {
            Console.WriteLine("Du valde sten, datorn valde påse");
            Console.WriteLine("Datorn vann"); 
            ypoäng++;
        }
        break;

    }

}
