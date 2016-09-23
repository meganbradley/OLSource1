---
title: "CMDIFrameWndEx::OnCloseMiniFrame"
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
  - OnCloseMiniFrame
  - CMDIFrameWndEx.OnCloseMiniFrame
  - CMDIFrameWndEx::OnCloseMiniFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnCloseMiniFrame method
ms.assetid: 4fed69c3-e733-44d0-89bc-98e5c84870ea
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::OnCloseMiniFrame
Called by the framework when the user clicks the **Close** button on a floating mini-frame window.  
  
## Syntax  
  
```  
virtual BOOL OnCloseMiniFrame(  
   CPaneFrameWnd*    
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 Pointer to the mini-frame window being closed.  
  
## Return Value  
 `TRUE` if the floating mini-frame window can be closed. Otherwise, `FALSE`.  
  
## Remarks  
 Override this method to handle hiding of floating mini-frame windows. Return `FALSE` if you want to prevent a floating mini-frame window from being hidden.  
  
 The default implementation does nothing and returns `TRUE`.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)