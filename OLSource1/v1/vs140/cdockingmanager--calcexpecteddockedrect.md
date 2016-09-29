---
title: "CDockingManager::CalcExpectedDockedRect"
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
  - "CalcExpectedDockedRect"
  - "CDockingManager.CalcExpectedDockedRect"
  - "CDockingManager::CalcExpectedDockedRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcExpectedDockedRect method"
ms.assetid: 82afad59-4791-46a9-9ef0-c45463659ad5
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::CalcExpectedDockedRect
Calculates the expected rectangle of a docked window.  
  
## Syntax  
  
```  
void CalcExpectedDockedRect(  
   CWnd* pWnd,  
   CPoint ptMouse,  
   CRect& rectResult,  
   BOOL& bDrawTab,  
   CDockablePane** ppTargetBar  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to the window to dock.  
  
 [in] `ptMouse`  
 The mouse location.  
  
 [out] `rectResult`  
 The calculated rectangle.  
  
 [in] `bDrawTab`  
 `TRUE` to draw a tab; otherwise `FALSE`.  
  
 [out] `ppTargetBar`  
 A pointer to a pointer to the target pane.  
  
## Remarks  
 This method calculates the rectangle that a window would occupy if a user dragged the window to the point specified by `ptMouse` and docked it there.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)