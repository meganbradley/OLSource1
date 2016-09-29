---
title: "CommandHandler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CommandHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommandHandler function"
ms.assetid: 662bc7bf-4a10-42b3-986d-d8bae4f63551
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CommandHandler
`CommandHandler` is the function identified by the third parameter of the `COMMAND_HANDLER` macro in your message map.  
  
## Syntax  
  
```  
  
      LRESULT   
      CommandHandler  
      (  
   WORD wNotifyCode,  
   WORD wID,  
   HWND hWndCtl,  
   BOOL& bHandled   
);  
```  
  
#### Parameters  
 `wNotifyCode`  
 The notification code.  
  
 *wID*  
 The identifier of the menu item, control, or accelerator.  
  
 *hWndCtl*  
 A handle to a window control.  
  
 `bHandled`  
 The message map sets `bHandled` to **TRUE** before `CommandHandler` is called. If `CommandHandler` does not fully handle the message, it should set `bHandled` to **FALSE** to indicate the message needs further processing.  
  
## Return Value  
 The result of message processing. 0 if successful.  
  
## Remarks  
 For an example of using this message handler in a message map, see [COMMAND_HANDLER](../VS_csharp/command_handler.md).  
  
## See Also  
 [Implementing a Window](../VS_csharp/implementing-a-window.md)   
 [Message Maps](../VS_csharp/message-maps--atl-.md)   
 [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583)