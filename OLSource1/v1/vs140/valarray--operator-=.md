---
title: "valarray::operator|="
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
  - "std::valarray::operator|="
  - "std.valarray.operator|="
  - "valarray.operator|="
  - "valarray::operator|="
  - "|="
  - "operator|="
  - "valarray/std::valarray::operator|="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "|= operator"
  - "operator|="
ms.assetid: 01a9e549-ada8-44e2-b674-ed1e8b4e5913
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator|=
Obtains the bitwise `OR` of elements in an array either with the corresponding elements in a specified valarray or with a value of the element type.  
  
## Syntax  
  
```  
  
      valarray<Type>& operator|=(  
   const valarray<Type>& _Right  
);  
valarray<Type>& operator|=(  
   const Type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The valarray or value of an element type identical to that of the operand valarray that is to be combined, element-wise, by the bitwise `OR` with the operand valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise bitwise `OR` of the operand valarray by `_Right.`  
  
## Remarks  
 A bitwise operation can only be used to manipulate bits in `char` and `int` data types and variants and not on **float**, **double**, **long double**, `void`, `bool`, or other, more complex data types.  
  
 The bitwise `OR` has the same truth table as the logical `OR` but applies to the data type on the level of the individual bits. Given bits *b*1 and *b*2, *b*1 `OR` *b*2 is **true** if at least one of the bits is true; **false** if both bits are false.  
  
## Example  
  
```  
// valarray_class_op_bitor.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 10 ), vaR ( 10 );  
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
  
   cout << "The initial operand valarray is:\n ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The _Right valarray is:\n ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaL |= vaR;  
   cout << "The element-by-element result of "  
        << "the logical OR\n operator|= is the valarray:\n ( ";  
      for (i = 0 ; i < 10 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial operand valarray is:**  
 **( 1 0 1 0 1 0 1 0 1 0 ).**  
**The _Right valarray is:**  
 **( 0 0 1 3 3 4 6 6 7 9 ).**  
**The element-by-element result of the logical OR**  
 **operator&#124;= is the valarray:**  
 **( 1 0 1 3 3 4 7 6 7 9 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)