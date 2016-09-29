---
title: "valarray::min"
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
  - "valarray/std::valarray::min"
  - "valarray.min"
  - "min"
  - "valarray::min"
  - "std.valarray.min"
  - "std::valarray::min"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "min method"
  - "min function"
ms.assetid: 7b634a4b-1257-4383-8cc2-3c2138f61f88
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::min
Finds the smallest element in a valarray.  
  
## Syntax  
  
```  
  
Type min( ) const;  
  
```  
  
## Return Value  
 The minimum value of the elements in the operand valarray.  
  
## Remarks  
 The member function compares values by applying **operator<** or **operator>** between pairs of elements of class **Type**, for which operators must be provided for the element **Type**.  
  
## Example  
  
```  
// valarray_min.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i, MinValue;  
  
   valarray<int> vaR ( 10 );  
   for ( i = 0 ; i < 10 ; i += 3 )  
      vaR [ i ] =  -i;  
   for ( i = 1 ; i < 10 ; i += 3 )  
      vaR [ i ] =  2*i;  
   for ( i = 2 ; i < 10 ; i += 3 )  
      vaR [ i ] =  5 - i;  
  
   cout << "The operand valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   MinValue = vaR.min ( );  
   cout << "The smallest element in the valarray is: "  
        << MinValue  << "." << endl;  
}  
```  
  
 **The operand valarray is: ( 0 2 3 -3 8 0 -6 14 -3 -9 ).**  
**The smallest element in the valarray is: -9.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)