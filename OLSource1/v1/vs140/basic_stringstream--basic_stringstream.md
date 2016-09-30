---
title: "basic_stringstream::basic_stringstream"
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
  - "std::basic_stringstream::basic_stringstream"
  - "basic_stringstream::basic_stringstream"
  - "basic_stringstream"
  - "std.basic_stringstream.basic_stringstream"
  - "sstream/std::basic_stringstream::basic_stringstream"
  - "basic_stringstream.basic_stringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_stringstream class, constructor"
  - "basic_stringstream method"
ms.assetid: 2ea524e7-62d5-480e-9ed8-972abed7b4c8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringstream::basic_stringstream
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_iostream](../vs140/basic_iostream-class.md)(**sb**), where **sb** is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>>. It also initializes **sb** by calling basic_stringbuf<**Elem**, **Tr**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>>(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
 The second constructor initializes the base class by calling basic_iostream(**sb**). It also initializes **sb** by calling basic_stringbuf<**Elem**, **Tr**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>>(_*Str*, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringstream Class](../vs140/basic_stringstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)