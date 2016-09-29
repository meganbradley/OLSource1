---
title: "CMFCPropertyGridCtrl::IsShowDragContext"
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
  - "CMFCPropertyGridCtrl::IsShowDragContext"
  - "CMFCPropertyGridCtrl.IsShowDragContext"
  - "IsShowDragContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsShowDragContext method"
  - "CMFCPropertyGridCtrl::IsShowDragContext"
ms.assetid: 6926f2b4-af3d-445a-abff-dc3fa9d01800
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::IsShowDragContext
Indicates whether the framework redraws the name and value columns of the current property grid control when a user resizes the columns.  
  
## Syntax  
  
```  
BOOL IsShowDragContext() const;  
```  
  
## Return Value  
 `TRUE` if the framework redraws the name and value columns during a resize operation; `FALSE` if the framework redraws the columns after the drag operation is completed.  
  
## Remarks  
 The user can resize the name and value columns of a property grid control by dragging the split bar that is between the columns. If the drag context is displayed, the name and value columns are resized as long as the user drags the split bar. Otherwise, the split bar moves but the columns are not redrawn until the drag operation is completed.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::SetShowDragContext](../vs140/cmfcpropertygridctrl--setshowdragcontext.md)