---
title: "char_traits::eof"
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
  - "std.char_traits.eof"
  - "char_traits.eof"
  - "std::char_traits::eof"
  - "EOF"
  - "iosfwd/std::char_traits::eof"
  - "char_traits::eof"
  - "eof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "eof method"
ms.assetid: 3eef7544-48e4-49c0-9501-d3c5a8e43a70
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::eof
Returns the end-of-file (EOF) character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The EOF character.  
  
## Remarks  
 A value that represents end of file (such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 The C++ standard states that this value must not correspond to a valid <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value. The Visual C++ compiler enforces this constraint for type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, but not for type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The example below demonstrates this.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **char_type ch1 is 'x' and corresponds to int_type 120.**  
**The eof marker for char_traits\<char> is: -1**  
**The eof marker for char_traits\<wchar_t> is: 65535**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)