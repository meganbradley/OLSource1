---
title: "CMFCButton::SelectFont"
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
  - "CMFCButton::SelectFont"
  - "SelectFont"
  - "CMFCButton.SelectFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectFont method"
ms.assetid: b24a4eb6-e601-4f43-9493-d97e82c6ffca
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::SelectFont
Retrieves the font that is associated with the specified device context.  
  
## Syntax  
  
```  
virtual CFont* SelectFont(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
## Return Value  
 Override this method to use your own code to retrieve the font.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)