---
title: "operator^"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::^"
  - "valarray/std::operator^"
  - "operator^"
  - "std.operator^"
  - "std::operator^"
  - "std.^"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "^ operator, valarrays"
  - "operator^"
ms.assetid: e5716a0c-ffa5-42b9-800f-dafc09f5e09c
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator^
Obtains the bitwise exclusive `OR` (**XOR**) between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the element type.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<Type> operator^(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> operator^(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> operator^(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The first of the two valarrays whose respective elements are to be combined with the bitwise **XOR** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
 `_Right`  
 The second of the two valarrays whose respective elements are to be combined with the bitwise **XOR** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise combination of the bitwise **XOR** operation of `_Left` and `_Right.`  
  
## Remarks  
 A bitwise operation can only be used to manipulate bits in `char` and `int` data types and variants and not on **float**, **double**, `long double`, `void` `bool` or other, more complex data types.  
  
 The bitwise exclusive `OR` (**XOR**) has the following semantics: Given bits *b*1 and *b*2, *b*1 **XOR** *b*2 is **true** if exactly one of the bits is true; **false** if both bits are false or if both bits are true.  
  
## Example  
  
```  
// valarray_op_xor.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 10 ), vaR ( 10 );  
   valarray<int> vaLAA ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      vaL [ i ] =  1;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      vaL [ i ] =  0;  
   for ( i = 0 ; i < 10 ; i += 3 )  
      vaR [ i ] =  i;  
   for ( i = 1 ; i < 10 ; i += 3 )  
      vaR [ i ] =  i-1;  
   for ( i = 2 ; i < 10 ; i += 3 )  
      vaR [ i ] =  i-1;  
  
   cout << "The initial Left valarray is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaLAA = ( vaL ^ vaR );  
   cout << "The element-by-element result of "  
        << "the bitwise XOR operator^ is the\n valarray: ( ";  
           for ( i = 0 ; i < 10 ; i++ )  
         cout << vaLAA [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is:  ( 1 0 1 0 1 0 1 0 1 0 ).**  
**The initial Right valarray is: ( 0 0 1 3 3 4 6 6 7 9 ).**  
**The element-by-element result of the bitwise XOR operator^ is the**  
 **valarray: ( 1 0 0 3 2 4 7 6 6 9 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std