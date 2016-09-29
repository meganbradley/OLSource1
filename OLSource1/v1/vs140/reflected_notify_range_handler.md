---
title: "REFLECTED_NOTIFY_RANGE_HANDLER"
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
  - "REFLECTED_NOTIFY_RANGE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REFLECTED_NOTIFY_RANGE_HANDLER macro"
ms.assetid: 306cfdb6-61fd-4207-a1bb-4064e7133fc8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REFLECTED_NOTIFY_RANGE_HANDLER
Similar to [NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md), but maps notifications reflected from the parent window.  
  
## Syntax  
  
```  
  
      REFLECTED_NOTIFY_RANGE_HANDLER(   
   idFirst,   
   idLast,   
   func    
)  
```  
  
#### Parameters  
 `idFirst`  
 [in] Marks the beginning of a contiguous range of control identifiers.  
  
 `idLast`  
 [in] Marks the end of a contiguous range of control identifiers.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [REFLECT_NOTIFICATIONS](../vs140/reflect_notifications.md)