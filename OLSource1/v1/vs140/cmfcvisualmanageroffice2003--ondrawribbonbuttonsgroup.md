---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonButtonsGroup"
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
  - "CMFCVisualManagerOffice2003.OnDrawRibbonButtonsGroup"
  - "OnDrawRibbonButtonsGroup"
  - "CMFCVisualManagerOffice2003::OnDrawRibbonButtonsGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonButtonsGroup method"
ms.assetid: 54f3e6aa-7242-4f85-bf94-e85a80c23c43
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonButtonsGroup
The framework calls this method when it draws a group of buttons on the ribbon.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonButtonsGroup(  
   CDC* pDC,  
   CMFCRibbonButtonsGroup* pGroup,  
   CRect rectGroup  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pGroup`  
 A pointer to a group of buttons on the ribbon. The framework draws this group of buttons.  
  
 [in] `rectGroup`  
 A rectangle that specifies the boundaries of the group.  
  
## Return Value  
 A reserved value. The default implementation returns -1.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a group of buttons on the ribbon.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)