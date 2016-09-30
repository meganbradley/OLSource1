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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The time in the form of a time structure.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The desired format to use to obtain the time value.  
  
## Property Value/Return Value  
 The function return value is the stream <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Exceptions  
  
## Remarks  
 The manipulator returns an object that, when extracted from the stream <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, behaves as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that calls the member function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to indicate the time structure and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to indicate the beginning of a null-terminated format string. If successful, the call stores in the time structure the values associated with any extracted time fields. The manipulator then returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [\<iomanip>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)