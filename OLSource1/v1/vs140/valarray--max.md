---
title: "valarray::max"
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
  - "std.valarray.max"
  - "valarray::max"
  - "std::valarray::max"
  - "max"
  - "valarray.max"
  - "valarray/std::valarray::max"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max function"
  - "max method"
ms.assetid: 1be6ba74-99dc-4b91-80e3-aae663de2002
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::max
Finds the largest element in a valarray.  
  
## Syntax  
  
```  
  
Type max( ) const;  
  
```  
  
## Return Value  
 The maximum value of the elements in the operand valarray.  
  
## Remarks  
 The member function compares values by applying **operator<** or **operator>** between pairs of elements of class **Type**, for which operators must be provided for the element **Type**.  
  
## Example  
  
```  
// valarray_max.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i, MaxValue;  
  
   valarray<int> vaR ( 10 );  
   for ( i = 0 ; i < 10 ; i += 3 )  
      vaR [ i ] =  i;  
   for ( i = 1 ; i < 10 ; i += 3 )  
      vaR [ i ] =  2*i - 1;  
   for ( i = 2 ; i < 10 ; i += 3 )  
      vaR [ i ] =  10 - i;  
  
   cout << "The operand valarray is: ( ";  
      for (i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   MaxValue = vaR.max (  );  
   cout << "The largest element in the valarray is: "  
        << MaxValue  << "." << endl;  
}  
```  
  
 **The operand valarray is: ( 0 1 8 3 7 5 6 13 2 9 ).**  
**The largest element in the valarray is: 13.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)