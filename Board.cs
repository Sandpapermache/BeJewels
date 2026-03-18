using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class GemBoard
{

    private Gem[][] Board = new Gem[8][];
   


  public  GemBoard()  // Fills board start of game
    {
       for (int i = 0; i < 8; i++)
        {
            Board[i] = new Gem[8];
            for (int j = 0; j < 8; j++)
            {
                Board[i][j] = new Gem();
                Board[i][j].generateGem();
            }
        }
    }



  public  bool ifEmpty(int row,int col)
    {
        Gem gems = Board[row][col];
        
        if(gems.returnShape() == "" || gems.returnShape() == null)
        {
            return true;
        }

        return false;
    }


   public void removeGem(int row,int col) 
    {
        Gem noGem = new Gem("");
        Board[row][col] = noGem;

    }



  public  void addGem(int row,int col)  //Add gem when empty
    {
        Gem newGem = new Gem();
        newGem.generateGem();

        Board[row][col] = newGem;
    }



   public void dropGem()
    {
        
        Gem[] placeholder = new Gem[8];
        int col = 0;

        while(col < 8)
        {
            int numEmpty = 0;
            int count = 0;

            for(int row = 0; row < 8; row++)   //Sees which gems are still present
            {
                if (ifEmpty(row,col))
                {

                    numEmpty++;
                }

                else
                {
                    placeholder[count] = Board[row][col];
                    count++;
                    removeGem(row,col);
                }
            }


        if (numEmpty > 0) 
{
   
    int targetRow = 7; 

    
    for (int i = 0; i < count; i++) 
    {
        Board[targetRow][col] = placeholder[i];
        targetRow--; 
    }

    
    while (targetRow >= 0) 
    {
        addGem(targetRow, col);
        targetRow--;
    }
}
            
            col++;

        }
        
    }


    public Gem GetGem(int row, int col)
{
    return Board[row][col];
}





    

};