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
  
```  
virtual BOOL OnCmdMsg(  
   UINT nID,  
   int nCode,  
   void* pExtra,  
   AFX_CMDHANDLERINFO* pHandlerInfo  
);  
```  
  
#### Parameters  
 [in] `nID`  
 The command ID.  
  
 [in] `nCode`  
 Identifies the command notification code. See [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md) for more information about values for `nCode`.  
  
 [in] `pExtra`  
 Used according to the value of `nCode`. See [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md) for more information about `pExtra`.  
  
 [in, out] `pHandlerInfo`  
 Typically, this parameter should be `NULL`.If not `NULL`, `OnCmdMsg` fills in the `pTarget` and `pmf` members of the `pHandlerInfo` structure instead of dispatching the command.  
  
## Return Value  
 Nonzero if the message is handled; otherwise 0.  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md)