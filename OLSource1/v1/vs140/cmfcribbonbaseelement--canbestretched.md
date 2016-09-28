---
title: "CMFCRibbonBaseElement::CanBeStretched"
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
  - "CanBeStretched"
  - "CMFCRibbonBaseElement.CanBeStretched"
  - "CMFCRibbonBaseElement::CanBeStretched"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeStretched method"
ms.assetid: 13218664-0ca5-40c6-b8ed-fa282c44e8bd
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::CanBeStretched
Indicates whether the height of the ribbon element can increase vertically to the height of a ribbon row.  
  
## Syntax  
  
```  
virtual BOOL CanBeStretched();  
```  
  
## Return Value  
 Always returns `TRUE`.  
  
## Remarks  
 By default this method always returns `TRUE`. Override this method to indicate whether the height of the ribbon element can increase vertically to the height of a ribbon row.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)