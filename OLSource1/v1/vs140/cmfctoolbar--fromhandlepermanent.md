---
title: "CMFCToolBar::FromHandlePermanent"
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
  - "CMFCToolBar.FromHandlePermanent"
  - "CMFCToolBar::FromHandlePermanent"
  - "FromHandlePermanent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandlePermanent method"
ms.assetid: 8781a8c1-60bb-4394-b09d-d12c8cb22fde
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::FromHandlePermanent
Retrieves a pointer to the `CMFCToolBar` object that contains the given window handle.  
  
## Syntax  
  
```  
static CMFCToolBar* __stdcall FromHandlePermanent(  
   HWND hwnd  
);  
```  
  
#### Parameters  
 [in] `hwnd`  
 The window handle to look for.  
  
## Return Value  
 A pointer to the `CMFCToolBar` object that contains the given window handle, or `NULL` if no corresponding `CMFCToolBar` object exists.  
  
## Remarks  
 This shared method examines each toolbar in the application for the `CMFCToolBar` object that contains the given window handle.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)