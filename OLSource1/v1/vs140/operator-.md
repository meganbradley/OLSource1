---
title: "operator&amp;"
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
  - &
  - std.operator&
  - valarray/std::operator&
  - std::&
  - operator&
  - std.&
  - std::operator&
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator&
  - & operator, valarray operations
  - & operator
ms.assetid: 61d4460c-b60c-4c15-a05a-251d506d6443
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&amp;
Obtains the bitwise **AND** between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the element type.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<Type> operator&(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> operator&(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> operator&(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The first of the two valarrays whose respective elements are to be combined with the bitwise **AND** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
 `_Right`  
 The second of the two valarrays whose respective elements are to be combined with the bitwise **AND** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise combination of the bitwise AND operation of `_Left` and `_Right.`  
  
## Remarks  
 A bitwise operation can only be used to manipulate bits in `char` and `int` data types and variants and not on **float**, **double**, **long double**, `void` `bool` or other, more complex data types.  
  
 The bitwise **AND** has the same truth table as the logical **AND** but applies to the data type on the level of the individual bits. The [operator&&](../vs140/operator--.md) applies on an element level, counting all nonzero values as true, and the result is a valarray of Boolean values. The bitwise **AND operator&**, by contrast, can result in a valarray of values other than 0 or 1, depending on outcome of the bitwise operation.  
  
## Example  
  
```  
// valarray_op_bitand.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 10 ), vaR ( 10 );  
   valarray<int> vaBWA ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      vaL [ i ] =  0;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      vaL [ i ] =  i+1;  
   for ( i = 0 ; i < 10 ; i++ )  
      vaR [ i ] =  i;  
  
   cout << "The initial Left valarray is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaBWA = ( vaL & vaR );  
   cout << "The element-by-element result of "  
        << "the bitwise operator & is the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaBWA [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is:  ( 0 2 0 4 0 6 0 8 0 10 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The element-by-element result of the bitwise operator & is the**  
 **valarray: ( 0 0 0 0 0 4 0 0 0 8 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std