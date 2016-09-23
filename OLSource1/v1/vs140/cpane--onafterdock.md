---
title: "CPane::OnAfterDock"
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
  - OnAfterDock
  - CPane.OnAfterDock
  - CPane::OnAfterDock
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnAfterDock method
ms.assetid: a8721c40-4bef-4b9a-a811-d2cc83990b32
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::OnAfterDock
Called by the framework when a pane has been docked.  
  
## Syntax  
  
```  
virtual void OnAfterDock(  
    CBasePane* pBar,  
    LPCRECT lpRect,  
    AFX_DOCK_METHOD dockMethod  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 This parameter is not used.  
  
 [in] `lpRect`  
 This parameter is not used.  
  
 [in] `dockMethod`  
 This parameter is not used.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)