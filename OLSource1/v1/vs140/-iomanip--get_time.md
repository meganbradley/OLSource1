---
title: "&lt;iomanip&gt; get_time"
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
  - "std.get_time"
  - "std::get_time"
  - "iomanip/std::get_time"
  - "get_time"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_time function"
ms.assetid: f8156da8-0e16-4515-b95f-e5007ec81d05
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; get_time
Extracts a time value from a stream using a desired format. Returns the value in a parameter as a time structure.  
  
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
 The time in the form of a time structure.  
  
 `_Fmt`  
 The desired format to use to obtain the time value.  
  
## Property Value/Return Value  
 The function return value is the stream `str`.  
  
## Exceptions  
  
## Remarks  
 The manipulator returns an object that, when extracted from the stream `str`, behaves as a `formatted input function` that calls the member function `get` for the locale facet `time_get` associated with `str`, using `tptr` to indicate the time structure and `fmt` to indicate the beginning of a null-terminated format string. If successful, the call stores in the time structure the values associated with any extracted time fields. The manipulator then returns `str`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [<iomanip\>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)