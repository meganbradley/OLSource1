---
title: "CPaneFrameWnd::OnShowPane"
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
  - "CPaneFrameWnd.OnShowPane"
  - "OnShowPane"
  - "CPaneFrameWnd::OnShowPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowPane method"
ms.assetid: 33cebeaa-c914-4f11-8e8c-446909d939a4
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::OnShowPane
Called by the framework when a pane in the mini-frame window is hidden or displayed.  
  
## Syntax  
  
```  
virtual void OnShowPane(  
    CDockablePane* pBar,  
    BOOL bShow   
);  
```  
  
#### Parameters  
 [in] `pBar`  
 The pane that is being shown or hidden.  
  
 [in] `bShow`  
 `TRUE` if the pane is being shown; `FALSE` if the pane is being hidden.  
  
## Remarks  
 Called by the framework when a pane in the mini-frame window is shown or hidden. The default implementation does nothing.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)