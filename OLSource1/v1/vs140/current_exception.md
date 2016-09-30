---
title: "current_exception"
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
ms.assetid: 333180ce-73df-4343-9704-ab6c19c81fc2
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# current_exception
Obtains a smart pointer to the current exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An [exception_ptr](../vs140/exception_ptr.md) object pointing to the current exception.  
  
## Remarks  
 Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function in a catch block. If an exception is in flight and the catch block can catch the exception, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that references the exception. Otherwise, the function returns a null <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function captures the exception that is in flight regardless of whether the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement specifies an [exception-declaration](../vs140/try--throw--and-catch-statements--c---.md) statement.  
  
 The destructor for the current exception is called at the end of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block if you do not rethrow the exception. However, even if you call the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function in the destructor, the function returns an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object that references the current exception.  
  
 Successive calls to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects that refer to different copies of the current exception. Consequently, the objects compare as unequal because they refer to different copies, even though the copies have the same binary value.  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [Transporting Exceptions Between Threads](../vs140/transporting-exceptions-between-threads.md)