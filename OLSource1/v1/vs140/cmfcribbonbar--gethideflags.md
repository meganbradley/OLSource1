---
title: "CMFCRibbonBar::GetHideFlags"
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
  - "CMFCRibbonBar.GetHideFlags"
  - "CMFCRibbonBar::GetHideFlags"
  - "GetHideFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHideFlags method"
ms.assetid: 070e9561-6ed6-4f99-a96d-64c5bbe659b2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::GetHideFlags
Retrieves the flags that indicate how much of the ribbon bar is visible.  
  
## Syntax  
  
```  
DWORD GetHideFlags() const;  
```  
  
## Return Value  
 The flags that indicate how much of the ribbon bar is visible.  
  
## Remarks  
 The following table lists the possible combination of flags for the return value:  
  
 `AFX_RIBBONBAR_HIDE_ELEMENTS`  
 The ribbon bar is minimized vertically and only the category tabs, main button, and quick access toolbar are visible.  
  
 `AFX_RIBBONBAR_HIDE_ALL`  
 The width of the ribbon bar is less than the minimum width and is completely hidden.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)