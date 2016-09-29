---
title: "CPaneFrameWnd::CalcExpectedDockedRect"
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
  - "CPaneFrameWnd.CalcExpectedDockedRect"
  - "CPaneFrameWnd::CalcExpectedDockedRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcExpectedDockedRect method"
ms.assetid: 821a698a-8f80-435e-a135-7bf52a05fd7d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::CalcExpectedDockedRect
Calculate the expected rectangle of a docked window.  
  
## Syntax  
  
```  
virtual void CalcExpectedDockedRect(  
   CWnd* pWndToDock,  
   CPoint ptMouse,  
   CRect& rectResult,  
   BOOL& bDrawTab,  
   CDockablePane** ppTargetBar  
);  
```  
  
#### Parameters  
 [in] `pWndToDock`  
 A pointer to the window to dock.  
  
 [in] `ptMouse`  
 The mouse location.  
  
 [out] `rectResult`  
 The calculated rectangle.  
  
 [out] `bDrawTab`  
 If `TRUE`, draw a tab. If `FALSE`, do not draw a tab.  
  
 [out] `ppTargetBar`  
 A pointer to the target pane.  
  
## Remarks  
 This method calculates the rectangle that a window would occupy if a user dragged the window to the point specified by `ptMouse` and docked it there.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)