---
title: "operator- (&lt;valarray&gt;)1"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator/ (&lt;valarray&gt;)"
f1_keywords: 
  - "valarray/std::operator/"
  - "std.operator/"
  - "std::/"
  - "/"
  - "std./"
  - "std::operator/"
  - "operator/"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/ operator, valarrays"
  - "/ operator"
  - "arithmetic operators [C++], division"
  - "division operator, valarrays"
ms.assetid: 9e5f6860-13b1-4f7d-8402-713ad7a7181a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- (&lt;valarray&gt;)1
Obtains the element-wise quotient between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<Type> operator/(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> operator/(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> operator/(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 A value or valarray that serves as the dividend into which another value or valarray is to be divided in forming the quotient.  
  
 `_Right`  
 A value or valarray that serves as the divisor and that divides another value or valarray in forming the quotient.  
  
## Return Value  
 A valarray whose elements are the element-wise quotient of `_Left` divided by `_Right.`  
  
## Remarks  
 The arithmetic terminology used in describing a division:  
  
 quotient = dividend / divisor  
  
## Example  
  
```  
// valarray_op_equo.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<double> vaL ( 6 ), vaR ( 6 );  
   valarray<double> vaNE ( 6 );  
   for ( i = 0 ; i < 6 ; i += 2 )  
      vaL [ i ] =  100;  
   for ( i = 1 ; i < 6 ; i += 2 )  
      vaL [ i ] =  -100;  
   for ( i = 0 ; i < 6 ; i++ )  
      vaR [ i ] =  2*i;  
  
   cout << "The initial Left valarray is: ( ";  
      for ( i = 0 ; i < 6 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for ( i = 0 ; i < 6 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaNE = ( vaL / vaR );  
   cout << "The element-by-element result of "  
        << "the quotient is the\n valarray: ( ";  
      for ( i = 0 ; i < 6 ; i++ )  
         cout << vaNE [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is: ( 100 -100 100 -100 100 -100 ).**  
**The initial Right valarray is: ( 0 2 4 6 8 10 ).**  
**The element-by-element result of the quotient is the**  
 **valarray: ( 1.#INF -50 25 -16.6667 12.5 -10 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std