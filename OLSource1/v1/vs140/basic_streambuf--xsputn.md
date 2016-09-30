---
title: "basic_streambuf::xsputn"
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
  - "xsputn"
  - "basic_streambuf::xsputn"
  - "std::basic_streambuf::xsputn"
  - "basic_streambuf.xsputn"
  - "streambuf/std::basic_streambuf::xsputn"
  - "std.basic_streambuf.xsputn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "xsputn method"
ms.assetid: af19c1ab-c406-420d-9eac-b3f04317709c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::xsputn
Protected, virtual function to insert elements into the output stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to elements to insert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of elements to insert.  
  
## Return Value  
 The number of elements actually inserted into the stream.  
  
## Remarks  
 The protected virtual member function inserts up to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements into the output stream, as if by repeated calls to [sputc](../vs140/basic_streambuf--sputc.md), from the array beginning at <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The insertion of characters into the output stream stops once all <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> characters have been written, or if calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> would return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. It returns the number of elements actually inserted.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)