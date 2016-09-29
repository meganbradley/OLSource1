---
title: "CFrameWndEx::OnCmdMsg"
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
  - "CFrameWndEx::OnCmdMsg"
  - "OnCmdMsg"
  - "CFrameWndEx.OnCmdMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCmdMsg method"
ms.assetid: 693915b6-c493-4af2-9cf0-5997777e7e46
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnCmdMsg
Dispatches command messages.  
  
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
 Command message category.  
  
 [in, out] `pExtra`  
 Pointer to a command object.  
  
 [in, out] `pHandlerInfo`  
 Pointer to a command handler structure.  
  
## Return Value  
 `TRUE` if the command message was handled; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)