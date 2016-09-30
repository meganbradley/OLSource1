---
title: "bitset::operator&lt;&lt;"
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
  - "bitset/std::bitset::operator<<"
  - "bitset::operator<<"
  - "<<"
  - "std::bitset::operator<<"
  - "operator<<"
  - "bitset.operator<<"
  - "std.bitset.operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<< operator"
  - "<< operator, with specific objects"
  - "operator <<, bitsets"
  - "operator<<, bitsets"
ms.assetid: 64fe0256-6054-4ed7-8dc6-4f11753de664
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::operator&lt;&lt;
Shifts the bits in a bitset to the left a specified number of positions and returns the result to a new bitset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of positions to the left that the bits in the bitset are to be shifted.  
  
## Return Value  
 The modified bitset with the bits shifted to the left the required number of positions.  
  
## Remarks  
 The member operator function returns **bitset**(**\*this**) **<<= pos,** where [<<=](../vs140/bitset--operator--=.md) shifts the bits in a bitset to the left a specified number of positions and returns the result to the targeted bitset.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)