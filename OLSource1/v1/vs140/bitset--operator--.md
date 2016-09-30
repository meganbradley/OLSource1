---
title: "bitset::operator&lt;&lt;"
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
  - "bitset/std::bitset::operator<<"
  - "bitset::operator<<"
  - "<<"
  - "std::bitset::operator<<"
  - "operator<<"
  - "bitset.operator<<"
  - "std.bitset.operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<< operator"
  - "<< operator, with specific objects"
  - "operator <<, bitsets"
  - "operator<<, bitsets"
ms.assetid: 64fe0256-6054-4ed7-8dc6-4f11753de664
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator&lt;&lt;
Shifts the bits in a bitset to the left a specified number of positions and returns the result to a new bitset.  
  
## Syntax  
  
```  
bitset<N> operator<<(  
   size_t _Pos  
) const;  
```  
  
#### Parameters  
 `_Pos`  
 The number of positions to the left that the bits in the bitset are to be shifted.  
  
## Return Value  
 The modified bitset with the bits shifted to the left the required number of positions.  
  
## Remarks  
 The member operator function returns **bitset**(**\*this**) **<<= pos,** where [<<=](../vs140/bitset--operator--=.md) shifts the bits in a bitset to the left a specified number of positions and returns the result to the targeted bitset.  
  
## Example  
  
```  
// bitset_op_LS.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   bitset<5> b1 ( 7 );  
  
   cout << "The bitset b1 is: ( "<< b1 << " )." << endl;  
  
   bitset<5> b2;  
   b2 = b1 << 2;  
  
   cout << "After shifting the bits 2 positions to the left,\n"  
        << " the bitset b2 is: ( "<< b2 << " )."  
        << endl;  
  
   bitset<5> b3 = b2 >> 1;  
  
   cout << "After shifting the bits 1 position to the right,\n"  
        << " the bitset b3 is: ( " << b3 << " )."  
        << endl;  
}  
```  
  
## Output  
  
```  
The bitset b1 is: ( 00111 ).  
After shifting the bits 2 positions to the left,  
 the bitset b2 is: ( 11100 ).  
After shifting the bits 1 position to the right,  
 the bitset b3 is: ( 01110 ).  
```  
  
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)