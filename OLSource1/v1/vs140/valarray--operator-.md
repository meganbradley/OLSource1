---
title: "valarray::operator+"
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
  - "+"
  - "valarray.operator+"
  - "std::valarray::operator+"
  - "operator+"
  - "valarray::operator+"
  - "std.valarray.operator+"
  - "valarray/std::valarray::operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator+, valarrays"
  - "+ operator, valarrays"
  - "+ operator"
  - "operator +, valarrays"
ms.assetid: a04b72e6-bd2d-49fb-8b9a-09f2f35bbbbf
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator+
A unary operator that applies a plus to each element in a valarray.  
  
## Syntax  
  
```  
  
valarray<Type> operator+( ) const;  
  
```  
  
## Return Value  
 A valarray whose elements are plus those of the operand array.  
  
## Example  
  
```  
// valarray_op_eplus.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 10 );  
   valarray<int> vaPLUS ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      vaL [ i ] =  -i;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      vaL [ i ] =  i-1;  
  
   cout << "The initial valarray is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   vaPLUS = +vaL;  
   cout << "The element-by-element result of "  
        << "the operator+ is the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaPLUS [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial valarray is:  ( 0 0 -2 2 -4 4 -6 6 -8 8 ).**  
**The element-by-element result of the operator+ is the**  
 **valarray: ( 0 0 -2 2 -4 4 -6 6 -8 8 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)