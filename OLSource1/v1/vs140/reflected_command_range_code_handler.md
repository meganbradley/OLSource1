---
title: "REFLECTED_COMMAND_RANGE_CODE_HANDLER"
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
  - "REFLECTED_COMMAND_RANGE_CODE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REFLECTED_COMMAND_RANGE_CODE_HANDLER macro"
ms.assetid: e79c5116-bf24-485b-900b-620b06aad1a5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REFLECTED_COMMAND_RANGE_CODE_HANDLER
Similar to [COMMAND_RANGE_CODE_HANDLER](../vs140/command_range_code_handler.md), but maps commands reflected from the parent window.  
  
## Syntax  
  
```  
  
      REFLECTED_COMMAND_RANGE_CODE_HANDLER(   
   idFirst,   
   idLast,   
   code,   
   func    
)  
```  
  
#### Parameters  
 `idFirst`  
 [in] Marks the beginning of a contiguous range of control identifiers.  
  
 `idLast`  
 [in] Marks the end of a contiguous range of control identifiers.  
  
 `code`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [REFLECT_NOTIFICATIONS](../vs140/reflect_notifications.md)