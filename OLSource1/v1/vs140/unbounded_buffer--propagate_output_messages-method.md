---
title: "unbounded_buffer::propagate_output_messages Method"
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
  - "agents/concurrency::unbounded_buffer::propagate_output_messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate_output_messages method"
ms.assetid: b4151a7e-105d-4761-a542-aaf641c527d5
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::propagate_output_messages Method
Places the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> messaging block and tries to offer it to all of the linked targets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If another message is already ahead of this one in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, propagation to linked targets will not occur until any earlier messages have been accepted or consumed. The first linked target to successfully <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> the message takes ownership, and no other target can then get the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)