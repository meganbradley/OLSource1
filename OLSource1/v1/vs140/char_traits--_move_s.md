---
title: "char_traits::_Move_s"
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
  - "std.char_traits._Move_s"
  - "_Move_s"
  - "string/std::char_traits::_Move_s"
  - "std::char_traits::_Move_s"
  - "char_traits::_Move_s"
  - "char_traits._Move_s"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Move_s method"
ms.assetid: 6c0d3731-c4d3-453e-b710-c696774808e1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::_Move_s
Copies a specified number of characters in a sequence to another, possibly overlapping sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then this is in bytes. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, then this is in words.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The element at the beginning of the source string or character array to be copied.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The number of elements to be copied from the source string.  
  
## Return Value  
 The first element <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> copied into the string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination may overlap.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The source string sFrom1 is: abcd-1234-abcd**  
**The destination stringsTo1 is: ABCD-1234**  
**The result1 = _Move_s(sTo1, char_traits\<char>::length(sTo1), sFrom1, 4) is: abcd-1234**  
**The source/destination string sToFrom2 is: abcd-1234-ABCD**  
**The result2 = _Move_s(sToFrom2, char_traits\<char>::length(sToFrom2), findc, 8) is: cd-1234-4-ABCD**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)   
 [Safe Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)