using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        //int max=0;
        //int[] valori = new int[digits.Length];
        //int prodotto = 1;
        //if( span==0 )
        //return 1;

        //for (int i = 0; i < digits.Length-1; i++){
        //for (int j = i+1; j < digits.Length; j++)
        //{
        //if (digits[i] > digits[j])
        //{
        //max = Convert.ToInt32(digits[i]);
        //}
        //}
        //}

        //for (int i = 0; i < digits.Length; i++){
        //if(max!=0){
        //for (int j = 0; j < digits.Length; j++)
        //{
        //if (max > digits[i + 1])
        //{
        //for (int k = 0; k > span; k++)
        //{
        //moltiplica[k] = valori[k];
        //}
        //}
        //else
        //{
        //for (int k = 0; k < -span; k++)
        //{
        //moltiplica[k] = valori[k];
        //}
        //}
        //}
        //}
        //for (i = 0; i < moltiplica.Length; i++){
        //prodotto *= moltiplica[i];
        //}
        //}
        //return prodotto;
        int[] valori = new int[digits.Length];
        int[] array = new int[digits.Length];

        for (int i = 0; i < digits.Length; i++){
            array[i] = Convert.ToInt32(digits[i]);
        }
            int prodotto = 0;

        if( span==0 )
            return 1;

        for (int i = 0; i < array.Length; i++){
            if (array[i] > array[i + 1])
            {
                valori[i] = Convert.ToInt32(array[i]);
                for (int j = 0; j < span; j++)
                {
                    if (array[i - (j+1)] > array[i + (j+1)]){
                        valori[i + (j + 1)] = Convert.ToInt32(array[i - (j + 1)]);
                    }
                    else{
                        valori[i + (j + 1)] = Convert.ToInt32(array[i - (j + 1)]);
                    }
                }
            }
        }
        for (int i = 0; i < valori.Length; i++){
            if(valori[i]!=0){
                prodotto *= valori[i];
            }
            else
            {
                return 0;
            }
        }
            return prodotto;
    }
}