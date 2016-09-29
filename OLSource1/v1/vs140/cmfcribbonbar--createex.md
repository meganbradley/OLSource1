---
title: "CMFCRibbonBar::CreateEx"
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
  - "CMFCRibbonBar.CreateEx"
  - "CMFCRibbonBar::CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: afd1c127-f886-4ab6-8786-51878dd4a9ab
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::CreateEx
Creates a window for the ribbon bar.  
  
## Syntax  
  
```  
BOOL CreateEx(  
   CWnd* pParentWnd,  
   DWORD dwCtrlStyle = 0,  
   DWORD dwStyle = WS_CHILD | WS_VISIBLE | CBRS_TOP,  
   UINT nID = AFX_IDW_RIBBON_BAR  
);  
```  
  
#### Parameters  
 [in] `pParentWnd`  
 Pointer to the parent window for the ribbon bar.  
  
 [in] `dwCtrlStyle`  
 This parameter is not used.  
  
 [in] `dwStyle`  
 A logical combination of styles for the new window.  
  
 [in] `nID`  
 ID of the new window.  
  
## Return Value  
 `TRUE` if the window was created; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)