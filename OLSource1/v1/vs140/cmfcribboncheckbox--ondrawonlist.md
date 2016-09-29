---
title: "CMFCRibbonCheckBox::OnDrawOnList"
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
  - "CMFCRibbonCheckBox::OnDrawOnList"
  - "CMFCRibbonCheckBox.OnDrawOnList"
  - "OnDrawOnList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawOnList method"
ms.assetid: 1c775eca-f81e-4aea-b785-c993a69a866d
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCheckBox::OnDrawOnList
Called by the framework to draw the checkbox in a commands list box.  
  
## Syntax  
  
```  
virtual void OnDrawOnList(  
   CDC* pDC,  
   CString strText,  
   int nTextOffset,  
   CRect rect,  
   BOOL bIsSelected,  
   BOOL bHighlighted  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to the device context in which to draw the checkbox.  
  
 [in] `strText`  
 The display text.  
  
 [in] `nTextOffset`  
 The distance, in pixels, from the left side of the list box to the display text.  
  
 [in] `rect`  
 The display rectangle for the checkbox.  
  
 [in] `bIsSelected`  
 `TRUE` if the checkbox is selected, or `FALSE` if not.  
  
 [in] `bHighlighted`  
 `TRUE` if the checkbox is highlighted, or `FALSE` if not.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncheckbox.h  
  
## See Also  
 [CMFCRibbonCheckBox Class](../vs140/cmfcribboncheckbox-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)