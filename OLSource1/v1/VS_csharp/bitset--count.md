---
title: "bitset::count"
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
  - "bitset/std::bitset::count"
  - "bitset.count"
  - "bitset::count"
  - "std::bitset::count"
  - "std.bitset.count"
  - "count"
  - "Count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: de8e16ef-9096-433c-af84-222176761590
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::count
Returns the number of bits set in the bit sequence.  
  
## Syntax  
  
```  
  
size_t count( ) const;  
  
```  
  
## Return Value  
 The number of bits set in the bit sequence.  
  
## Example  
 The following example demonstrates the use of the bitset::count member function.  
  
```  
// bitset_count.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
    using namespace std;  
  
    bitset<5> b1(4);  
  
    cout << "The collection of bits in the original bitset is: ( "  
         << b1 << " )" << endl;  
  
    size_t i;  
    i = b1.count();  
    cout << "The number of bits in the bitset set to 1 is: "  
         << i << "." << endl;  
  
    bitset<5> fb1;  
    fb1 = b1.flip();  
  
    cout << "The collection of flipped bits in the modified bitset "  
         << "is: ( " << b1 << " )" << endl;  
  
    size_t ii;  
    ii = fb1.count();  
    cout << "The number of bits in the bitset set to 1 is: "  
         << ii << "." << endl;  
}  
```  
  
 **The collection of bits in the original bitset is: ( 00100 )**  
**The number of bits in the bitset set to 1 is: 1.**  
**The collection of flipped bits in the modified bitset is: ( 11011 )**  
**The number of bits in the bitset set to 1 is: 4.**   
## Requirements  
 **Header:** <bitset\>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../VS_csharp/bitset-class.md)