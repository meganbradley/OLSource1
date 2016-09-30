---
title: "bitset::operator!="
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
  - "bitset::operator!="
  - "bitset.operator!="
  - "!="
  - "std::bitset::operator!="
  - "bitset/std::bitset::operator!="
  - "std.bitset.operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator !=, bitsets"
  - "operator!=, bitsets"
ms.assetid: e3513727-6615-4f72-84e2-2869282e1c79
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator!=
Tests a target bitset for inequality with a specified bitset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bitset that is to be compared to the target bitset for inequality.  
  
## Return Value  
 **true** if the bitsets are different; **false** if they are the same.  
  
## Remarks  
 Bitsets must be of the same size to be tested for inequality by the member operator function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Bitset b1 is the same as bitset b2.**  
**Bitset b1 is different from bitset b3.**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)