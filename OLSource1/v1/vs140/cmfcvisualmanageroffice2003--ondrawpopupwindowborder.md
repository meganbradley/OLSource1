---
title: "CMFCVisualManagerOffice2003::OnDrawPopupWindowBorder"
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
  - "CMFCVisualManagerOffice2003::OnDrawPopupWindowBorder"
  - "CMFCVisualManagerOffice2003.OnDrawPopupWindowBorder"
  - "OnDrawPopupWindowBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPopupWindowBorder method"
ms.assetid: 9f91032d-6b16-4599-bc49-d7158a73dd6f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawPopupWindowBorder
The framework calls this method when it draws the border of a popup window.  
  
## Syntax  
  
```  
virtual void OnDrawPopupWindowBorder(  
   CDC* pDC,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to the device context of the popup window.  
  
 [in] `rect`  
 The bounding rectangle of the popup window.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)