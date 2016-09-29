---
title: "CMFCRibbonBaseElement::GetParentWnd"
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
  - "CMFCRibbonBaseElement::GetParentWnd"
  - "CMFCRibbonBaseElement.GetParentWnd"
  - "GetParentWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentWnd method"
ms.assetid: 00ed4322-5f93-44c6-a5ca-c0cbfce4dac1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::GetParentWnd
Retrieves the parent window for the ribbon element.  
  
## Syntax  
  
```  
virtual CWnd* GetParentWnd() const;  
```  
  
## Return Value  
 A pointer to the parent window for the ribbon element if the method was successful; otherwise, `NULL`.  
  
## Remarks  
 The parent window for a ribbon element is a [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) or a [CMFCRibbonPanelMenuBar](assetId:///7bd4b986-8b7b-493e-9746-bd3161b78581).  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)