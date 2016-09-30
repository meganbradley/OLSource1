---
title: "CMFCRibbonBar::FindByData"
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
  - "CMFCRibbonBar.FindByData"
  - "CMFCRibbonBar::FindByData"
  - "FindByData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByData method"
ms.assetid: 98bede59-041c-435d-bc74-07d68ac98bff
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::FindByData
Retrieves a pointer to a ribbon element if it has the specified data and visibility.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The data associated with a ribbon element.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to search visible ribbon elements only; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to search all ribbon elements.  
  
## Return Value  
 A pointer to a ribbon element if it has the specified data and visibility; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 A ribbon element is any control that you can add to the ribbon, such as a ribbon button, or a ribbon category, or a ribbon slider.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)