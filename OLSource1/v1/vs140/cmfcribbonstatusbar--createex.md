---
title: "CMFCRibbonStatusBar::CreateEx"
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
  - "CreateEx"
  - "CMFCRibbonStatusBar.CreateEx"
  - "CMFCRibbonStatusBar::CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: b82c3212-bc84-418b-96cd-23f49200a528
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBar::CreateEx
Creates a ribbon status bar that has an extended style.  
  
## Syntax  
  
```  
BOOL CreateEx(  
   CWnd* pParentWnd,  
   DWORD dwCtrlStyle=0,  
   DWORD dwStyle=WS_CHILD|WS_VISIBLE|CBRS_BOTTOM,  
   UINT nID=AFX_IDW_STATUS_BAR   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 A pointer to the parent window.  
  
 `dwCtrlStyle`  
 A logical OR combination of additional styles for creating the status bar object.  
  
 `dwStyle`  
 The control style of the status bar.  
  
 `nID`  
 The control ID of the status bar.  
  
## Return Value  
 `TRUE` if the status bar is created successfully, `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxribbonstatusbar.h  
  
## See Also  
 [CMFCRibbonStatusBar Class](../vs140/cmfcribbonstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)