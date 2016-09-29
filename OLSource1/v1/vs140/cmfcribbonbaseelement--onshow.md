---
title: "CMFCRibbonBaseElement::OnShow"
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
  - "OnShow"
  - "CMFCRibbonBaseElement.OnShow"
  - "CMFCRibbonBaseElement::OnShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonBaseElement::OnShow"
  - "CMFCRibbonBaseElement.OnShow"
ms.assetid: 18e65de4-aaba-4acd-a011-5aabb1ba16b4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::OnShow
Called by the framework to show or hide the ribbon element.  
  
## Syntax  
  
```  
virtual void OnShow(  
   BOOL bShow  
);  
```  
  
#### Parameters  
 [in] `bShow`  
 This parameter is not used.  
  
## Remarks  
 By default this method does nothing. Override this method to show or hide the ribbon element.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)