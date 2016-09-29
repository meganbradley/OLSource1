---
title: "COMMAND_CODE_HANDLER"
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
  - "COMMAND_CODE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COMMAND_CODE_HANDLER macro"
ms.assetid: c136a0a8-2a40-4063-a9a1-08ac90a10ac9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COMMAND_CODE_HANDLER
Similar to [COMMAND_HANDLER](../vs140/command_handler.md), but maps a [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message based only on the notification code.  
  
## Syntax  
  
```  
  
COMMAND_CODE_HANDLER(   
code  
,   
func  
 )  
  
```  
  
#### Parameters  
 `code`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [COMMAND_ID_HANDLER](../vs140/command_id_handler.md)   
 [COMMAND_RANGE_HANDLER](../vs140/command_range_handler.md)   
 [MESSAGE_HANDLER](../vs140/message_handler.md)   
 [NOTIFY_CODE_HANDLER](../vs140/notify_code_handler.md)