---
title: "REFLECTED_COMMAND_ID_HANDLER"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - REFLECTED_COMMAND_ID_HANDLER
dev_langs: 
  - C++
helpviewer_keywords: 
  - REFLECTED_COMMAND_ID_HANDLER macro
ms.assetid: 46332762-e6a8-4e92-bd72-74d6a51f6c62
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# REFLECTED_COMMAND_ID_HANDLER
Similar to [COMMAND_ID_HANDLER](../vs140/command_id_handler.md), but maps commands reflected from the parent window.  
  
## Syntax  
  
```  
  
      REFLECTED_COMMAND_ID_HANDLER(   
   id,   
   func    
)  
```  
  
#### Parameters  
 `id`  
 [in] The identifier of the menu item, control, or accelerator.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [REFLECT_NOTIFICATIONS](../vs140/reflect_notifications.md)