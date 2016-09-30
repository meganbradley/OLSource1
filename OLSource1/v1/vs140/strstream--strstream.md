---
title: "strstream::strstream"
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
  - "strstream.strstream"
  - "strstream::strstream"
  - "std.strstream.strstream"
  - "std::strstream::strstream"
  - "strstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstream class, constructor"
  - "strstream method"
ms.assetid: 3cc2cb49-a017-458f-9810-3c73d009317a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstream::strstream
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of the buffer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The input and output mode of the buffer. See [ios_base::openmode](../vs140/ios_base--openmode.md) for more information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The buffer.  
  
## Remarks  
 Both constructors initialize the base class by calling [streambuf](../vs140/streambuf.md)(**sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first constructor also initializes **sb** by calling [strstreambuf](../vs140/strstreambuf--strstreambuf.md). The second constructor initializes the base class one of two ways:  
  
-   If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> & **ios_base::app**== 0, then <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must designate the first element of an array of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements, and the constructor calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
-   Otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must designate the first element of an array of count elements that contains a C string whose first element is designated by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and the constructor calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) ).  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstream Class](../vs140/strstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)