---
title: "receive Function"
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
  - "agents/concurrency::receive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "receive function"
ms.assetid: f36bbca1-97ac-4343-bfac-ea71ca2139e9
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# receive Function
A general receive implementation, allowing a context to wait for data from exactly one source and filter the values that are accepted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The payload type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer or reference to the source from which data is expected.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The maximum time for which the method should for the data, in milliseconds.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A filter function which determines whether messages should be accepted.  
  
## Return Value  
 A value from the source, of the payload type.  
  
## Remarks  
 If the parameter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has a value other than the constant <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the exception [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before a message is received. If you want a zero length timeout, you should use the [try_receive](../vs140/try_receive-function.md) function, as opposed to calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with a timeout of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (zero), as it is more efficient and does not throw exceptions on timeouts.  
  
 For more information, see [Message Passing Functions](../vs140/message-passing-functions.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [try_receive Function](../vs140/try_receive-function.md)   
 [send Function](../vs140/send-function.md)   
 [asend Function](../vs140/asend-function.md)