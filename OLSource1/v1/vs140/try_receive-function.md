---
title: "try_receive Function"
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
  - "agents/concurrency::try_receive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try_receive function"
ms.assetid: c9d76668-e5cf-48de-ab79-bd7b2bc38db9
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try_receive Function
A general try-receive implementation, allowing a context to look for data from exactly one source and filter the values that are accepted. If the data is not ready, the method will return false.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The payload type  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer or reference to the source from which data is expected.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a location where the result will be placed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A filter function which determines whether messages should be accepted.  
  
## Return Value  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value indicating whether or not a payload was placed in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 For more information, see [Message Passing Functions](../vs140/message-passing-functions.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [receive Function](../vs140/receive-function.md)   
 [send Function](../vs140/send-function.md)   
 [asend Function](../vs140/asend-function.md)