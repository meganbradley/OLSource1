---
title: "CMFCStatusBar::SetPaneTextColor"
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
  - "CMFCStatusBar.SetPaneTextColor"
  - "SetPaneTextColor"
  - "CMFCStatusBar::SetPaneTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaneTextColor method"
ms.assetid: 573131d0-6220-4bc6-8378-1457cf7cc318
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::SetPaneTextColor
Sets the text color of the specified pane.  
  
## Syntax  
  
```  
void SetPaneTextColor(  
   int nIndex,  
   COLORREF clrText=(COLORREF)-1,  
   BOOL bUpdate=TRUE   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the index of the pane to which you want to assign a new text color.  
  
 [in] `clrText`  
 Specifies the text color.  
  
 [in] `bUpdate`  
 If `TRUE`, update the pane content immediately. Otherwise, do not update the pane content until the pane is invalidated by another method.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)