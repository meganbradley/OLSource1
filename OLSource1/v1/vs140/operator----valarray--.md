---
title: "operator+ (&lt;valarray&gt;)"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::operator+
  - valarray/std::operator+
  - +
  - operator+
  - std.operator+
  - std.+
  - std::+
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator+, valarrays
  - + operator, valarrays
  - + operator
  - operator +, valarrays
ms.assetid: 156009ca-cb7c-4616-889c-22f187ca55ee
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator+ (&lt;valarray&gt;)
Obtains the element-wise sum between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<Type> operator+(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> operator+(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> operator+(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The first of the two valarrays whose elements are to be added or a specified value to be added with each element of a valarray.  
  
 `_Right`  
 The second of the two valarrays whose elements are to be added or a specified value to be added with each element of a valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise sum of `_Left` and `_Right.`  
  
## Example  
  
```  
// valarray_op_esum.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 8 ), vaR ( 8 );  
   valarray<int> vaNE ( 8 );  
   for ( i = 0 ; i < 8 ; i += 2 )  
      vaL [ i ] =  2;  
   for ( i = 1 ; i < 8 ; i += 2 )  
      vaL [ i ] =  -1;  
   for ( i = 0 ; i < 8 ; i++ )  
      vaR [ i ] =  i;  
  
   cout << "The initial Left valarray is: ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaNE = ( vaL + vaR );  
   cout << "The element-by-element result of "  
        << "the sum is the\n valarray: ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaNE [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is: ( 2 -1 2 -1 2 -1 2 -1 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the sum is the**  
 **valarray: ( 2 0 4 2 6 4 8 6 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std