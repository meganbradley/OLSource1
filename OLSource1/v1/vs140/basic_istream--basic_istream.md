---
title: "basic_istream::basic_istream"
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
  - "std.basic_istream.basic_istream"
  - "std::basic_istream::basic_istream"
  - "basic_istream"
  - "istream/std::basic_istream::basic_istream"
  - "basic_istream::basic_istream"
  - "basic_istream.basic_istream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_istream method"
  - "basic_istream class, constructor"
ms.assetid: a1f01901-77b9-4279-833a-5333a3c2ee81
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::basic_istream
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type [basic_streambuf](../vs140/basic_streambuf-class.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this is a standard stream; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to copy.  
  
## Remarks  
 The first constructor initializes the base class by calling [init](../vs140/basic_ios--init.md)(_S<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). It also stores zero in the extraction count. For more information about this extraction count, see the Remarks section of the [basic_istream Class](../vs140/basic_istream-class.md) overview topic.  
  
 The second constructor initializes the base class by calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. It also stores _R<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the extraction count and stores zero in the extraction count for _R<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [basic_ifstream::basic_ifstream](../vs140/basic_ifstream--basic_ifstream.md) to learn more about input streams.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)