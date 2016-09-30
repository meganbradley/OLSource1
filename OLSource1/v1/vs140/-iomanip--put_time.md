---
title: "&lt;iomanip&gt; put_time"
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
  - "std::put_time"
  - "iomanip/std::put_time"
  - "put_time"
  - "std.put_time"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_time function"
ms.assetid: 9c71b1ea-82b1-40f4-bd62-4e8e1ec1123c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; put_time
Writes a time value from a time structure to a stream by using a specified format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The time value to write to the stream, provided in a time structure.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The desired format to write the time value.  
  
## Property Value/Return Value  
 Returns the stream <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The manipulator returns an object that, when inserted into the stream <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, behaves as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The output function calls the member function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The output function uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to indicate the time structure and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to indicate the beginning of a NUL-terminated format string. If successful, the call inserts literal text from the format string and converted values from the time structure. The manipulator then returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [\<iomanip>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)