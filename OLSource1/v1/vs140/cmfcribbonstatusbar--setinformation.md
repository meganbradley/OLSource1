---
title: "CMFCRibbonStatusBar::SetInformation"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonStatusBar.SetInformation
  - SetInformation
  - CMFCRibbonStatusBar::SetInformation
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetInformation method
ms.assetid: 1e45ab61-e96f-4f94-9d1b-164ce75ba27a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonStatusBar::SetInformation
Enables or disables the information mode for the ribbon status bar.  
  
## Syntax  
  
```  
void SetInformation(  
   LPCTSTR lpszInfo   
);  
```  
  
#### Parameters  
 [in] `lpszInfo`  
 The information string.  
  
## Remarks  
 Use this method to put the status bar in the information mode. In this mode, the status bar hides all panes and displays the information string specified by `lpszInfo`.  
  
 When lpszInfo is `NULL`, the status bar reverts to regular mode.  
  
## Requirements  
 **Header:** afxribbonstatusbar.h  
  
## See Also  
 [CMFCRibbonStatusBar Class](../vs140/cmfcribbonstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)