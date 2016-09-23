---
title: "CMFCRibbonBaseElement::OnCalcTextSize"
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
  - CMFCRibbonBaseElement.OnCalcTextSize
  - CMFCRibbonBaseElement::OnCalcTextSize
  - OnCalcTextSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnCalcTextSize method
ms.assetid: b8b621a1-c4eb-4ac8-956e-a5cbb7a3ab26
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBaseElement::OnCalcTextSize
Calculates the size of the text for the ribbon element.  
  
## Syntax  
  
```  
virtual void OnCalcTextSize(  
   CDC* pDC  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 This parameter is not used.  
  
## Remarks  
 By default this method does nothing. Override this method to calculate the size of the text for the ribbon element.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)