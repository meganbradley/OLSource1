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
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is the function identified by the third parameter of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro in your message map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The notification code.  
  
 *wID*  
 The identifier of the menu item, control, or accelerator.  
  
 *hWndCtl*  
 A handle to a window control.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The message map sets <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to **TRUE** before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not fully handle the message, it should set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to **FALSE** to indicate the message needs further processing.  
  
## Return Value  
 The result of message processing. 0 if successful.  
  
## Remarks  
 For an example of using this message handler in a message map, see [COMMAND_HANDLER](../vs140/command_handler.md).  
  
## See Also  
 [Implementing a Window](../vs140/implementing-a-window.md)   
 [Message Maps](../vs140/message-maps--atl-.md)   
 [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583)