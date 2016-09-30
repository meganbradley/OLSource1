---
title: "unbounded_buffer::propagate_message Method"
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
  - "agents/concurrency::unbounded_buffer::propagate_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate_message method"
ms.assetid: 86efdec5-ae51-4276-a400-84d8a7576291
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::propagate_message Method
Asynchronously passes a message from an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block to this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> messaging block. It is invoked by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, when called by a source block.  
  
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
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)