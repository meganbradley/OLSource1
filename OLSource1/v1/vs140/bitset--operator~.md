---
title: "bitset::operator~"
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
  - "bitset/std::bitset::operator~"
  - "~"
  - "bitset::operator~"
  - "operator~"
  - "std::bitset::operator~"
  - "bitset.operator~"
  - "std.bitset.operator~"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator~"
  - "~ operator, toggling bitset"
ms.assetid: f5f555a3-c079-45d2-8940-b17acc1ceb81
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator~
Toggles all the bits in a target bitset and returns the result.  
  
## Syntax  
  
```  
bitset<N> operator~( ) const;  
```  
  
## Return Value  
 The bitset with all its bits toggled with respect to the targeted bitset.  
  
## Example  
  
```  
// bitset_op_toggle.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <string>  
#include <bitset>  
  
int main( )  
{  
   using namespace std;  
  
   bitset<5> b1 ( 7 );  
   bitset<5> b2;  
   b2 = ~b1;  
  
   cout << "Bitset b1 is: ( "<< b1 << " )." << endl;  
   cout << "Bitset b2 = ~b1 is: ( "<< b2 << " )." << endl;  
  
   // These bits could also be flipped using the flip member function  
   bitset<5> b3;  
   b3 = b1.flip( );  
   cout << "Bitset b3 = b1.flip( ) is: ( "<< b2 << " )." << endl;  
}  
```  
  
 **Bitset b1 is: ( 00111 ).**  
**Bitset b2 = ~b1 is: ( 11000 ).**  
**Bitset b3 = b1.flip( ) is: ( 11000 ).**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)