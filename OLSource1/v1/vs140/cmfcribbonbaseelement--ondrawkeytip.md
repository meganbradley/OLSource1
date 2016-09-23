---
title: "CMFCRibbonBaseElement::OnDrawKeyTip"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonBaseElement::OnDrawKeyTip
  - OnDrawKeyTip
  - CMFCRibbonBaseElement.OnDrawKeyTip
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawKeyTip method
ms.assetid: f0f98d06-00fb-4a83-9b95-437d7609916c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBaseElement::OnDrawKeyTip
Called by the framework to draw the keytip for the ribbon element.  
  
## Syntax  
  
```  
virtual void OnDrawKeyTip(  
   CDC* pDC,  
   const CRect& rect,  
   BOOL bIsMenu  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `rect`  
 Boundary rectangle for the keytip.  
  
 [in] `bIsMenu`  
 `TRUE` if the keytip is for a pop-up menu button; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)