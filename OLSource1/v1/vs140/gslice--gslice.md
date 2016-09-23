---
title: "gslice::gslice"
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
  - gslice.gslice
  - std::gslice::gslice
  - std.gslice.gslice
  - valarray/std::gslice::gslice
  - gslice::gslice
  - gslice
dev_langs: 
  - C++
helpviewer_keywords: 
  - gslice class
  - gslice method
ms.assetid: 13268819-f528-40ec-b9ed-645bab918c3c
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# gslice::gslice
A utility class to valarray that is used to define multi-dimensional slices of a valarray.  
  
## Syntax  
  
```  
gslice( );  
gslice(  
   size_t _StartIndex,  
   const valarray<size_t>& _LenArray,  
   const valarray<size_t>& _IncArray  
);  
```  
  
#### Parameters  
 `_StartIndex`  
 The valarray index of the first element in the subset.  
  
 `_LenArray`  
 An array specifying the number of elements in each slice.  
  
 `_IncArray`  
 An array specifying the stride in each slice.  
  
## Return Value  
 The default constructor stores zero for the starting index, and zero-length vectors for the length and stride vectors. The second constructor stores `_StartIndex` for the starting index, `_LenArray` for the length array, and `_IncArray` for the stride array.  
  
## Remarks  
 **gslice** defines a subset of a valarray that consists of multiple slices of the valarray that each start at the same specified element. The ability to use arrays to define multiple slices is the only difference between `gslice` and [slice::slice](../vs140/slice--slice.md). The first slice has a first element with an index of `_StartIndex`, a number of elements specified by the first element of `_LenArray`, and a stride given by the first element of `_IncArray`. The next set of orthogonal slices has first elements given by the first slice. The second element of `_LenArray` specifies the number of elements. The stride is given by the second element of `_IncArray`. A third dimension of slices would take the elements of the two-dimensional array as the starting elements and proceed analogously  
  
## Example  
  
```  
// gslice_ctor.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> va ( 20 ), vaResult;  
   for ( i = 0 ; i < 20 ; i+=1 )   
      va [ i ] =  i;  
  
   cout << "The operand valarray va is:" << endl << "(";  
   for ( i = 0 ; i < 20 ; i++ )  
      cout << " " << va [ i ];  
   cout << " )" << endl;  
  
   valarray<size_t> Len ( 2 ), Stride ( 2 );  
   Len [0] = 4;  
   Len [1] = 4;  
   Stride [0] = 7;  
   Stride [1] = 4;  
  
   gslice vaGSlice ( 0, Len, Stride );  
   vaResult = va [ vaGSlice ];  
  
   cout << "The valarray for vaGSlice is vaResult:" << endl  
        << "va[vaGSlice] = (";  
  
   for ( i = 0 ; i < 8 ; i++ )  
      cout << " " << vaResult [ i ];  
   cout << ")" << endl;  
}  
```  
  
 **The operand valarray va is:**  
**( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 )**  
**The valarray for vaGSlice is vaResult:**  
**va[vaGSlice] = ( 0 4 8 12 7 11 15 19)**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [gslice Class](../vs140/gslice-class.md)