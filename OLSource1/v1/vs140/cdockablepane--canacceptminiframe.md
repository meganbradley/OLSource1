---
title: "CDockablePane::CanAcceptMiniFrame"
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
  - "CanAcceptMiniFrame"
  - "CDockablePane::CanAcceptMiniFrame"
  - "CDockablePane.CanAcceptMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAcceptMiniFrame method"
ms.assetid: e95570e1-1622-4a71-a7f3-3bd7a41d9602
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CanAcceptMiniFrame
Determines whether the specified mini-frame can be docked to the pane.  
  
## Syntax  
  
```  
virtual BOOL CanAcceptMiniFrame(  
   CPaneFrameWnd* pMiniFrame  
) const;  
```  
  
#### Parameters  
 [in] `pMiniFrame`  
 Pointer to a `CPaneFrameWnd` object.  
  
## Return Value  
 `TRUE` if `pMiniFrame` can be docked to the pane; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [CDockablePane::CanAcceptPane](../vs140/cdockablepane--canacceptpane.md)