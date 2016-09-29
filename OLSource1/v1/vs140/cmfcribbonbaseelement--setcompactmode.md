---
title: "CMFCRibbonBaseElement::SetCompactMode"
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
  - "CMFCRibbonBaseElement::SetCompactMode"
  - "CMFCRibbonBaseElement.SetCompactMode"
  - "SetCompactMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCompactMode method"
ms.assetid: a4fdb2a1-ca48-40ec-89d8-1b268ea3b6ac
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::SetCompactMode
Sets the display size for the ribbon element.  
  
## Syntax  
  
```  
virtual void SetCompactMode(  
   BOOL bCompactMode = TRUE  
);  
```  
  
#### Parameters  
 [in] `bCompactMode`  
 `TRUE` to reduce the display size of the ribbon element; `FALSE` to increase the display size of the ribbon element.  
  
## Remarks  
 The following table summarizes the logic for this method.  
  
|`bCompactMode`|Current ribbon element size|New ribbon element size|  
|--------------------|---------------------------------|-----------------------------|  
|`TRUE`|Compact|No change.|  
|`TRUE`|Intermediate|Compact if it is possible.|  
|`TRUE`|Large|Intermediate if it is possible.|  
|`FALSE`|Compact|Intermediate if it is possible; otherwise large.|  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)