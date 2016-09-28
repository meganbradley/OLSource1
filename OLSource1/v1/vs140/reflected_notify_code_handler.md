---
title: "REFLECTED_NOTIFY_CODE_HANDLER"
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
  - "REFLECTED_NOTIFY_CODE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REFLECTED_NOTIFY_CODE_HANDLER macro"
ms.assetid: 09c99999-013b-4893-b349-014c790118a4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REFLECTED_NOTIFY_CODE_HANDLER
Similar to [NOTIFY_CODE_HANDLER](../vs140/notify_code_handler.md), but maps notifications reflected from the parent window.  
  
## Syntax  
  
```  
  
      REFLECTED_NOTIFY_CODE_HANDLER_EX(   
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
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [REFLECT_NOTIFICATIONS](../vs140/reflect_notifications.md)