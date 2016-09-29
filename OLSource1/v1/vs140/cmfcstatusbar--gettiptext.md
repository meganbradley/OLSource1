---
title: "CMFCStatusBar::GetTipText"
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
  - "GetTipText"
  - "CMFCStatusBar::GetTipText"
  - "CMFCStatusBar.GetTipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTipText method"
ms.assetid: a0314293-c584-4c10-baf6-89a2a1e01beb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::GetTipText
Retrieve the tooltip text of a status bar's pane.  
  
## Syntax  
  
```  
CString GetTipText(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the index of the pane for which to retrieve tool tip text.  
  
## Return Value  
 The tooltip text of the status-bar pane that `nIndex` specifies. Otherwise, the empty string if a status bar pane does not exist for the specified `nIndex` or if its tooltip text is empty.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)