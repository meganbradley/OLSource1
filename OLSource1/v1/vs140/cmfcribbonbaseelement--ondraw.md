---
title: "CMFCRibbonBaseElement::OnDraw"
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
  - "OnDraw"
  - "CMFCRibbonBaseElement.OnDraw"
  - "CMFCRibbonBaseElement::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: 863414a9-36cf-46cf-a867-6076b1face6d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::OnDraw
Called by the framework to draw the ribbon element.  
  
## Syntax  
  
```  
virtual void OnDraw(  
   CDC* pDC   
) = 0;  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
## Remarks  
 Override this method in a derived class if you want to customize the drawing of a specific ribbon element.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)