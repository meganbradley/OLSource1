---
title: "slice::slice"
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
  - "slice::slice"
  - "valarray/std::slice::slice"
  - "std.slice.slice"
  - "std::slice::slice"
  - "slice"
  - "slice.slice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "slice class, constructor"
  - "slice method"
ms.assetid: 8fd9c1be-623b-40c5-b029-99b668df061b
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# slice::slice
Defines a subset of a valarray that consists of a number of elements that are an equal distance apart and that start at a specified element.  
  
## Syntax  
  
```  
slice( );  
slice(  
   size_t _StartIndex,  
   size_t _Len,   
   size_t _Stride  
);  
```  
  
#### Parameters  
 `_StartIndex`  
 The valarray index of the first element in the subset.  
  
 `_Len`  
 The number of elements in the subset.  
  
 `_Stride`  
 The distance between elements in the subset.  
  
## Return Value  
 The default constructor stores zeros for the starting index, total length, and stride. The second constructor stores `_StartIndex` for the starting index, `_Len` for the total length, and `_Stride` for the stride.  
  
## Remarks  
 The stride may be negative.  
  
## Example  
  
```  
// slice_ctor.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> va ( 20 ), vaResult;  
   for ( i = 0 ; i < 20 ; i+=1 )  
      va [ i ] =  2 * (i + 1 );  
  
   cout << "The operand valarray va is:\n( ";  
      for ( i = 0 ; i < 20 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   slice vaSlice ( 1 , 7 , 3 );  
   vaResult = va [ vaSlice ];  
  
   cout << "\nThe slice of valarray va is vaResult:"  
        << "\nva[slice( 1, 7, 3)] = ( ";  
      for ( i = 0 ; i < 7 ; i++ )  
         cout << vaResult [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The operand valarray va is:**  
**( 2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 ).**  
**The slice of valarray va is vaResult:**  
**va[slice( 1, 7, 3)] = ( 4 10 16 22 28 34 40 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [slice Class](../vs140/slice-class.md)