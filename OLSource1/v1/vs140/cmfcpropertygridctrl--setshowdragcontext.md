---
title: "CMFCPropertyGridCtrl::SetShowDragContext"
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
  - "CMFCPropertyGridCtrl::SetShowDragContext"
  - "SetShowDragContext"
  - "CMFCPropertyGridCtrl.SetShowDragContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridCtrl::SetShowDragContext"
  - "SetShowDragContext method"
ms.assetid: a719847f-76f3-43d0-b84c-b8b0b144e018
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::SetShowDragContext
Specifies whether the framework redraws the name and value columns of the current property grid control when a user resizes the columns.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to redraw the name and value columns during a resize operation; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to redraw the columns after the drag operation is completed. The default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The user can resize the name and value columns of a property grid control by dragging the split bar that is between the columns. If the drag context is displayed, the name and value columns are resized as long as the user drags the split bar. Otherwise, the split bar moves but the columns are not redrawn until the drag operation is completed.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::IsShowDragContext](../vs140/cmfcpropertygridctrl--isshowdragcontext.md)