---
title: "bitset::operator&lt;&lt;="
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
  - "std.bitset.operator<<="
  - "operator<<="
  - "<<="
  - "bitset.operator<<="
  - "bitset::operator<<="
  - "std::bitset::operator<<="
  - "bitset/std::bitset::operator<<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<<="
  - "<<= operator"
  - "<<= operator, with specific objects"
ms.assetid: 1acbe51b-5479-4811-b267-a60f1dbb7adc
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator&lt;&lt;=
Shifts the bits in a bitset to the left a specified number of positions and returns the result to the targeted bitset.  
  
## Syntax  
  
```  
bitset<N>& operator<<=(  
   size_t _Pos  
);  
```  
  
#### Parameters  
 `_Pos`  
 The number of positions to the left the bits in the bitset are to be shifted.  
  
## Return Value  
 The targeted bitset modified so that the bits have been shifted to the left the required number of positions.  
  
## Remarks  
 If no element exists to shift into the position, the function clears the bit to a value of 0.  
  
## Example  
  
```  
// bitset_op_LSE.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   bitset<5> b1 ( 7 );  
   cout << "The target bitset b1 is: ( "<< b1 << " )." << endl;  
   b1 <<= 2;  
   cout << "After shifting the bits 2 positions to the left,\n"  
        << " the target bitset b1 becomes: ( "<< b1 << " )."   
        << endl;  
}  
```  
  
 **The target bitset b1 is: ( 00111 ).**  
**After shifting the bits 2 positions to the left,**  
 **the target bitset b1 becomes: ( 11100 ).**   
## Requirements  
 **Header:** <bitset\>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)