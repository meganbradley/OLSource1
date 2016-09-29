---
title: "NOTIFY_RANGE_CODE_HANDLER"
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
  - "NOTIFY_RANGE_CODE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NOTIFY_RANGE_CODE_HANDLER macro"
ms.assetid: 1be5b189-408b-41e5-8958-441e41c6eff8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NOTIFY_RANGE_CODE_HANDLER
Similar to [NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md), but maps [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) messages with a specific notification code from a range of controls to a single handler function.  
  
## Syntax  
  
```  
  
      NOTIFY_RANGE_CODE_HANDLER(   
   idFirst,   
   idLast,   
   cd,   
   func    
)  
```  
  
#### Parameters  
 `idFirst`  
 [in] Marks the beginning of a contiguous range of control identifiers.  
  
 `idLast`  
 [in] Marks the end of a contiguous range of control identifiers.  
  
 `cd`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Remarks  
 This range is based on the identifier of the control sending the message.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [NOTIFY_ID_HANDLER](../vs140/notify_id_handler.md)   
 [NOTIFY_CODE_HANDLER](../vs140/notify_code_handler.md)   
 [REFLECTED_NOTIFY_CODE_HANDLER](../vs140/reflected_notify_code_handler.md)   
 [COMMAND_RANGE_HANDLER](../vs140/command_range_handler.md)   
 [MESSAGE_RANGE_HANDLER](../vs140/message_range_handler.md)