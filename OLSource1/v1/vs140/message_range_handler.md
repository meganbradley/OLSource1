---
title: "MESSAGE_RANGE_HANDLER"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "MESSAGE_RANGE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MESSAGE_RANGE_HANDLER macro"
ms.assetid: a8def99f-246d-497e-8749-0977cbf1934e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MESSAGE_RANGE_HANDLER
Similar to [MESSAGE_HANDLER](../vs140/message_handler.md), but maps a range of Windows messages to a single handler function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *msgFirst*  
 [in] Marks the beginning of a contiguous range of messages.  
  
 *msgLast*  
 [in] Marks the end of a contiguous range of messages.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [COMMAND_RANGE_HANDLER](../vs140/command_range_handler.md)   
 [NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md)