---
title: "bitset::set"
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
  - "std.bitset.set"
  - "set"
  - "std::bitset::set"
  - "bitset::set"
  - "bitset.set"
  - "bitset/std::bitset::set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set method"
ms.assetid: c1f3666b-414f-4565-bf02-e26c3b5e9869
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# bitset::set
Sets all the bits in a bitset to 1 or sets a bit at a specified position to 1.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position of the bit in the bitset to be set to assigned a value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to be assigned to the bit at the position specified.  
  
## Return Value  
 A copy of the bitset for which the member function was invoked.  
  
## Remarks  
 The second member function throws an [out_of_range](../vs140/out_of_range-class.md) exception if the position specified is greater than the size of the bitset.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The set of bits in bitset\<5> b1(6) is: ( 00110 )**  
**The collecion of bits obtained from setting the**  
 **zeroth bit of bitset b1 is: ( 00111 )**  
**The collecion of bits obtained from setting all the**  
 **elements of the bitset b1 is: ( 11111 )**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)