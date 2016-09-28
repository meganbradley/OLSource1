---
title: "CFrameWndEx::OnActivate"
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
  - "CFrameWndEx::OnActivate"
  - "CFrameWndEx.OnActivate"
  - "OnActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivate method"
ms.assetid: 7f8b2712-a238-4a31-b263-c19a003134ce
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnActivate
The framework calls this method when user input is switched to or away from the frame.  
  
## Syntax  
  
```  
afx_msg void OnActivate(  
   UINT nState,  
   CWnd* pWndOther,  
   BOOL bMinimized  
);  
```  
  
#### Parameters  
 [in] `nState`  
 Whether the frame is active or inactive. See the table in the Remarks section for possible values.  
  
 [in] `pWndOther`  
 Pointer to another window that is switching user input with the current one.  
  
 [in] `bMinimized`  
 The minimized state of the frame. `TRUE` if the frame is minimized; otherwise, `FALSE`.  
  
## Remarks  
 The following table lists the possible values for the `nState` parameter.  
  
 `WA_ACTIVE`  
 The frame is selected by a method other than a mouse click.  
  
 `WA_CLICKACTIVE`  
 The frame is selected by a mouse click.  
  
 `WA_INACTIVE`  
 The frame is not selected.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)