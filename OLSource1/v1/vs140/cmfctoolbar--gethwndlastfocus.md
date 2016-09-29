---
title: "CMFCToolBar::GetHwndLastFocus"
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
  - "CMFCToolBar::GetHwndLastFocus"
  - "CMFCToolBar.GetHwndLastFocus"
  - "GetHwndLastFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHwndLastFocus method"
ms.assetid: 0c13f194-b81f-47b0-ade8-a470bdd2ab3c
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetHwndLastFocus
Returns a handle to the window that had the input focus just before the toolbar did.  
  
## Syntax  
  
```  
HWND GetHwndLastFocus() const;  
```  
  
## Return Value  
 A handle to window that is not derived from [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md), which previously had the input focus; or `NULL` if there is no such window.  
  
## Remarks  
 When a [CMFCToolBar](../vs140/cmfctoolbar-class.md) control receives the input focus, it stores a handle to the window that lost the focus so that it can restore it later.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)