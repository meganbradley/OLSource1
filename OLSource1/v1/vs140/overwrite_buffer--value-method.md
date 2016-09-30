---
title: "overwrite_buffer::value Method"
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
  - "agents/concurrency::overwrite_buffer::value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value method"
ms.assetid: 2a79b222-65e5-40ce-8ded-85e25ab07f22
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overwrite_buffer::value Method
Gets a reference to the current payload of the message being stored in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The payload of the currently stored message.  
  
## Remarks  
 The value stored in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> could change immediately after this method returns. This method will wait until a message arrives if no message is currently stored in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)