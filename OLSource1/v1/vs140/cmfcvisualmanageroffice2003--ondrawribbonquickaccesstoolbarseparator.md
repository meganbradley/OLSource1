---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonQuickAccessToolBarSeparator"
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
  - "CMFCVisualManagerOffice2003.OnDrawRibbonQuickAccessToolBarSeparator"
  - "OnDrawRibbonQuickAccessToolBarSeparator"
  - "CMFCVisualManagerOffice2003::OnDrawRibbonQuickAccessToolBarSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonQuickAccessToolBarSeparator method"
ms.assetid: 4953b6f2-c337-47b5-8ba7-46321e42e8e4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonQuickAccessToolBarSeparator
The framework calls this method when it draws a separator on the Quick Access Toolbar of a ribbon.  
  
## Syntax  
  
```  
virtual void OnDrawRibbonQuickAccessToolBarSeparator(  
   CDC* pDC,  
   CMFCRibbonSeparator* pSeparator,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pSeparator`  
 A pointer to a [CMFCRibbonSeparator](../vs140/cmfcribbonseparator-class.md) object. The framework draws this ribbon separator.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the separator.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of ribbon separators on the Quick Access Toolbar.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)