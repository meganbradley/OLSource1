---
title: "slice::start"
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
  - "slice.start"
  - "Start"
  - "slice::start"
  - "start"
  - "std::slice::start"
  - "std.slice.start"
  - "valarray/std::slice::start"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "start method"
ms.assetid: 019c2137-7097-47f2-946a-33e039a8c102
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# slice::start
Finds the starting index of a slice of a valarray.  
  
## Syntax  
  
```  
  
size  
_  
t start( ) const;  
  
```  
  
## Return Value  
 The starting index of a slice of a valarray.  
  
## Example  
  
```  
// slice_start.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
   size_t startVAR;  
  
   valarray<int> va ( 20 ), vaResult;  
   for ( i = 0 ; i < 20 ; i += 1 )  
      va [ i ] = i+1;  
  
   cout << "The operand valarray va is:\n ( ";  
      for ( i = 0 ; i < 20 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   slice vaSlice ( 3 , 6 , 3 );  
   vaResult = va [ vaSlice ];  
  
   cout << "The slice of valarray va is vaResult = "  
        << "va[slice( 3, 6, 3)] =\n ( ";  
      for ( i = 0 ; i < 6 ; i++ )  
         cout << vaResult [ i ] << " ";  
   cout << ")." << endl;  
  
   startVAR = vaSlice.start ( );  
   cout << "The start index of slice vaSlice is: "  
        << startVAR << "." << endl;  
}  
```  
  
 **The operand valarray va is:**  
 **( 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 ).**  
**The slice of valarray va is vaResult = va[slice( 3, 6, 3)] =**  
 **( 4 7 10 13 16 19 ).**  
**The start index of slice vaSlice is: 3.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [slice Class](../vs140/slice-class.md)