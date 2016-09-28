---
title: "valarray::operator+="
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
  - "operator+="
  - "valarray::operator+="
  - "std::valarray::operator+="
  - "valarray/std::valarray::operator+="
  - "+="
  - "valarray.operator+="
  - "std.valarray.operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +=, valarrays"
  - "+= operator, valarray"
  - "operator+=, valarrays"
  - "+= operator"
ms.assetid: 300a4bca-5e2f-4566-b5a3-41e48fc7703b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator+=
Adds the elements of a specified valarray or a value of the element type, element-wise, to an operand valarray.  
  
## Syntax  
  
```  
  
      valarray<Type>& operator+=(  
   const valarray<Type>& _Right  
);  
valarray<Type>& operator+=(  
   const Type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The valarray or value of an element type identical to that of the operand valarray that is to be added, element-wise, to the operand valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise sum of the operand valarray and `_Right.`  
  
## Example  
  
```  
// valarray_op_eadd.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 8 ), vaR ( 8 );  
   for ( i = 0 ; i < 8 ; i += 2 )  
      vaL [ i ] =  2;  
   for ( i = 1 ; i < 8 ; i += 2 )  
      vaL [ i ] =  -1;  
   for ( i = 0 ; i < 8 ; i++ )  
      vaR [ i ] =  i;  
  
   cout << "The initial valarray is: ( ";  
      for (i = 0 ; i < 8 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial _Right valarray is: ( ";  
      for (i = 0 ; i < 8 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaL += vaR;  
   cout << "The element-by-element result of "  
        << "the sum is the\n valarray: ( ";  
      for (i = 0 ; i < 8 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial valarray is: ( 2 -1 2 -1 2 -1 2 -1 ).**  
**The initial _Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the sum is the**  
 **valarray: ( 2 0 4 2 6 4 8 6 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)