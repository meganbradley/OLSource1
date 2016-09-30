---
title: "asend Function"
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
  - "agents/concurrency::asend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "asend function"
ms.assetid: 920dc665-7e23-4bd7-8c74-3e74067aa52a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# asend Function
An asynchronous send operation, which schedules a task to propagate the data to the target block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the data to be sent.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer or reference to the target to which data is sent.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to the data to be sent.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the message was accepted before the method returned, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 For more information, see [Message Passing Functions](../vs140/message-passing-functions.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [receive Function](../vs140/receive-function.md)   
 [try_receive Function](../vs140/try_receive-function.md)   
 [send Function](../vs140/send-function.md)