---
title: "CWnd::OnWndMsg"
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
  - "CWnd.OnWndMsg"
  - "OnWndMsg"
  - "CWnd::OnWndMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WindowProc messages"
  - "reflecting messages"
  - "message reflection"
  - "window messages"
  - "CWnd class, message reflection"
  - "OnWndMsg method"
  - "child windows, messages"
ms.assetid: ef25c1da-717e-4a5a-a4ee-8e49c9adddd9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnWndMsg
This member function is called by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, or is called during message reflection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the message to be sent.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies additional message-dependent information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies additional message-dependent information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The return value of [WindowProc](../vs140/cwnd--windowproc.md). Depends on the message; may be **NULL**.  
  
## Return Value  
 **TRUE** if message was handled; otherwise **FALSE**.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> determines the message type and either calls the appropriate framework function (for example, [OnCommand](../vs140/cwnd--oncommand.md) for **WM_COMMAND**) or finds the appropriate message in the message map.  
  
 For more information about message reflection, see [Handling Reflected Messages](../vs140/handling-reflected-messages.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnChildNotify](../vs140/cwnd--onchildnotify.md)   
 [CWnd::SendChildNotifyLastMsg](../vs140/cwnd--sendchildnotifylastmsg.md)   
 [CWnd::ReflectChildNotify](../vs140/cwnd--reflectchildnotify.md)   
 [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md)   
 [CWnd::ReflectLastMsg](../vs140/cwnd--reflectlastmsg.md)