---
title: "REFLECTED_NOTIFY_HANDLER"
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
  - "REFLECTED_NOTIFY_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REFLECTED_NOTIFY_HANDLER macro"
ms.assetid: 63f6d120-4ed1-408e-b7c4-4eeff07bf5e1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REFLECTED_NOTIFY_HANDLER
Similar to [NOTIFY_HANDLER](../VS_csharp/notify_handler.md), but maps notifications reflected from the parent window.  
  
## Syntax  
  
```  
  
      REFLECTED_NOTIFY_HANDLER(   
   id,   
   cd,   
   func    
)  
```  
  
#### Parameters  
 `id`  
 [in] The identifier of the menu item, control, or accelerator.  
  
 `cd`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [REFLECT_NOTIFICATIONS](../VS_csharp/reflect_notifications.md)