---
title: "valarray::operator&lt;&lt;="
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
  - "operator<<="
  - "<<="
  - "std.valarray.operator<<="
  - "valarray/std::valarray::operator<<="
  - "valarray.operator<<="
  - "std::valarray::operator<<="
  - "valarray::operator<<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<<="
  - "<<= operator"
  - "<<= operator, with specific objects"
ms.assetid: 65485dca-0e73-4a15-8936-33008614489f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator&lt;&lt;=
Left-shifts the bits for each element of a valarray operand a specified number of positions or by an element-wise amount specified by a second valarray.  
  
## Syntax  
  
```  
  
      valarray<Type>& operator<<=(  
   const valarray<Type>& _Right  
);  
valarray<Type>& operator<<=(  
   const Type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The value indicating the amount of left shift or valarray whose elements indicate the element-wise amount of left shift.  
  
## Return Value  
 A valarray whose elements have been shifted left the amount specified in `_Right`.  
  
## Remarks  
 Signed numbers have their signs preserved.  
  
## Example  
  
```  
// valarray_class_op_ls.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> vaL ( 8 ), vaR ( 8 );  
   for ( i = 0 ; i < 8 ; i += 2 )  
      vaL [ i ] =  1;  
   for ( i = 1 ; i < 8 ; i += 2 )  
      vaL [ i ] =  -1;  
   for ( i = 0 ; i < 8 ; i++ )  
      vaR [ i ] =  i;  
  
   cout << "The initial operand valarray is: ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The _Right valarray is: ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaR [ i ] << " ";  
   cout << ")." << endl;  
  
   vaL <<= vaR;  
   cout << "The element-by-element result of "  
        << "the left shift\n on the operand array is the valarray:\n ( ";  
      for ( i = 0 ; i < 8 ; i++ )  
         cout << vaL [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial operand valarray is: ( 1 -1 1 -1 1 -1 1 -1 ).**  
**The _Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the left shift**  
 **on the operand array is the valarray:**  
 **( 1 -2 4 -8 16 -32 64 -128 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)