---
title: "operator&lt;&lt; (&lt;valarray&gt;)"
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
  - "valarray/std::operator<<"
  - "std.operator<<"
  - "std.<<"
  - "<<"
  - "std::<<"
  - "std::operator<<"
  - "operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator <<, valarrays"
  - "<< operator"
  - "<< operator, with specific objects"
  - "operator<<, valarrays"
ms.assetid: 82d061bd-9001-4aa3-bc32-43ccc2962c63
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;&lt; (&lt;valarray&gt;)
Left shifts the bits for each element of a valarray a specified number of positions or by an element-wise amount specified by a second valarray.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<Type> operator<<(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> operator<<(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> operator<<(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The value to be shifted or the valarray whose elements are to be shifted.  
  
 `_Right`  
 The value indicating the amount of left shift or valarray whose elements indicate the element-wise amount of left shift.  
  
## Return Value  
 A valarray whose elements have been shifted left by the specified amount.  
  
## Remarks  
 Signed numbers have their signs preserved.  
  
## Example  
  
```  
// valarray_op_ls.cpp  
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
      vaL [ i ] =  1;  
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
  
   vaNE = ( vaL << vaR );  
   cout << "The element-by-element result of "  
        << "the left shift is the\n valarray: ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaNE [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is: ( 1 -1 1 -1 1 -1 1 -1 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the left shift is the**  
 **valarray: ( 1 -2 4 -8 16 -32 64 -128 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std