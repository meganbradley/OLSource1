---
title: "NOTIFY_HANDLER"
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
  - "NOTIFY_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NOTIFY_HANDLER macro"
ms.assetid: 0c546767-9683-45f9-9cbc-e243a7106790
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NOTIFY_HANDLER
Defines an entry in a message map.  
  
## Syntax  
  
```  
  
      NOTIFY_HANDLER(   
   id,   
   cd,   
   func    
)  
```  
  
#### Parameters  
 `id`  
 [in] The identifier of the control sending the message.  
  
 `cd`  
 [in] The notification code.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Remarks  
 `NOTIFY_HANDLER` maps a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message to the specified handler function, based on the notification code and the control identifier.  
  
 Any function specified in a `NOTIFY_HANDLER` macro must be defined as follows:  
  
 `LRESULT NotifyHandler(int idCtrl, LPNMHDR pnmh, BOOL& bHandled);`  
  
 The message map sets `bHandled` to **TRUE** before `NotifyHandler` is called. If `NotifyHandler` does not fully handle the message, it should set `bHandled` to **FALSE** to indicate the message needs further processing.  
  
> [!NOTE]
>  Always begin a message map with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). You can then declare subsequent alternate message maps with [ALT_MSG_MAP](../vs140/alt_msg_map.md). The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 In addition to `NOTIFY_HANDLER`, you can use [MESSAGE_HANDLER](../vs140/message_handler.md) to map a **WM_NOTIFY** message without regard to an identifier or code. In this case, `MESSAGE_HANDLER(WM_NOTIFY, OnHandlerFunction)` will direct all **WM_NOTIFY** messages to `OnHandlerFunction`.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#130](../vs140/codesnippet/CPP/notify_handler_1.h)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [NOTIFY_ID_HANDLER](../vs140/notify_id_handler.md)   
 [NOTIFY_CODE_HANDLER](../vs140/notify_code_handler.md)   
 [REFLECTED_NOTIFY_CODE_HANDLER](../vs140/reflected_notify_code_handler.md)   
 [NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md)   
 [COMMAND_HANDLER](../vs140/command_handler.md)