---
title: "REFLECTED_COMMAND_HANDLER"
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
  - "REFLECTED_COMMAND_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REFLECTED_COMMAND_HANDLER macro"
ms.assetid: c13aff85-1ca6-4523-95b0-12c9c71faaa0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REFLECTED_COMMAND_HANDLER
Similar to [COMMAND_HANDLER](../VS_csharp/command_handler.md), but maps commands reflected from the parent window.  
  
## Syntax  
  
```  
  
      REFLECTED_COMMAND_HANDLER(   
   id,   
   code,   
   func    
)  
```  
  
#### Parameters  
 `id`  
 [in] The identifier of the menu item, control, or accelerator.  
  
 `code`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [REFLECT_NOTIFICATIONS](../VS_csharp/reflect_notifications.md)