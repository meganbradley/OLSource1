---
title: "bitset::size"
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
  - "bitset/std::bitset::size"
  - "bitset.size"
  - "std.bitset.size"
  - "size"
  - "std::bitset::size"
  - "bitset::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: e1192245-77d9-40af-8176-37abee1621ef
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# bitset::size
Returns the number of bits in a bitset object.  
  
## Syntax  
  
```  
  
size_t size( ) const;  
```  
  
## Return Value  
 The number of bits, *N*, in a **bitset<***N***>**.  
  
## Example  
 The following example demonstrates the use of the bitset::size member function.  
  
```  
// bitset_size.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
  
    bitset<5> b1(6);  
    size_t i;  
  
    cout << "The set of bits in bitset<5> b1( 6 ) is: ( "<< b1 << " )"  
         << endl;  
  
    i = b1.size();  
  
    cout << "The number of bits in bitset b1 is: " << i << "."  
         << endl;  
}  
```  
  
 **The set of bits in bitset<5> b1( 6 ) is: ( 00110 )**  
**The number of bits in bitset b1 is: 5.**   
## Requirements  
 **Header:** <bitset\>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../VS_csharp/bitset-class.md)