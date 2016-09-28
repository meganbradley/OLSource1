---
title: "gslice::size"
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
  - "gslice::size"
  - "std.gslice.size"
  - "std::gslice::size"
  - "gslice.size"
  - "size"
  - "valarray/std::gslice::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 3829dba7-83be-4690-a10f-e45d38478954
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gslice::size
Finds the array values specifying the numbers of elements in a general slice of a valarray.  
  
## Syntax  
  
```  
valarray<size_t> size( ) const;  
```  
  
## Return Value  
 A valarray specifying the number of elements in each slice of a general slice of a valarray.  
  
## Remarks  
 The member function returns the stored lengths of slices.  
  
## Example  
  
```  
// gslice_size.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
   size_t sizeVA;  
  
   valarray<int> va ( 20 ), vaResult;  
   for ( i = 0 ; i < 20 ; i+=1 )  
      va [ i ] =  i;  
  
   cout << "The operand valarray va is:\n ( ";  
      for ( i = 0 ; i < 20 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   sizeVA = va.size ( );  
   cout << "The size of the valarray is: "  
        << sizeVA << "." << endl << endl;  
  
   valarray<size_t> Len ( 2 ), Stride ( 2 );  
   Len [0] = 4;  
   Len [1] = 4;  
   Stride [0] = 7;  
   Stride [1] = 4;  
  
   gslice vaGSlice ( 0, Len, Stride );  
   vaResult = va [ vaGSlice ];  
   const valarray <size_t> sizeGS = vaGSlice.size ( );  
  
   cout << "The valarray for vaGSlice is vaResult:"  
        << "\n va[vaGSlice] = ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaResult [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The size of vaResult is:"  
        << "\n vaGSlice.size ( ) = ( ";  
      for ( i = 0 ; i < 2 ; i++ )  
         cout << sizeGS[ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The operand valarray va is:**  
 **( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 ).**  
**The size of the valarray is: 20.**  
**The valarray for vaGSlice is vaResult:**  
 **va[vaGSlice] = ( 0 4 8 12 7 11 15 19 ).**  
**The size of vaResult is:**  
 **vaGSlice.size ( ) = ( 4 4 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [gslice Class](../vs140/gslice-class.md)