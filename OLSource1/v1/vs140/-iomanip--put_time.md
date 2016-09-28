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
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; put_time
Writes a time value from a time structure to a stream by using a specified format.  
  
## Syntax  
  
```  
template<class Elem>  
    T10 put_time(  
        struct tm *_Tptr,   
        const Elem *_Fmt  
);  
```  
  
#### Parameters  
 `_Tptr`  
 The time value to write to the stream, provided in a time structure.  
  
 `_Fmt`  
 The desired format to write the time value.  
  
## Property Value/Return Value  
 Returns the stream `str`.  
  
## Remarks  
 The manipulator returns an object that, when inserted into the stream `str`, behaves as a `formatted output function`. The output function calls the member function `put` for the locale facet `time_put` associated with `str`. The output function uses `_Tptr` to indicate the time structure and `_Fmt` to indicate the beginning of a NUL-terminated format string. If successful, the call inserts literal text from the format string and converted values from the time structure. The manipulator then returns `str`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [<iomanip\>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)