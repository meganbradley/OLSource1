---
title: "CDockingManager::FrameFromPoint"
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
  - "CDockingManager::FrameFromPoint"
  - "CDockingManager.FrameFromPoint"
  - "FrameFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FrameFromPoint method"
ms.assetid: 7248419f-f41c-420f-8e4e-bdc40d7ac10d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::FrameFromPoint
Returns the frame that contains the given point.  
  
## Syntax  
  
```  
virtual CPaneFrameWnd* FrameFromPoint(  
   CPoint pt,  
   CPaneFrameWnd* pFrameToExclude,  
   BOOL bFloatMultiOnly  
) const;  
```  
  
#### Parameters  
 [in] `pt`  
 Specifies the point, in screen coordinates, to check.  
  
 [in] `pFrameToExclude`  
 A pointer to a frame to exclude.  
  
 [in] `bFloatMultiOnly`  
 `TRUE` to exclude frames that are not instances of `CMultiPaneFrameWnd`; `FALSE` otherwise.  
  
## Return Value  
 The frame that contains the given point; `NULL` otherwise.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)