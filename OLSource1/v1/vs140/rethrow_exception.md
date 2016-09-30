---
title: "rethrow_exception"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 63cd325d-7585-4f6e-b2ba-a10ae397927b
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rethrow_exception
Throws an exception passed as a parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The caught exception to re-throw. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a null [exception_ptr](../vs140/exception_ptr.md), the function throws [std::bad_exception](../vs140/bad_exception-class.md).  
  
## Remarks  
 After you store a caught exception in an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, the primary thread can process the object. In your primary thread, call the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function together with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object as its argument. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function extracts the exception from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object and then throws the exception in the context of the primary thread.  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [Transporting Exceptions Between Threads](../vs140/transporting-exceptions-between-threads.md)