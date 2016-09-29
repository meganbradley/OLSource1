---
title: "CMFCVisualManagerOffice2003::OnDrawMenuBorder"
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
  - "OnDrawMenuBorder"
  - "CMFCVisualManagerOffice2003::OnDrawMenuBorder"
  - "CMFCVisualManagerOffice2003.OnDrawMenuBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuBorder method"
ms.assetid: 3dd2f08f-8f37-4fba-b18c-40a40061e3bb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawMenuBorder
The framework calls this method when it draws the border of a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawMenuBorder(  
   CDC* pDC,  
   CMFCPopu* pMenu,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context for a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object.  
  
 [in] `pMenu`  
 A pointer to a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object. The framework draws a border around this popup menu.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the popup menu.  
  
## Remarks  
 The default implementation of this method displays the standard menu border. Override this method in a derived visual manager to customize the appearance of the menu border.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)