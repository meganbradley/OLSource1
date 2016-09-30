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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to reduce the display size of the ribbon element; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to increase the display size of the ribbon element.  
  
## Remarks  
 The following table summarizes the logic for this method.  
  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Current ribbon element size|New ribbon element size|  
|--------------------|---------------------------------|-----------------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Compact|No change.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Intermediate|Compact if it is possible.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Large|Intermediate if it is possible.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Compact|Intermediate if it is possible; otherwise large.|  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)