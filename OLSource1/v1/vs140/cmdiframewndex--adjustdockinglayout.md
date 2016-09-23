---
title: "CMDIFrameWndEx::AdjustDockingLayout"
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
  - AdjustDockingLayout
  - CMDIFrameWndEx::AdjustDockingLayout
  - CMDIFrameWndEx.AdjustDockingLayout
dev_langs: 
  - C++
helpviewer_keywords: 
  - AdjustDockingLayout method
ms.assetid: adeea31e-cb66-493a-948c-61433e14d431
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::AdjustDockingLayout
Recalculates the layout of all docked panes.  
  
## Syntax  
  
```  
virtual void AdjustDockingLayout(  
   HDWP hdwp=NULL   
);  
```  
  
#### Parameters  
 [in] `hdwp`  
 Identifies the multiple-window-position structure. You can obtain this value by calling `BeginDeferWindowPos`.  
  
## Remarks  
 Call this member function to recalculate the layout of all panes docked to the frame window.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)