---
title: "CMFCRibbonBaseElement::OnDrawMenuImage"
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
  - OnDrawMenuImage
  - CMFCRibbonBaseElement.OnDrawMenuImage
  - CMFCRibbonBaseElement::OnDrawMenuImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawMenuImage method
ms.assetid: 0190b36f-5b12-49ae-9ced-662494d94528
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBaseElement::OnDrawMenuImage
Called by the framework when the menu image for the ribbon element is drawn.  
  
## Syntax  
  
```  
virtual BOOL OnDrawMenuImage(  
   CDC* pDC,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `rect`  
 Menu image rectangle.  
  
## Return Value  
 Always returns `TRUE` to indicate the image was drawn.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)