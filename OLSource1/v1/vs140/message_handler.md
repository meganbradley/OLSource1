---
title: "MESSAGE_HANDLER"
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
  - "MESSAGE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MESSAGE_HANDLER macro"
ms.assetid: 0253a7f3-7eb3-4d2d-83b9-060161268d04
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MESSAGE_HANDLER
Defines an entry in a message map.  
  
## Syntax  
  
```  
  
      MESSAGE_HANDLER(   
   msg,   
   func    
)  
```  
  
#### Parameters  
 `msg`  
 [in] The Windows message.  
  
 `func`  
 [in] The name of the message-handler function.  
  
## Remarks  
 `MESSAGE_HANDLER` maps a Windows message to the specified handler function.  
  
 Any function specified in a `MESSAGE_HANDLER` macro must be defined as follows:  
  
 `LRESULT MessageHandler(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled);`  
  
 The message map sets `bHandled` to **TRUE** before `MessageHandler` is called. If `MessageHandler` does not fully handle the message, it should set `bHandled` to **FALSE** to indicate the message needs further processing.  
  
> [!NOTE]
>  Always begin a message map with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). You can then declare subsequent alternate message maps with [ALT_MSG_MAP](../vs140/alt_msg_map.md). The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 In addition to `MESSAGE_HANDLER`, you can use [COMMAND_HANDLER](../vs140/command_handler.md) and [NOTIFY_HANDLER](../vs140/notify_handler.md) to map [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) and [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) messages, respectively.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#129](../vs140/codesnippet/CPP/message_handler_1.h)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [MESSAGE_RANGE_HANDLER](../vs140/message_range_handler.md)