---
title: "CMDIFrameWndEx::OnCmdMsg"
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
  - "OnCmdMsg"
  - "CMDIFrameWndEx.OnCmdMsg"
  - "CMDIFrameWndEx::OnCmdMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCmdMsg method"
ms.assetid: b06a1feb-d287-464e-b147-692577b2fc8c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnCmdMsg
Called by the framework to route and dispatch command messages and to update command user-interface objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the command notification code. See [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md) for more information about values for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Used according to the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. See [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md) for more information about <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in, out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Typically, this parameter should be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.If not <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fills in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> members of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure instead of dispatching the command.  
  
## Return Value  
 Nonzero if the message is handled; otherwise 0.  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md)