---
title: "CMFCRibbonBaseElement::OnKey"
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
  - "OnKey"
  - "CMFCRibbonBaseElement.OnKey"
  - "CMFCRibbonBaseElement::OnKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnKey method"
ms.assetid: 8cc7811a-7fd1-456c-af80-79c08f2f2e8d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::OnKey
Called by the framework when the user presses a keytip and the ribbon element has the focus.  
  
## Syntax  
  
```  
virtual BOOL OnKey(  
   BOOL bIsMenuKey  
);  
```  
  
#### Parameters  
 [in] `bIsMenuKey`  
 `TRUE` if the keytip displays a pop-up menu; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the event was handled; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)