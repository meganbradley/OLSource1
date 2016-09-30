---
title: "char_traits::_Copy_s"
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
  - "std.char_traits._Copy_s"
  - "iosfwd/std::char_traits::_Copy_s"
  - "char_traits._Copy_s"
  - "std::char_traits::_Copy_s"
  - "char_traits::_Copy_s"
  - "_Copy_s"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Copy_s method"
ms.assetid: 10dedcb9-47b3-4f48-b641-ff1e1396e783
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::_Copy_s
Copies a specified number of characters from one string to another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then this size is in bytes. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, then this size is in words.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The source string or character array to be copied.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The number of elements to be copied.  
  
## Return Value  
 The string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination character sequences must not overlap.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The source string is: abcd-1234-abcd**  
**The destination string is: ABCD-1234**  
**The result1 = _Copy_s(s1, char_traits\<char>::length(s1), s2, 4) is: ABCD-1234-abcd**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)   
 [Safe Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)