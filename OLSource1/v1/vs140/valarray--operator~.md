---
title: "valarray::operator~"
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
  - "std::valarray::operator~"
  - "valarray/std::valarray::operator~"
  - "~"
  - "valarray::operator~"
  - "operator~"
  - "std.valarray.operator~"
  - "valarray.operator~"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~ operator, valarrays"
  - "operator~"
ms.assetid: 5f5fadcf-28ca-4bab-a7ab-cb6d09871dc5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator~
A unary operator that obtains the bitwise **NOT** values of each element in a valarray.  
  
## Syntax  
  
```  
  
valarray<Type> operator~( ) const;  
  
```  
  
## Return Value  
 The valarray of Boolean values that are the bitwise **NOT** of the element values of the operand valarray.  
  
## Remarks  
 A bitwise operation can only be used to manipulate bits in `char` and `int` data types and variants and not on **float**, **double**, **long double**, `void`, `bool` or other, more complex data types.  
  
 The bitwise **NOT** has the same truth table as the logical **NOT** but applies to the data type on the level of the individual bits. Given bit *b*, ~*b* is true if *b* is false and false if *b* is true. The logical **NOT** [operator!](../vs140/valarray--operator!.md) applies on an element level, counting all nonzero values as **true**, and the result is a valarray of Boolean values. The bitwise **NOT operator~**, by contrast, can result in a valarray of values other than 0 or 1, depending on outcome of the bitwise operation.  
  
## Example  
  
```  
// valarray_op_bitnot.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<unsigned short int> vaL1 ( 10 );  
   valarray<unsigned short int> vaNOT1 ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      vaL1 [ i ] =  i;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      vaL1 [ i ] =  5*i;  
  
   cout << "The initial valarray <unsigned short int> is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL1 [ i ] << " ";  
   cout << ")." << endl;  
  
   vaNOT1 = ~vaL1;  
   cout << "The element-by-element result of "  
        << "the bitwise NOT operator~ is the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaNOT1 [ i ] << " ";  
   cout << ")." << endl << endl;  
  
   valarray<int> vaL2 ( 10 );  
   valarray<int> vaNOT2 ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      vaL2 [ i ] =  i;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      vaL2 [ i ] =  -2 * i;  
  
   cout << "The initial valarray <int> is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL2 [ i ] << " ";  
   cout << ")." << endl;  
  
   vaNOT2 = ~vaL2;  
   cout << "The element-by-element result of "  
        << "the bitwise NOT operator~ is the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaNOT2 [ i ] << " ";  
   cout << ")." << endl;  
  
   // The negative numbers are represented using  
   // the two's complement approach, so adding one  
   // to the flipped bits returns the negative elements  
   vaNOT2 = vaNOT2 + 1;  
   cout << "The element-by-element result of "  
        << "adding one\n is the negative of the "  
        << "original elements the\n valarray: ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaNOT2 [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial valarray \<unsigned short int> is:  ( 0 5 2 15 4 25 6 35 8 45 ).**  
**The element-by-element result of the bitwise NOT operator~ is the**  
 **valarray: ( 65535 65530 65533 65520 65531 65510 65529 65500 65527 65490 ).**  
**The initial valarray \<int> is:  ( 0 -2 2 -6 4 -10 6 -14 8 -18 ).**  
**The element-by-element result of the bitwise NOT operator~ is the**  
 **valarray: ( -1 1 -3 5 -5 9 -7 13 -9 17 ).**  
**The element-by-element result of adding one**  
 **is the negative of the original elements the**  
 **valarray: ( 0 2 -2 6 -4 10 -6 14 -8 18 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)