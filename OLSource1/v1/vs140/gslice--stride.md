---
title: "gslice::stride"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - stride
  - gslice.stride
  - gslice::stride
  - std::gslice::stride
  - valarray/std::gslice::stride
  - std.gslice.stride
dev_langs: 
  - C++
helpviewer_keywords: 
  - stride method
ms.assetid: e356ea07-6062-479a-87ff-3e986f46dd54
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# gslice::stride
Finds the distance between elements in a general slice of a valarray.  
  
## Syntax  
  
```  
valarray<size_t> stride( ) const;  
```  
  
## Return Value  
 A valarray specifying the distances between elements in each slice of a general slice of a valarray.  
  
## Example  
  
```  
// gslice_stride.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> va ( 20 ), vaResult;  
   for (i = 0 ; i < 20 ; i+=1 )  
      va [ i ] =  i;  
  
   cout << "The operand valarray va is:\n ( ";  
      for (i = 0 ; i < 20 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   valarray<size_t> Len ( 2 ), Stride ( 2 );  
   Len [0] = 4;  
   Len [1] = 4;  
   Stride [0] = 7;  
   Stride [1] = 4;  
  
   gslice vaGSlice ( 0, Len, Stride );  
   vaResult = va [ vaGSlice ];  
   const valarray <size_t> strideGS = vaGSlice.stride ( );  
  
   cout << "The valarray for vaGSlice is vaResult:"  
        << "\n va[vaGSlice] = ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaResult [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The strides of vaResult are:"  
        << "\n vaGSlice.stride ( ) = ( ";  
      for ( i = 0 ; i < 2 ; i++ )  
         cout << strideGS[ i ] << " ";  
   cout << ")." << endl;  
  
}  
```  
  
 **The operand valarray va is:**  
 **( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 ).**  
**The valarray for vaGSlice is vaResult:**  
 **va[vaGSlice] = ( 0 4 8 12 7 11 15 19 ).**  
**The strides of vaResult are:**  
 **vaGSlice.stride ( ) = ( 7 4 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [gslice Class](../vs140/gslice-class.md)