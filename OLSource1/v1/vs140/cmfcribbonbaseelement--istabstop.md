---
title: "CMFCRibbonBaseElement::IsTabStop"
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
  - "IsTabStop"
  - "CMFCRibbonBaseElement::IsTabStop"
  - "CMFCRibbonBaseElement.IsTabStop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsTabStop method"
ms.assetid: a1e3e7d0-35b0-4590-bd7b-e14ab4802d8c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::IsTabStop
Indicates whether the ribbon element can be selected with the keyboard.  
  
## Syntax  
  
```  
virtual BOOL IsTabStop() const;  
```  
  
## Return Value  
 Always returns `TRUE`.  
  
## Remarks  
 By default this method always returns `TRUE`. Override this method to indicate whether the ribbon element can be selected with the keyboard.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)