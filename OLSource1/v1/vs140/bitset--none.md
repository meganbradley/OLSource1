---
title: "bitset::none"
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
  - "none"
  - "bitset/std::bitset::none"
  - "std.bitset.none"
  - "None"
  - "std::bitset::none"
  - "bitset::none"
  - "bitset.none"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "none method"
ms.assetid: 85830040-7b36-4e5e-ad69-65285d8c55cf
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::none
Tests if no bit has been set to 1 in a bitset object.  
  
## Syntax  
  
```  
  
bool none( ) const;  
  
```  
  
## Return Value  
 **true** if no bit in the bitset has been set to 1; **false** if at least one bit has been set to 1.  
  
## Example  
  
```  
// bitset_none.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   bitset<5> b1 ( 6 );  
   bool b, rb;  
  
   cout << "Original bitset b1(6) is: ( " << b1 << " )"  
        << endl;  
  
   b = b1.none ( );  
  
   if ( b )  
      cout << "None of the bits in bitset b1 are set to 1."  
           << endl;  
   else  
      cout << "At least one of the bits in bitset b1 is set to 1."  
           << endl;  
  
   bitset<5> rb1;  
   rb1 = b1.reset ( );  
   rb = rb1.none ( );  
   if ( rb )  
      cout << "None of the bits in bitset b1 are set to 1."  
           << endl;  
   else  
      cout << "At least one of the bits in bitset b1 is set to 1."  
           << endl;  
}  
```  
  
 **Original bitset b1(6) is: ( 00110 )**  
**At least one of the bits in bitset b1 is set to 1.**  
**None of the bits in bitset b1 are set to 1.**   
## Requirements  
 **Header:** <bitset\>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)