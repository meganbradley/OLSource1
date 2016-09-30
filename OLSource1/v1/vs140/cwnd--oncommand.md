---
title: "CWnd::OnCommand"
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
  - "CWnd.OnCommand"
  - "OnCommand"
  - "CWnd::OnCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCommand method"
ms.assetid: 478faf4d-728d-4bfb-bca1-76771aeb81ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnCommand
The framework calls this member function when the user selects an item from a menu, when a child control sends a notification message, or when an accelerator keystroke is translated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The low-order word of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> identifies the command ID of the menu item, control, or accelerator. The high-order word of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies the notification message if the message is from a control. If the message is from an accelerator, the high-order word is 1. If the message is from a menu, the high-order word is 0.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Identifies the control that sends the message if the message is from a control. Otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0.  
  
## Return Value  
 An application returns nonzero if it processes this message; otherwise 0.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> processes the message map for control notification and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> entries, and calls the appropriate member function.  
  
 Override this member function in your derived class to handle the [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message. An override will not process the message map unless the base class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is called.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591)   
 [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md)