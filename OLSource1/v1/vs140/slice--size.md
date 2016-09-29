---
title: "slice::size"
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
  - "slice::size"
  - "valarray/std::slice::size"
  - "size"
  - "slice.size"
  - "std::slice::size"
  - "std.slice.size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 2e552598-a720-4f46-ad90-2901185c8e5e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# slice::size
Finds the number of elements in a slice of a valarray.  
  
## Syntax  
  
```  
  
size  
_  
t size( ) const;  
  
```  
  
## Return Value  
 The number of elements in a slice of a valarray.  
  
## Example  
  
```  
// slice_size.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
   size_t sizeVA, sizeVAR;  
  
   valarray<int> va ( 20 ), vaResult;  
   for ( i = 0 ; i < 20 ; i += 1 )  
      va [ i ] =  i+1;  
  
   cout << "The operand valarray va is:\n ( ";  
      for ( i = 0 ; i < 20 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   sizeVA = va.size ( );  
   cout << "The size of the valarray is: "  
        << sizeVA << "." << endl << endl;  
  
   slice vaSlice ( 3 , 6 , 3 );  
   vaResult = va [ vaSlice ];  
  
   cout << "The slice of valarray va is vaResult = "  
        << "va[slice( 3, 6, 3)] =\n ( ";  
      for ( i = 0 ; i < 6 ; i++ )  
         cout << vaResult [ i ] << " ";  
   cout << ")." << endl;  
  
   sizeVAR = vaSlice.size ( );  
   cout << "The size of slice vaSlice is: "  
        << sizeVAR << "." << endl;  
}  
```  
  
 **The operand valarray va is:**  
 **( 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 ).**  
**The size of the valarray is: 20.**  
**The slice of valarray va is vaResult = va[slice( 3, 6, 3)] =**  
 **( 4 7 10 13 16 19 ).**  
**The size of slice vaSlice is: 6.**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [slice Class](../vs140/slice-class.md)