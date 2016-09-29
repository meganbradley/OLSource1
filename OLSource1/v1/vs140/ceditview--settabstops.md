---
title: "CEditView::SetTabStops"
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
  - "CEditView::SetTabStops"
  - "CEditView.SetTabStops"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEditView class, attributes"
  - "tabs"
  - "SetTabStops method"
ms.assetid: d29d34d9-7cb4-4fc7-8747-e5c183fa9f20
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::SetTabStops
Call this function to set the tab stops used for display and printing.  
  
## Syntax  
  
```  
  
      void SetTabStops(  
   int nTabStops   
);  
```  
  
#### Parameters  
 `nTabStops`  
 Width of each tab stop, in dialog units.  
  
## Remarks  
 Only a single tab-stop width is supported. (`CEdit` objects support multiple tab widths.) Widths are in dialog units, which equal one-fourth of the average character width (based on uppercase and lowercase alphabetic characters only) of the font used at the time of printing or displaying. You should not use `CEdit::SetTabStops` because `CEditView` must cache the tab-stop value.  
  
 This function modifies only the tabs of the object for which it is called. To change the tab stops for each `CEditView` object in your application, call each object's `SetTabStops` function.  
  
## Example  
 This code fragment sets the tab stops in the control to every fourth character by carefully measuring the font the control uses.  
  
 [!code[NVC_MFCDocView#67](../vs140/codesnippet/CPP/ceditview--settabstops_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetFont](../vs140/cwnd--setfont.md)   
 [CEditView::SetPrinterFont](../vs140/ceditview--setprinterfont.md)