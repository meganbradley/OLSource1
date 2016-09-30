---
title: "single_assignment::send_message Method"
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
  - "agents/concurrency::single_assignment::send_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send_message method"
ms.assetid: eefb7a50-a8bf-4e99-9d69-74bcccbf154a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::send_message Method
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
 [single_assignment Class](../vs140/single_assignment-class.md)