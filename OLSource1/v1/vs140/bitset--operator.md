---
title: "bitset::operator"
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
  - "bitset.operator[]"
  - "[]"
  - "std::bitset::operator[]"
  - "operator[]"
  - "bitset::operator[]"
  - "std.bitset.operator[]"
  - "bitset/std::bitset::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], bitsets"
  - "operator[], bitsets"
  - "[] operator, with specific standard C++ objects"
ms.assetid: b3bc20eb-4a13-4f3e-bf6b-6c3bd6d7ae06
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator
Returns a reference to a bit at a specified position in a bitset if the bitset is modifiable; otherwise, it returns the value of the bit at that position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The position locating the bit within the bitset.  
  
## Remarks  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the bitset.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)