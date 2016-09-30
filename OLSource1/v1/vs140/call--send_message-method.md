---
title: "call::send_message Method"
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
  - "agents/concurrency::call::send_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send_message method"
ms.assetid: a4962f71-1c8a-4ed1-b9d7-19267ee0ae59
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call::send_message Method
Synchronously passes a message from an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block to this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> messaging block. It is invoked by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, when called by a source block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
## Return Value  
 A [message_status](../vs140/message_status-enumeration.md) indication of what the target decided to do with the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [call Class](../vs140/call-class.md)