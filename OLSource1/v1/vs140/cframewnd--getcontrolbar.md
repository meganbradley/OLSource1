---
title: "CFrameWnd::GetControlBar"
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
  - CFrameWnd.GetControlBar
  - CFrameWnd::GetControlBar
  - GetControlBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetControlBar method
  - CFrameWnd class, operations
ms.assetid: 1d70d22b-8066-4ff2-b364-48692f2fccf7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::GetControlBar
Call `GetControlBar` to gain access to the control bar that is associated with the ID.  
  
## Syntax  
  
```  
  
      CControlBar* GetControlBar(  
   UINT nID   
);  
```  
  
#### Parameters  
 `nID`  
 The ID number of a control bar.  
  
## Return Value  
 A pointer to the control bar that is associated with the ID.  
  
## Remarks  
 The `nID` parameter refers to the unique identifier passed to the **Create** method of the control bar. For more information on control bars, refer to the topic entitled [Control Bars](../vs140/control-bars.md).  
  
 `GetControlBar` will return the control bar even if it is floating and thus is not currently a child window of the frame.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)