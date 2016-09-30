---
title: "bitset::operator^="
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
  - "bitset/std::bitset::operator^="
  - "bitset.operator^="
  - "std.bitset.operator^="
  - "std::bitset::operator^="
  - "^="
  - "operator^="
  - "bitset::operator^="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "^= operator, with specific standard C++ objects"
  - "operator^="
ms.assetid: e961c4aa-6a17-4117-b136-dbc5786aaf48
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator^=
Performs a bitwise combination of bitsets with the exclusive <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The bitset that is to be combined bitwise with the target bitset.  
  
## Return Value  
 The modified target bitset that results from the bitwise exclusive <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operation with the bitset specified as a parameter.  
  
## Remarks  
 Two bits combined by the exclusive **OR** operator return **true** if at least one, but not both, of the bits is **true**; otherwise, their combination returns **false**.  
  
 Bitsets must be of the same size to be combined bitwise with the exclusive <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator by the member operator function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The target bitset b1 is:    ( 00111 ).**  
**The parameter bitset b2 is: ( 01011 ).**  
**After bitwise exclusive OR combination,**  
 **the target bitset b1 becomes:   ( 01100 ).**  
**The parameter bitset b2 remains: ( 01011 ).**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)