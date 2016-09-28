---
title: "CMFCRibbonBaseElement::SetACCData"
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
  - "CMFCRibbonBaseElement::SetACCData"
  - "SetACCData"
  - "CMFCRibbonBaseElement.SetACCData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetACCData method"
ms.assetid: cb4859b9-1f0f-456e-9f61-fd98a4686816
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::SetACCData
Sets the accessibility data for the ribbon element.  
  
## Syntax  
  
```  
virtual BOOL SetACCData(  
   CWnd* pParent,  
   CAccessibilityData& data  
);   
```  
  
#### Parameters  
 `pParent`  
 The parent window for the ribbon element.  
  
 `data`  
 The accessibility data for the ribbon element.  
  
## Return Value  
 Always returns `TRUE`.  
  
## Remarks  
 By default this method sets the accessibility data for the ribbon element and always returns `TRUE`. Override this method to set the accessibility data and return a value that indicates success or failure.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)