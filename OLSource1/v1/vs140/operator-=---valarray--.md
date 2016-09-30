---
title: "operator&gt;= (&lt;valarray&gt;)"
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
  - "operator>="
  - "std::>="
  - "std.operator>="
  - ">="
  - "std.>="
  - "valarray/std::operator>="
  - "std::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">= operator, comparing specific objects"
  - "operator >=, valarrays"
  - "operator>=, valarrays"
ms.assetid: 01f81b40-1b48-4084-82e7-49e39a112a7d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (&lt;valarray&gt;)
Tests whether the elements of one valarray are greater than or equal to the elements of an equally sized valarray or whether all the elements of a valarray are greater than or equal to or less than or equal to a specified value.  
  
## Syntax  
  
```  
template<class Type>  
   valarray<bool> operator>=(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<bool> operator>=(  
      const valarray<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   valarray<bool> operator>=(  
      const Type& _Left,  
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The first of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
 `_Right`  
 The second of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
## Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the `_Left` element or value is greater than or equal to the corresponding `_Right` element or value.  
  
-   **false** if the `_Left` element or value is less than the corresponding `_Right` element or value.  
  
## Remarks  
 If the number of elements in two valarrays is not equal, the result is undefined.  
  
## Example  
  
```  
// valarray_op_ge.cpp  
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
      vaR [ i ] =  i - 1;  
  
   cout << "The initial Left valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial Right valarray is: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaNE = ( vaL >= vaR );  
   cout << "The element-by-element result of "  
        << "the greater than or equal test is the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaNE [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial Left valarray is: ( 0 1 -2 3 -4 5 -6 7 -8 9 ).**  
**The initial Right valarray is: ( -1 0 1 2 3 4 5 6 7 8 ).**  
**The element-by-element result of the greater than or equal test is the**  
 **valarray: ( 1 1 0 1 0 1 0 1 0 1 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std