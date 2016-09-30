---
title: "basic_ostringstream::basic_ostringstream"
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
  - "basic_ostringstream.basic_ostringstream"
  - "basic_ostringstream::basic_ostringstream"
  - "std::basic_ostringstream::basic_ostringstream"
  - "sstream/std::basic_ostringstream::basic_ostringstream"
  - "basic_ostringstream"
  - "std.basic_ostringstream.basic_ostringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ostringstream method"
  - "basic_ostringstream class, constructor"
ms.assetid: e8c85a0a-0cc5-4395-8786-f754e3b65992
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostringstream::basic_ostringstream
Constructs an object of type basic_ostringstream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_ostream](../vs140/basic_ostream-class.md)(**sb**), where **sb** is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>>. It also initializes **sb** by calling basic_stringbuf<**Elem**, **Tr**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>>(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
 The second constructor initializes the base class by calling basic_ostream(**sb**). It also initializes **sb** by calling basic_stringbuf<**Elem**, **Tr**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>>(_*Str*, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostringstream Class](../vs140/basic_ostringstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)