---
title: "CMFCStatusBar::SetTipText"
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
  - CMFCStatusBar::SetTipText
  - SetTipText
  - CMFCStatusBar.SetTipText
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTipText method
ms.assetid: 590ed6e5-259d-4832-9a04-51ffe5fef41f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCStatusBar::SetTipText
Set the tooltip text of a status bar pane.  
  
## Syntax  
  
```  
void SetTipText(  
   int nIndex,  
   LPCTSTR pszTipText   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 The index of the pane to which you want to assign the tooltip text.  
  
 [in] `pszTipText`  
 The new tooltip text.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)