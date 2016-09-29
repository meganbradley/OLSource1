---
title: "CMFCRibbonBar::GetKeyboardNavLevelCurrent"
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
  - "GetKeyboardNavLevelCurrent"
  - "CMFCRibbonBar::GetKeyboardNavLevelCurrent"
  - "CMFCRibbonBar.GetKeyboardNavLevelCurrent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetKeyboardNavLevelCurrent method"
ms.assetid: aafe0958-7a99-4394-95cf-547cb166ce5f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::GetKeyboardNavLevelCurrent
Retrieves the current keyboard navigation object on the ribbon bar.  
  
## Syntax  
  
```  
CObject* GetKeyboardNavLevelCurrent() const;  
```  
  
## Return Value  
 The current keyboard navigation object on the ribbon bar; otherwise `NULL` if no object currently displays keytips.  
  
## Remarks  
 The object that is currently displaying keytips is the current keyboard navigation object.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)