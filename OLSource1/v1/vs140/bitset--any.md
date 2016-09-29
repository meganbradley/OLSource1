---
title: "bitset::any"
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
  - "std.bitset.any"
  - "any"
  - "std::bitset::any"
  - "bitset/std::bitset::any"
  - "bitset::any"
  - "Any"
  - "bitset.any"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "any method"
ms.assetid: 59f3135c-0865-493c-a31a-4f541d920a68
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::any
Tests whether any bit in the sequence is set to 1.  
  
## Syntax  
  
```  
  
bool any( ) const;  
  
```  
  
## Return Value  
 **true** if any bit in the bitset is set to 1; **false** if all the bits are 0.  
  
## Example  
  
```  
// bitset_any.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   bitset<5> b1 ( 6 );  
   bool b, rb;  
  
   cout << "The original bitset b1( 6 ) is: ( "<< b1 << " )"  
        << endl;  
  
   b = b1.any ( );  
  
   if ( b )  
      cout << "At least one of the bits in bitset is set to 1."  
           << endl;  
   else  
      cout << "None of the bits in bitset are set to 1."  
           << endl;  
  
   bitset<5> rb1;  
   rb1 = b1.reset ( );  
  
   cout << "The reset bitset is: ( "<< b1 << " )"  
        << endl;  
  
   rb = rb1.any ( );  
  
   if ( rb )  
      cout << "At least one of the bits in the reset bitset "  
           << "are set to 1." << endl;  
   else  
      cout << "None of the bits in bitset b1 are set to 1."  
           << endl;  
}  
```  
  
 **The original bitset b1( 6 ) is: ( 00110 )**  
**At least one of the bits in bitset is set to 1.**  
**The reset bitset is: ( 00000 )**  
**None of the bits in bitset b1 are set to 1.**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)