---
title: "CMFCVisualManagerOffice2003::OnDrawShowAllMenuItems"
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
  - "OnDrawShowAllMenuItems"
  - "CMFCVisualManagerOffice2003.OnDrawShowAllMenuItems"
  - "CMFCVisualManagerOffice2003::OnDrawShowAllMenuItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawShowAllMenuItems method"
ms.assetid: edf6dbd3-3db2-40fb-a075-fcaf62d546e0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawShowAllMenuItems
The framework calls this method when it draws all the items in a menu  
  
## Syntax  
  
```  
virtual void OnDrawShowAllMenuItems(  
   CDC* pDC,  
   CRect rect,  
   CMFCVisualManager::AFX_BUTTON_STATE state  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `rect`  
 The bounding rectangle of the menu to be drawn.  
  
 [in] `state`  
 The button state.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)