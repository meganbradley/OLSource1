---
title: "CMFCRibbonStatusBar::Create"
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
  - "CMFCRibbonStatusBar.Create"
  - "CMFCRibbonStatusBar::Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 5ec251a5-71e1-4022-9fd2-3531e35bf8e1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBar::Create
Creates a ribbon status bar.  
  
## Syntax  
  
```  
BOOL Create(  
   CWnd* pParentWnd,  
   DWORD dwStyle=WS_CHILD|WS_VISIBLE|CBRS_BOTTOM,  
   UINT nID=AFX_IDW_STATUS_BAR   
);  
```  
  
#### Parameters  
 [in] `pParentWnd`  
 A pointer to the parent window.  
  
 [in] `dwStyle`  
 A logical OR combination of control styles.  
  
 [in] `nID`  
 The control ID of the status bar.  
  
## Return Value  
 `TRUE` if the status bar is created successfully, `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxribbonstatusbar.h  
  
## See Also  
 [CMFCRibbonStatusBar Class](../vs140/cmfcribbonstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)