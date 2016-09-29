---
title: "COMMAND_HANDLER"
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
  - "COMMAND_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COMMAND_HANDLER macro"
ms.assetid: 7b53ffe3-be95-43f7-a21a-dc9516a19f2a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COMMAND_HANDLER
Defines an entry in a message map.  
  
## Syntax  
  
```  
  
COMMAND_HANDLER(   
id  
,   
code  
,   
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
  
## Remarks  
 `COMMAND_HANDLER` maps a [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message to the specified handler function, based on the notification code and the control identifier. For example:  
  
 [!code[NVC_ATL_Windowing#119](../vs140/codesnippet/CPP/command_handler_1.h)]  
  
 Any function specified in a `COMMAND_HANDLER` macro must be defined as follows:  
  
 `LRESULT CommandHandler(WORD wNotifyCode, WORD wID, HWND hWndCtl, BOOL& bHandled);`  
  
 The message map sets `bHandled` to **TRUE** before `CommandHandler` is called. If `CommandHandler` does not fully handle the message, it should set `bHandled` to **FALSE** to indicate the message needs further processing.  
  
> [!NOTE]
>  Always begin a message map with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). You can then declare subsequent alternate message maps with [ALT_MSG_MAP](../vs140/alt_msg_map.md). The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 In addition to `COMMAND_HANDLER`, you can use [MESSAGE_HANDLER](../vs140/message_handler.md) to map a **WM_COMMAND** message without regard to an identifier or code. In this case, `MESSAGE_HANDLER(WM_COMMAND, OnHandlerFunction)` will direct all **WM_COMMAND** messages to `OnHandlerFunction`.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [COMMAND_ID_HANDLER](../vs140/command_id_handler.md)   
 [COMMAND_CODE_HANDLER](../vs140/command_code_handler.md)   
 [COMMAND_RANGE_HANDLER](../vs140/command_range_handler.md)   
 [NOTIFY_HANDLER](../vs140/notify_handler.md)