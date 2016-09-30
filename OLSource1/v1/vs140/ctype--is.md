---
title: "ctype::is"
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
  - "ctype::is"
  - "ctype.is"
  - "std::ctype::is"
  - "is"
  - "xlocale/std::ctype::is"
  - "std.ctype.is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is method"
ms.assetid: 4aaf34d9-55b5-4fe2-b6d1-116dc1753e63
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ctype::is
Tests whether a single character has a particular attribute or classifies the attributes of each character in a range and stores them in an array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The mask value for which the character is to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character whose attributes are to be tested.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the first character in the range whose attributes are to be classified.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range whose attributes are to be classified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the beginning of the array where the mask values characterizing the attributes of each of the characters are to be stored.  
  
## Return Value  
 The first member function returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the character tested has the attribute described by the mask value; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if it fails to have the attribute.  
  
 The second member function returns a pointer to the last character in the range whose attributes are to be classified.  
  
## Remarks  
 The mask values classifying the attributes of the characters are provided by the class [ctype_base Class](../vs140/ctype_base-class.md), from which ctype derives. The first member function can accept expressions for its first parameter referred to as bitmasks and formed from the combination of mask values by the logical bitwise operators (&#124; , & , ^ , ~).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)