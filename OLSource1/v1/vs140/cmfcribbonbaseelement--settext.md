---
title: "CMFCRibbonBaseElement::SetText"
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
  - "SetText"
  - "CMFCRibbonBaseElement::SetText"
  - "CMFCRibbonBaseElement.SetText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetText method"
ms.assetid: 86f923af-551f-4551-8459-9e965bba3255
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::SetText
Sets the text and keytip for the ribbon element.  
  
## Syntax  
  
```  
virtual void SetText(  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 [in] `lpszText`  
 The text and keytip for the ribbon element.  
  
## Remarks  
 To set the keytip for the ribbon element, append the newline escape sequence followed by the keytip characters to `lpszText`.  
  
## Example  
  
```  
//Set the text for the ribbon element  
SetText(_T("Margins"))  
//Set the text and a single-letter keytip  
SetText(_T("Margins\nm"))  
//Set the text and a multiple-letter keytip  
SetText(_T("Line Numbers\nln"))  
```  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)