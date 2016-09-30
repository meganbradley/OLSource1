---
title: "ITarget::send Method"
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
  - "agents/concurrency::ITarget::send"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send method"
ms.assetid: 8730c491-4780-487d-b21d-2a7348972b41
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITarget::send Method
When overridden in a derived class, synchronously passes a message to the target block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
## Return Value  
 A [message_status](../vs140/message_status-enumeration.md) indication of what the target decided to do with the message.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if either the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method outside of message initiation and to propagate messages within a network is dangerous and can lead to deadlock.  
  
 When <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns, the message has either already been accepted, and transferred into the target block, or it has been declined by the target.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITarget Class](../vs140/itarget-class.md)