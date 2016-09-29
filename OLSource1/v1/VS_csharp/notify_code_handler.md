---
title: "NOTIFY_CODE_HANDLER"
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
  - "NOTIFY_CODE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NOTIFY_CODE_HANDLER macro"
ms.assetid: 27fba5ac-b38a-4d50-bf51-ddaadb2bddad
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NOTIFY_CODE_HANDLER
Similar to [NOTIFY_HANDLER](../VS_csharp/notify_handler.md), but maps a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message based only on the notification code.  
  
## Syntax  
  
```  
  
      NOTIFY_CODE_HANDLER(   
   cd,   
   func    
)  
```  
  
#### Parameters  
 `cd`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [NOTIFY_ID_HANDLER](../VS_csharp/notify_id_handler.md)   
 [REFLECTED_NOTIFY_CODE_HANDLER](../VS_csharp/reflected_notify_code_handler.md)   
 [NOTIFY_RANGE_HANDLER](../VS_csharp/notify_range_handler.md)   
 [COMMAND_CODE_HANDLER](../VS_csharp/command_code_handler.md)   
 [MESSAGE_HANDLER](../VS_csharp/message_handler.md)