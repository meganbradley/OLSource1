---
title: "valarray::sum"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "valarray/std::valarray::sum"
  - "valarray::sum"
  - "std::valarray::sum"
  - "std.valarray.sum"
  - "sum"
  - "valarray.sum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sum method"
  - "sum function"
ms.assetid: da32baf6-cee5-48c3-977a-7fdce195ba66
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::sum
Determines the sum of all the elements in a valarray of nonzero length.  
  
## Syntax  
  
```  
  
Type sum( ) const;  
  
```  
  
## Return Value  
 The sum of the elements of the operand valarray.  
  
## Remarks  
 If the length is greater than one, the member function adds values to the sum by applying `operator+=` between pairs of elements of class **Type**, which operator, consequently, needs be provided for elements of type **Type**.  
  
## Example  
  
```  
// valarray_sum.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
   int sumva = 0;  
  
   valarray<int> va ( 10 );  
   for ( i = 0 ; i < 10 ; i+=1 )  
      va [ i ] =  i;  
  
   cout << "The operand valarray va (10) is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   sumva = va.sum ( );  
   cout << "The sum of elements in the valarray is: "  
        << sumva  << "." <<endl;  
}  
```  
  
 **The operand valarray va (10) is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The sum of elements in the valarray is: 45.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)