---
title: "CMFCRibbonBaseElement::HitTest"
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
  - "CMFCRibbonBaseElement::HitTest"
  - "CMFCRibbonBaseElement.HitTest"
  - "HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 91766536-593f-4fed-976b-1b6abb201d43
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::HitTest
Retrieves a pointer to the ribbon element if the specified point is located in it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
## Return Value  
 A pointer to the ribbon element if it exists; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 By default this method always returns a valid pointer to the ribbon element when it exists. Override this method to indicate if the point resides in the ribbon element.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)