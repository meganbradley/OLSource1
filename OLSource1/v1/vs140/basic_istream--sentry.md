---
title: "basic_istream::sentry"
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
  - "istream/std::basic_istream::sentry"
  - "basic_istream.sentry"
  - "std.basic_istream.sentry"
  - "std::basic_istream::sentry"
  - "sentry"
  - "basic_istream::sentry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sentry method"
ms.assetid: 762cdb42-4365-470f-8db8-4524eca40ba7
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::sentry
The nested class describes an object whose declaration structures the formatted and unformatted input functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>[good](../vs140/basic_ios--good.md) is true, the constructor:  
  
-   Calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.[tie](../vs140/basic_ios--tie.md) -> [flush](../vs140/basic_ostream--flush.md) if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not a null pointer  
  
-   Effectively calls [ws](../vs140/ws.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.[flags](../vs140/ios_base--flags.md) **&** [skipws](../vs140/skipws.md) is nonzero  
  
 If, after any such preparation, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**good** is false, the constructor calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the constructor stores the value returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.**good** in **status**. A later call to **operator bool** delivers this stored value.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)