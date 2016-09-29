---
title: "CMFCAutoHideBar::AddAutoHideWindow"
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
  - "CMFCAutoHideBar::AddAutoHideWindow"
  - "CMFCAutoHideBar.AddAutoHideWindow"
  - "AddAutoHideWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddAutoHideWindow method"
ms.assetid: a38a33d2-8a90-4b86-b450-be5a99dab300
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideBar::AddAutoHideWindow
Adds functionality to a `CDockablePane` window that enables it to auto-hide.  
  
## Syntax  
  
```  
CMFCAutoHideButton* AddAutoHideWindow(  
    CDockablePane* pAutoHideWnd,  
    DWORD dwAlignment  
);   
```  
  
#### Parameters  
 [in] `pAutoHideWnd`  
 The window that you want to hide.  
  
 [in] `dwAlignment`  
 A value that specifies the alignment of the auto-hide button with the application window.  
  
## Return Value  
  
## Remarks  
 The `dwAlignment` parameter indicates where the auto-hide button resides in the application. The parameter can be any one of the following values:  
  
-   `CBRS_ALIGN_LEFT`  
  
-   `CBRS_ALIGN_RIGHT`  
  
-   `CBRS_ALIGN_TOP`  
  
-   `CBRS_ALIGN_BOTTOM`  
  
## Requirements  
 **Header:** afxautohidebar.h  
  
## See Also  
 [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)