---
title: "CMFCBaseToolBar::OnAfterChangeParent"
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
  - CMFCBaseToolBar::OnAfterChangeParent
  - CMFCBaseToolBar.OnAfterChangeParent
  - :OnAfterChangeParent
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnAfterChangeParent method
ms.assetid: 9baa7636-c5d1-4d61-8238-52c824f2fe5e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCBaseToolBar::OnAfterChangeParent
Called by the framework after the pane's parent changes.  
  
## Syntax  
  
```  
virtual void OnAfterChangeParent(  
   CWnd* pWndOldParent  
);  
```  
  
#### Parameters  
 [in] `pWndOldParent`  
 A pointer to the previous parent window.  
  
## Requirements  
 **Header:** afxbasetoolbar.h  
  
## See Also  
 [CMFCBaseToolBar Class](../vs140/cmfcbasetoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)