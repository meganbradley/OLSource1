---
title: "CMFCRibbonBaseElement::FindByOriginal"
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
  - "CMFCRibbonBaseElement.FindByOriginal"
  - "CMFCRibbonBaseElement::FindByOriginal"
  - "FindByOriginal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByOriginal method"
ms.assetid: b211fa11-0295-4352-816e-2596e23dfb9d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::FindByOriginal
Retrieves a pointer to the current ribbon element if its original ribbon element matches the specified ribbon element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
## Return Value  
 A pointer to the ribbon element if its original ribbon element matches the specified ribbon element; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Ribbon elements that are copied to another container retain a pointer to the original ribbon element.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)