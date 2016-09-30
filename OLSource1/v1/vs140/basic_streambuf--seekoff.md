---
title: "basic_streambuf::seekoff"
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
  - "basic_streambuf::seekoff"
  - "streambuf/std::basic_streambuf::seekoff"
  - "std::basic_streambuf::seekoff"
  - "std.basic_streambuf.seekoff"
  - "basic_streambuf.seekoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekoff method"
ms.assetid: 0b5dbbd5-3442-46a3-a429-01bab3151344
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::seekoff
A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [seekdir](../vs140/ios_base--seekdir.md) for possible values.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 Returns the new position or an invalid stream position ( <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (_*Off*, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) ).  
  
## Remarks  
 The new position is determined as follows:  
  
-   If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the new position is the beginning of the stream plus _*Off*.  
  
-   If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the new position is the current stream position plus _*Off*.  
  
-   If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the new position is the end of the stream plus _*Off*.  
  
 Typically, if **which & ios_base::in** is nonzero, the input stream is affected, and if **which & ios_base::out** is nonzero, the output stream is affected. Actual use of this parameter varies among derived stream buffers, however.  
  
 If the function succeeds in altering the stream position or positions, it returns the resulting stream position or one of the resulting stream positions. Otherwise, it returns an invalid stream position. The default behavior is to return an invalid stream position.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)