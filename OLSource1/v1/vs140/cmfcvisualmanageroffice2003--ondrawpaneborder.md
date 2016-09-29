---
title: "CMFCVisualManagerOffice2003::OnDrawPaneBorder"
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
  - "CMFCVisualManagerOffice2003::OnDrawPaneBorder"
  - "CMFCVisualManagerOffice2003.OnDrawPaneBorder"
  - "OnDrawPaneBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPaneBorder method"
ms.assetid: 3b7b3c30-6479-47a4-8aee-d1edfcb9065e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawPaneBorder
The framework calls this method when it draws the border of a [CPane](../vs140/cpane-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawPaneBorder(  
   CDC* pDC,  
   CBasePane* pBar,  
   CRect& rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context of a control bar.  
  
 [in] `pBar`  
 A pointer to a pane. The visual manager draws the border of this pane.  
  
 [in] `rect`  
 A rectangle that indicates the boundaries of the pane.  
  
## Remarks  
 The default implementation of this method displays the standard border. Override this method in a derived class to customize the appearance of the border.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)