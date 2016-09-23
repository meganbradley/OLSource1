---
title: "CDockablePane::Slide"
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
  - CDockablePane.Slide
  - CDockablePane::Slide
  - Slide
dev_langs: 
  - C++
helpviewer_keywords: 
  - Slide method
ms.assetid: f97d3add-743d-4731-bc75-19a8060547e2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::Slide
Animates a pane that is in autohide mode.  
  
## Syntax  
  
```  
virtual void Slide(  
    BOOL bSlideOut,  
    BOOL bUseTimer = TRUE  
);  
```  
  
#### Parameters  
 [in] `bSlideOut`  
 `TRUE` to show the pane; `FALSE` to hide the pane.  
  
 [in] `bUseTimer`  
 `TRUE` to show or hide the pane with the autohide effect; `FALSE` to show or hide the pane immediately.  
  
## Remarks  
 The framework calls this method to animate a pane that is in autohide mode.  
  
 This method uses the `CDockablePane::m_nSlideDefaultTimeOut` value to determine the time out for the slide effect. The default value for the time out is 1. If you customize the autohide algorithm, modify this member to change the time out.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)