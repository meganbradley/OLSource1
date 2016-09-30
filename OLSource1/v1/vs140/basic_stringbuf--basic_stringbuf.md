---
title: "basic_stringbuf::basic_stringbuf"
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
  - "basic_stringbuf::basic_stringbuf"
  - "basic_stringbuf"
  - "basic_stringbuf.basic_stringbuf"
  - "std::basic_stringbuf::basic_stringbuf"
  - "std.basic_stringbuf.basic_stringbuf"
  - "sstream/std::basic_stringbuf::basic_stringbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_stringbuf method"
  - "basic_stringbuf class, constructor"
ms.assetid: f722b3a2-5bfe-42a1-9a9a-7e0a2709dcca
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::basic_stringbuf
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type [basic_string](../vs140/basic_string-class.md).  
  
## Remarks  
 The first constructor stores a null pointer in all the pointers controlling the input buffer and the output buffer. For more information, see the Remarks section of the [basic_streambuf Class](../vs140/basic_streambuf-class.md). It also stores <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as the stringbuf mode. For more information, see the Remarks section of the [basic_stringbuf Class](../vs140/basic_stringbuf-class.md).  
  
 The second constructor allocates a copy of the sequence controlled by the string object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is nonzero, it sets the input buffer to start reading at the start of the sequence. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is nonzero, it sets the output buffer to begin writing at the start of the sequence. It also stores <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as the stringbuf mode. For more information, see the Remarks section of the [basic_stringbuf Class](../vs140/basic_stringbuf-class.md).  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)