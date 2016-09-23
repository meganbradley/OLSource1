---
title: "valarray::operator-=1"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: valarray::operator/=
f1_keywords: 
  - valarray.operator/=
  - operator/=
  - valarray/std::valarray::operator/=
  - std.valarray.operator/=
  - /=
  - std::valarray::operator/=
  - valarray::operator/=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator/=
  - operator /=
  - /= operator
ms.assetid: f801e000-1c86-4de6-9c24-493107b511a0
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# valarray::operator-=1
Divides an operand valarray element-wise by the elements of a specified valarray or a value of the element type.  
  
## Syntax  
  
```  
  
      valarray<Type>& operator/=(  
   const valarray<Type>& _Right  
);  
valarray<Type>& operator/=(  
   const Type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The valarray or value of an element type identical to that of the operand valarray that is to be divided, element-wise, into the operand valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise quotient of the operand valarray divided by `_Right.`  
  
## Example  
  
```  
// valarray_op_ediv.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<double> vaL ( 6 ), vaR ( 6 );  
   for ( i = 0 ; i < 6 ; i += 2 )  
      vaL [ i ] =  100;  
   for ( i = 1 ; i < 6 ; i += 2 )  
      vaL [ i ] =  -100;  
   for ( i = 0 ; i < 6 ; i++ )  
      vaR [ i ] =  2*i;  
  
   cout << "The initial valarray is: ( ";  
      for (i = 0 ; i < 6 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for (i = 0 ; i < 6 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaL /= vaR;  
   cout << "The element-by-element result of "  
        << "the quotient is the\n valarray: ( ";  
      for (i = 0 ; i < 6 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial valarray is: ( 100 -100 100 -100 100 -100 ).**  
**The initial Right valarray is: ( 0 2 4 6 8 10 ).**  
**The element-by-element result of the quotient is the**  
 **valarray: ( 1.#INF -50 25 -16.6667 12.5 -10 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)