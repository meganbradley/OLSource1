---
title: "CMFCRibbonBaseElement::OnProcessKey"
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
  - "CMFCRibbonBaseElement.OnProcessKey"
  - "OnProcessKey"
  - "CMFCRibbonBaseElement::OnProcessKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnProcessKey method"
ms.assetid: 7521e317-0521-43ef-b91f-b110a7f8d1d1
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::OnProcessKey
Called by the framework when the user presses a shortcut key.  
  
## Syntax  
  
```  
virtual BOOL OnProcessKey(  
   UINT nChar  
);  
```  
  
#### Parameters  
 [in] `nChar`  
 This parameter is not used.  
  
## Return Value  
 Always returns `FALSE`.  
  
## Remarks  
 Override this method if you want the ribbon element to process a shortcut key.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)