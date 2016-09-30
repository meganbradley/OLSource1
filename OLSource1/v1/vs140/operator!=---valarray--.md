---
title: "operator!= (&lt;valarray&gt;)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "valarray/std::operator!="
  - "std.operator!="
  - "std.!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator !=, valarrays"
  - "operator!=, valarrays"
ms.assetid: a29dc772-b44e-4c67-b023-aa16ea481bb6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;valarray&gt;)
Tests whether the corresponding elements of two equally sized valarrays are unequal or whether all the elements of a valarray are unequal a specified value.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<bool> operator!=(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<bool> operator!=(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<bool> operator!=(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The first of the two valarrays whose elements are to be tested for inequality.  
  
 `_Right`  
 The second of the two valarrays whose elements are to be tested for inequality.  
  
## Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the corresponding elements are unequal.  
  
-   **false** if the corresponding elements are not unequal.  
  
## Remarks  
 The first template operator returns an object of class [valarray\<bool>](../vs140/valarray-bool--class.md), each of whose elements `I` is `_Left`[`I`] != `_Right`[`I`].  
  
 The second template operator stores in element *I _Left*[`I`] != _*Right*.  
  
 The third template operator stores in element *I _Left* != `_Right`[`I`].  
  
## Example  
  
```  
// valarray_op_ne.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 10 ), vaR ( 10 );  
   valarray<bool> vaNE ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      vaL [ i ] =  -i;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      vaL [ i ] =  i;  
   for ( i = 0 ; i < 10 ; i++ )  
      vaR [ i ] =  i;  
  
   cout << "The initial Left valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaNE = ( vaL != vaR );  
   cout << "The element-by-element result of "  
        << "the not equal comparison test is the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaNE [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is: ( 0 1 -2 3 -4 5 -6 7 -8 9 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The element-by-element result of the not equal comparison test is the**  
 **valarray: ( 0 0 1 0 1 0 1 0 1 0 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std