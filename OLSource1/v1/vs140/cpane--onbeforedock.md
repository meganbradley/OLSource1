---
title: "CPane::OnBeforeDock"
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
  - "CPane::OnBeforeDock"
  - "CPane.OnBeforeDock"
  - "OnBeforeDock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBeforeDock method"
ms.assetid: 1c6abb50-439d-41b8-b1b8-798d74a35c77
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::OnBeforeDock
Called by the framework when the pane is about to dock.  
  
## Syntax  
  
```  
virtual BOOL OnBeforeDock(  
    CBasePane** ppDockBar,  
    LPCRECT lpRect,  
    AFX_DOCK_METHOD dockMethod  
);  
```  
  
#### Parameters  
 [in] [out] `ppDockBar`  
 Specifies the pane that this pane is docking to.  
  
 [in] `lpRect`  
 Specifies the docking rectangle.  
  
 [in] `dockMethod`  
 Specifies the docking method.  
  
## Return Value  
 `TRUE` if the pane can be docked. If the function returns `FALSE`, the docking operation will be aborted.  
  
## Remarks  
 This method is called by the framework when a pane is about to be docked. You can override this method in a derived class if you want to perform any processing before a pane is finally docked.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)