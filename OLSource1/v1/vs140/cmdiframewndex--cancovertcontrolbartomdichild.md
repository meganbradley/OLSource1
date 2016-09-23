---
title: "CMDIFrameWndEx::CanCovertControlBarToMDIChild"
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
  - CMDIFrameWndEx.CanCovertControlBarToMDIChild
  - CanCovertControlBarToMDIChild
  - CMDIFrameWndEx::CanCovertControlBarToMDIChild
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanCovertControlBarToMDIChild method
ms.assetid: 9d7ab832-b654-4623-ba37-52db4adf060f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::CanCovertControlBarToMDIChild
Called by the framework to determine whether the frame window can convert docking panes to tabbed documents  
  
## Syntax  
  
```  
virtual BOOL CanCovertControlBarToMDIChild();  
```  
  
## Return Value  
 Returns `TRUE` if the frame window can convert docking panes to tabbed documents; otherwise returns `FALSE`.  
  
## Remarks  
 Override this method in a derived class and return `TRUE` to enable the conversion of docking panes to tabbed documents. Alternatively, you can set [CMDIFrameWndEx::m_bCanCovertControlBarToMDIChild](../vs140/cmdiframewndex--m_bcancovertcontrolbartomdichild.md) to `TRUE`.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)