using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        long tmp=0;
        long prodotto=1;
        char[] array=digits.ToCharArray();

        if (span>array.Length || span<0){
            throw new ArgumentException();
        }

        if(span==0){
            return 1;
        }
        
        for(int i=0; i<array.Length;i++){
            if(!char.IsDigit(array[i])){
               throw new ArgumentException();
            }
        }

        for(int i=0; i<=array.Length-span;i++){
            prodotto=1;
            for(int j=i; j<i+span; j++){
                prodotto=prodotto * Convert.ToInt64(Char.GetNumericValue(array[j]));
            }
            if(prodotto>tmp)
            {
                tmp=prodotto;
            }
        }
        return tmp;  
    }
}