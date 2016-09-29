---
title: "COMMAND_ID_HANDLER"
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
  - "COMMAND_ID_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COMMAND_ID_HANDLER macro"
ms.assetid: 608e202c-6cc9-4ab1-95ad-5678262e56d7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COMMAND_ID_HANDLER
Similar to [COMMAND_HANDLER](../VS_csharp/command_handler.md), but maps a [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message based only on the identifier of the menu item, control, or accelerator.  
  
## Syntax  
  
```  
  
COMMAND_ID_HANDLER(   
id  
,   
func  
 )  
  
```  
  
#### Parameters  
 `id`  
 [in] The identifier of the menu item, control, or accelerator sending the message.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [COMMAND_CODE_HANDLER](../VS_csharp/command_code_handler.md)   
 [COMMAND_RANGE_HANDLER](../VS_csharp/command_range_handler.md)   
 [MESSAGE_HANDLER](../VS_csharp/message_handler.md)   
 [NOTIFY_ID_HANDLER](../VS_csharp/notify_id_handler.md)