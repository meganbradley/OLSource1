---
title: "char_traits::not_eof"
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
  - "char_traits::not_eof"
  - "iosfwd/std::char_traits::not_eof"
  - "std::char_traits::not_eof"
  - "std.char_traits.not_eof"
  - "char_traits.not_eof"
  - "not_eof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not_eof method"
ms.assetid: cd1bacdf-004e-401d-91ed-c736cfd20131
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::not_eof
Tests whether a character is not the end-of-file (EOF) character or is the EOF.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character represented as an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be tested for whether it is the EOF character or not.  
  
## Return Value  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> representation of the character tested, if the **int_type** of the character is not equal to that of the EOF character.  
  
 If the character <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value is equal to the EOF <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value, then **false**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The char_type ch1 is x corresponding to int_type: 120.**  
**The eofReturn is: -1**  
**The eofTest1 returns: 120, which is the character: x.**  
**The eofTest2 indicates int2 is an EOF character.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)