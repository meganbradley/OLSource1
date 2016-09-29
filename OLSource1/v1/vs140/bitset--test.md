---
title: "bitset::test"
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
  - "bitset.test"
  - "bitset/std::bitset::test"
  - "bitset::test"
  - "test"
  - "std::bitset::test"
  - "std.bitset.test"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "test method"
ms.assetid: 57301aae-7d51-4006-a9ef-c82b6c0ff21e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::test
Tests whether the bit at a specified position in a bitset is set to 1.  
  
## Syntax  
  
```  
bool test(  
   size_t _Pos,  
) const;  
```  
  
#### Parameters  
 `_Pos`  
 The position of the bit in the bitset to be tested for its value.  
  
## Return Value  
 **true** if the bit specified by the argument position is set to 1; otherwise, **false**.  
  
## Remarks  
 The member function throws an [out_of_range](../vs140/out_of_range-class.md) exception that is the size of the bitset is less than or equal to the position specified in the argument.  
  
## Example  
  
```  
// bitset_test.cpp  
// compile with: /EHsc  
#include <bitset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   bitset<5> b1 ( 6 );  
   bool b;  
   bitset<5>::element_type e;  
  
   cout << "Original bitset b1(6) is: ( "<< b1 << " )"  
        << endl;  
   cout << "Note: positions in a bitset are numbered\n"  
         << " from the right starting with 0.\n" << endl;  
  
   b = b1.test ( 3 );  
  
   if ( b )  
      cout << "The bit at position 3 of bitset b1 "  
           << "has a value of 1." << endl;  
   else  
      cout << "The bit at position 3 of bitset b1 "  
           << "has a value of 0." << endl;  
  
   b1[3] = 1;  
   cout << "Bitset b1 modified by b1[3] = 1 is: ( "<< b1 << " )"  
        << endl;  
  
   e = b1.test ( 3 );  
   if ( e )  
      cout << "The bit at position 3 of bitset b1 "  
           << "has a value of 1." << endl;  
   else  
      cout << "The bit at position 3 of bitset b1 "  
           << "has a value of 0." << endl;  
}  
```  
  
 **Original bitset b1(6) is: ( 00110 )**  
**Note: positions in a bitset are numbered**  
 **from the right starting with 0.**  
**The bit at position 3 of bitset b1 has a value of 0.**  
**Bitset b1 modified by b1[3] = 1 is: ( 01110 )**  
**The bit at position 3 of bitset b1 has a value of 1.**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)