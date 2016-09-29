---
title: "CPropertySheet::SetTitle"
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
  - "CPropertySheet::SetTitle"
  - "CPropertySheet.SetTitle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTitle method"
  - "CPropertySheet class, attributes"
ms.assetid: b24d1416-657e-435a-81bf-7711eb154ec0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::SetTitle
Specifies the property sheet's caption (the text displayed in the title bar of a frame window).  
  
## Syntax  
  
```  
  
      void SetTitle(  
   LPCTSTR lpszText,  
   UINT nStyle = 0   
);  
```  
  
#### Parameters  
 `nStyle`  
 Specifies the style of the property sheet title. The style must be specified at 0 or as **PSH_PROPTITLE**. If the style is set as **PSH_PROPTITLE**, the word "Properties" appears after the text specified as the caption. For example, calling `SetTitle`("Simple", **PSH_PROPTITLE**) will result in a property sheet caption of "Simple Properties."  
  
 `lpszText`  
 Points to the text to be used as the caption in the title bar of the property sheet.  
  
## Remarks  
 By default, a property sheet uses the caption parameter in the property sheet constructor.  
  
## Example  
 [!code[NVC_MFCDocView#139](../vs140/codesnippet/CPP/cpropertysheet--settitle_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::GetPage](../vs140/cpropertysheet--getpage.md)   
 [CPropertySheet::GetActivePage](../vs140/cpropertysheet--getactivepage.md)