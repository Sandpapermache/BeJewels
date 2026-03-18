using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class Gem
{
    private string gemShape;

    public string[] shapes = {"square", "triangle", "diamond","circle","octagon"};

    private static Random rnd = new Random();



    public Gem()
    {
        gemShape = "";
    }

    public Gem(string shape)
    {
        gemShape = shape;
    }

   public void generateGem()
    {
        int myNumber = rnd.Next(1, 101);
        string Gemshapeholder;
        
                

                if(myNumber > 92)
                {
                    Gemshapeholder = shapes[4];
                }

                else if(myNumber > 80)
                {
                    Gemshapeholder = shapes[3];
                }

                else if(myNumber > 60)
                {
                    Gemshapeholder = shapes[2];
                }

                else if(myNumber > 35)
                {
                    Gemshapeholder = shapes[1];
                }

                else
                {
                    Gemshapeholder = shapes[0];
                }

            
            this.gemShape = Gemshapeholder;

            
    }

    public string returnShape()
    {
        return gemShape;
    }

};




