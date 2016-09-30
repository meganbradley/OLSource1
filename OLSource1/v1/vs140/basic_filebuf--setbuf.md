---
title: "basic_filebuf::setbuf"
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
  - "setbuf"
  - "std.basic_filebuf.setbuf"
  - "std::basic_filebuf::setbuf"
  - "basic_filebuf.setbuf"
  - "fstream/std::basic_filebuf::setbuf"
  - "basic_filebuf::setbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setbuf method"
ms.assetid: 124c7ab2-33c2-4490-89cc-20b326080caf
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::setbuf
Performs an operation particular to each derived stream buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a buffer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Size of the buffer.  
  
## Return Value  
 The protected member function returns zero if the file pointer <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a null pointer.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>(**fp**, (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> \*)<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> \* <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (**Elem**) ) to offer the array of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements beginning at _*Buffer* as a buffer for the stream. If that function returns a nonzero value, the function returns a null pointer. Otherwise, it returns **this** to signal success.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)