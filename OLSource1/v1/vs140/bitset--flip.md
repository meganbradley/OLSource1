---
title: "bitset::flip"
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
  - "bitset::flip"
  - "flip"
  - "bitset/std::bitset::flip"
  - "bitset.flip"
  - "std.bitset.flip"
  - "std::bitset::flip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "flip method"
ms.assetid: cfe8506a-a77c-44d1-8c7b-ca070b5353b8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::flip
Toggles the value of all the bits in a bitset or toggles a single bit at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position of the bit whose value is to be toggled.  
  
## Return Value  
 A copy of the modified bitset for which the member function was invoked.  
  
## Remarks  
 The second member function throws an [out_of_range](../vs140/out_of_range-class.md) exception if the position specified as a parameter is greater than the size *N* of the **bitset\<***N***>** whose bit was toggled.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The collection of bits in the original bitset is: ( 00110 )**  
**After flipping all the bits, the bitset becomes: ( 11001 )**  
**After flipping the fourth bit, the bitset becomes: ( 10001 )**  
**00001  The bit flipped is in position 0.**  
**00011  The bit flipped is in position 1.**  
**00111  The bit flipped is in position 2.**  
**01111  The bit flipped is in position 3.**  
**11111  The bit flipped is in position 4.**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)