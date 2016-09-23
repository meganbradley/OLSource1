---
title: "bitset::reset"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.bitset.reset
  - Reset
  - bitset/std::bitset::reset
  - reset
  - std::bitset::reset
  - bitset.reset
  - bitset::reset
dev_langs: 
  - C++
helpviewer_keywords: 
  - reset method
ms.assetid: dbbe5964-4577-4697-a3fb-7dec3ec07c4e
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# bitset::reset
Resets all the bits in a bitset to 0 or resets a bit at a specified position to 0.  
  
## Syntax  
  
```  
  
      bitset<N>& reset( );   
bitset<N>& reset(  
   size_t _Pos  
);  
```  
  
#### Parameters  
 `_Pos`  
 The position of the bit in the bitset to be reset to 0.  
  
## Return Value  
 A copy of the bitset for which the member function was invoked.  
  
## Remarks  
 The second member function throws an [out_of_range](../vs140/out_of_range-class.md) exception if the position specified is greater than the size of the bitset.  
  
## Example  
  
```  
// bitset_reset.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   bitset<5> b1 ( 13 );  
   cout << "The set of bits in bitset<5> b1(13) is: ( "<< b1 << " )"  
        << endl;  
  
   bitset<5> b1r3;  
   b1r3 = b1.reset( 2 );  
   cout << "The collecion of bits obtained from resetting the\n"  
        << " third bit of bitset b1 is: ( "<< b1r3 << " )"   
        << endl;  
  
   bitset<5> b1r;  
   b1r = b1.reset( );  
   cout << "The collecion of bits obtained from resetting all\n"  
        << " the elements of the bitset b1 is: ( "<< b1r << " )"  
        << endl;  
}  
```  
  
 **The set of bits in bitset<5> b1(13) is: ( 01101 )**  
**The collecion of bits obtained from resetting the**  
 **third bit of bitset b1 is: ( 01001 )**  
**The collecion of bits obtained from resetting all**  
 **the elements of the bitset b1 is: ( 00000 )**   
## Requirements  
 **Header:** <bitset\>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)