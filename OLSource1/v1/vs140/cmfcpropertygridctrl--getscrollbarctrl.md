---
title: "CMFCPropertyGridCtrl::GetScrollBarCtrl"
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
  - "GetScrollBarCtrl"
  - "CMFCPropertyGridCtrl::GetScrollBarCtrl"
  - "CMFCPropertyGridCtrl.GetScrollBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetScrollBarCtrl method"
ms.assetid: 3e99dba9-8005-4bbd-9aab-0f183e8efb59
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::GetScrollBarCtrl
Retrieves a pointer to the scroll bar control in the property grid control.  
  
## Syntax  
  
```  
virtual CScrollBar* GetScrollBarCtrl(  
   int nBar   
) const;  
```  
  
#### Parameters  
 [in] `nBar`  
 The orientation of the scroll bar, which must be `SB_VERT`.  
  
## Return Value  
 A pointer to a scroll bar object, or `NULL` if there is no scroll bar or the scroll bar orientation is `SB_HORZ`.  
  
## Remarks  
 Use this method to gain direct access to the vertical scroll bar control.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar Class](../vs140/cscrollbar-class.md)