---
title: "ostrstream::ostrstream"
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
  - "ostrstream"
  - "std.ostrstream.ostrstream"
  - "ostrstream.ostrstream"
  - "std::ostrstream::ostrstream"
  - "ostrstream::ostrstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostrstream method"
  - "ostrstream class, constructor"
ms.assetid: 40712f12-47db-4353-9b8f-e2ca7169e8da
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostrstream::ostrstream
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The buffer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the buffer in bytes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The input and output mode of the buffer. See [ios_base::openmode](../vs140/ios_base--openmode.md) for more information.  
  
## Remarks  
 Both constructors initialize the base class by calling [ostream](../vs140/ostream.md)(**sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first constructor also initializes **sb** by calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The second constructor initializes the base class one of two ways:  
  
-   If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> & **ios_base::app**== 0, then <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must designate the first element of an array of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements, and the constructor calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
-   Otherwise, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must designate the first element of an array of count elements that contains a C string whose first element is designated by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and the constructor calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) ).  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [ostrstream Class](../vs140/ostrstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)