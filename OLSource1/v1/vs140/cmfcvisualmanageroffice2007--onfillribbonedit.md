---
title: "CMFCVisualManagerOffice2007::OnFillRibbonEdit"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCVisualManagerOffice2007::OnFillRibbonEdit
  - OnFillRibbonEdit
  - CMFCVisualManagerOffice2007.OnFillRibbonEdit
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFillRibbonEdit method
ms.assetid: 8e6b5bfe-5d8a-4675-9636-94117bc410f0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2007::OnFillRibbonEdit
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
virtual void OnFillRibbonEdit(  
   CDC* pDC,  
   CMFCRibbonRichEditCtrl* pEdit,  
   CRect rect,  
   BOOL bIsHighlighted,  
   BOOL bIsPaneHighlighted,  
   BOOL bIsDisabled,  
   COLORREF& clrText,  
   COLORREF& clrSelBackground,  
   COLORREF& clrSelText  
);  
```  
  
#### Parameters  
 [in] `pDC`  
  [in] `pEdit`  
  [in] `rect`  
  [in] `bIsHighlighted`  
  [in] `bIsPaneHighlighted`  
  [in] `bIsDisabled`  
  [in] `clrText`  
  [in] `clrSelBackground`  
  [in] `clrSelText`  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2007.h  
  
## See Also  
 [CMFCVisualManagerOffice2007 Class](../vs140/cmfcvisualmanageroffice2007-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)