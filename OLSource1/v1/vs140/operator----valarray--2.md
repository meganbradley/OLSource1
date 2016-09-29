---
title: "operator- (&lt;valarray&gt;)2"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator- (&lt;valarray&gt;)"
f1_keywords: 
  - "std.-"
  - "-"
  - "operator-"
  - "valarray/std::operator-"
  - "std.operator-"
  - "std::-"
  - "std::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator"
  - "- operator, valarrays"
ms.assetid: 5107dbdb-ec94-4fc8-8794-4acdbaec3e4e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- (&lt;valarray&gt;)2
Obtains the element-wise difference between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<Type> operator-(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> operator-(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> operator-(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 A value or valarray that serves as the minuend from which other values or valarrays are to be subtracted in forming the difference.  
  
 `_Right`  
 A value or valarray that serves as the subtrahend that is to be subtracted from other values or valarrays in forming the difference.  
  
## Return Value  
 A valarray whose elements are the element-wise difference of `_Left` and `_Right.`  
  
## Remarks  
 The arithmetic terminology used in describing a subtraction:  
  
 difference = minuend - subtrahend  
  
## Example  
  
```  
// valarray_op_ediff.cpp  
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
      vaL [ i ] =  10;  
   for ( i = 1 ; i < 8 ; i += 2 )  
      vaL [ i ] =  0;  
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
  
   vaNE = ( vaL - vaR );  
   cout << "The element-by-element result of "  
        << "the difference is the\n valarray: ( ";  
      for (i = 0 ; i < 8 ; i++ )  
         cout << vaNE [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is: ( 10 0 10 0 10 0 10 0 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the difference is the**  
 **valarray: ( 10 -1 8 -3 6 -5 4 -7 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std