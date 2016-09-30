---
title: "bitset::operator&amp;="
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
  - "bitset::operator&="
  - "std::bitset::operator&="
  - "&="
  - "bitset.operator&="
  - "operator&="
  - "std.bitset.operator&="
  - "bitset/std::bitset::operator&="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator&="
  - "&= operator"
ms.assetid: 7159027b-5080-4b7c-85d8-a21a1b4bbe9d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator&amp;=
Performs a bitwise combination of bitsets with the logical **AND** operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bitset that is to be combined bitwise with the target bitset.  
  
## Return Value  
 The modified target bitset that results from the bitwise **AND** operation with the bitset specified as a parameter.  
  
## Remarks  
 Two bits combined by the **AND** operator return **true** if each bit is true; otherwise, their combination returns **false**.  
  
 Bitsets must be of the same size to be combined bitwise with the **AND** operator by the member operator function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The target bitset b1 is:    ( 00111 ).**  
**The parameter bitset b2 is: ( 01011 ).**  
**After bitwise AND combination,**  
 **the target bitset b1 becomes:   ( 00011 ).**  
**The parameter bitset b2 remains: ( 01011 ).**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)