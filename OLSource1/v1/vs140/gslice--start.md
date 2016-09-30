---
title: "gslice::start"
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
  - "Start"
  - "valarray/std::gslice::start"
  - "gslice::start"
  - "std.gslice.start"
  - "start"
  - "gslice.start"
  - "std::gslice::start"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "start method"
ms.assetid: d16aaaac-07b5-4961-8d79-441e2ad14942
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gslice::start
Finds the starting index of a general slice of a valarray.  
  
## Syntax  
  
```  
  
size  
_  
t start( ) const;  
  
```  
  
## Return Value  
 The starting index of a general slice of a valarray.  
  
## Example  
  
```  
// gslice_start.cpp  
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
      for ( i = 0 ; i < 20 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   valarray<size_t> Len ( 2 ), Stride ( 2 );  
   Len [0] = 4;  
   Len [1] = 4;  
   Stride [0] = 7;  
   Stride [1] = 4;  
  
   gslice vaGSlice ( 0, Len, Stride );  
   vaResult = va [ vaGSlice ];  
   size_t vaGSstart = vaGSlice.start ( );  
  
   cout << "The valarray for vaGSlice is vaResult:"  
        << "\n va[vaGSlice] = ( ";  
      for (i = 0 ; i < 8 ; i++ )  
         cout << vaResult [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The index of the first element of vaResult is: "  
        << vaGSstart << "." << endl;  
}  
```  
  
 **The operand valarray va is:**  
 **( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 ).**  
**The valarray for vaGSlice is vaResult:**  
 **va[vaGSlice] = ( 0 4 8 12 7 11 15 19 ).**  
**The index of the first element of vaResult is: 0.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [gslice Class](../vs140/gslice-class.md)