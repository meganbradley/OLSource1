---
title: "CMDIFrameWndEx::MDITabMoveToNextGroup"
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
  - CMDIFrameWndEx.MDITabMoveToNextGroup
  - MDITabMoveToNextGroup
  - CMDIFrameWndEx::MDITabMoveToNextGroup
dev_langs: 
  - C++
helpviewer_keywords: 
  - MDITabMoveToNextGroup method
ms.assetid: dcba6669-89a2-4177-a358-dc4f3734acb8
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::MDITabMoveToNextGroup
Moves the active tab from the currently active tabbed window to the next or previous tabbed group.  
  
## Syntax  
  
```  
void MDITabMoveToNextGroup(  
   BOOL bNext=TRUE   
);  
```  
  
#### Parameters  
 [in] `bNext`  
 If `TRUE`, move the tab to the next tabbed group. If `FALSE`, move it to the previous tabbed group.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)