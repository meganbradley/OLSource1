---
title: "CMFCRibbonBaseElement::OnSetFocus"
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
  - "OnSetFocus"
  - "CMFCRibbonBaseElement.OnSetFocus"
  - "CMFCRibbonBaseElement::OnSetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetFocus method"
ms.assetid: 041574df-3a83-491f-b308-7b8d6142eb84
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::OnSetFocus
Called by the framework when a ribbon element receives or loses the input focus.  
  
## Syntax  
  
```  
virtual void OnSetFocus(  
   BOOL B   
);  
```  
  
## Remarks  
 Override this method in a derived class if you want your application to handle a change in the focus of a ribbon element.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)