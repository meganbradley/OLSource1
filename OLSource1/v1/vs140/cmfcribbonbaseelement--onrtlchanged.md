---
title: "CMFCRibbonBaseElement::OnRTLChanged"
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
  - "CMFCRibbonBaseElement.OnRTLChanged"
  - "OnRTLChanged"
  - "CMFCRibbonBaseElement::OnRTLChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRTLChanged method"
ms.assetid: fbe49986-21e8-4dc4-8c6c-f3d0dd0808c2
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::OnRTLChanged
Called by the framework when the layout changes direction.  
  
## Syntax  
  
```  
virtual void OnRTLChanged(  
   BOOL bIsRTL  
);  
```  
  
#### Parameters  
 [in] `bIsRTL`  
 This parameter is not used.  
  
## Remarks  
 By default this method does nothing. Override this method to adjust the ribbon element when the layout changes direction. The default layout direction is left-to-right.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)