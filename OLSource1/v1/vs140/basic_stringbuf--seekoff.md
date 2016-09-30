---
title: "basic_stringbuf::seekoff"
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
  - "seekoff"
  - "std::basic_stringbuf::seekoff"
  - "sstream/std::basic_stringbuf::seekoff"
  - "basic_stringbuf.seekoff"
  - "basic_stringbuf::seekoff"
  - "std.basic_stringbuf.seekoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekoff method"
ms.assetid: a71a1788-8d82-4abe-9951-90335dc45266
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::seekoff
The protected virtual member function tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [basic_stringbuf::off_type](../vs140/basic_stringbuf--off_type.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [ios_base::seekdir](../vs140/ios_base--seekdir.md) for possible values.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions. For more information, see [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
## Return Value  
 Returns the new position or an invalid stream position.  
  
## Remarks  
 For an object of class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence.  
  
 The new position is determined as follows:  
  
-   If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the new position is the beginning of the stream plus <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the new position is the current stream position plus <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the new position is the end of the stream plus <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is nonzero, the function alters the next position to read in the input buffer. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is nonzero, the function alters the next position to write in the output buffer. For a stream to be affected, its buffer must exist. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence. If the function affects both stream positions, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and both streams are positioned at the same element. Otherwise (or if neither position is affected), the positioning operation fails.  
  
 If the function succeeds in altering either or both of the stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)