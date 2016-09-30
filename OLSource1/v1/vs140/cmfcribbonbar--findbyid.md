---
title: "CMFCRibbonBar::FindByID"
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
  - "FindByID"
  - "CMFCRibbonBar::FindByID"
  - "CMFCRibbonBar.FindByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByID method"
ms.assetid: dde66b4b-22d8-452e-bf15-b63ebe503b5e
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::FindByID
Retrieves a pointer to the ribbon element that has the specified command ID and search values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Command ID for a ribbon element.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to search visible ribbon elements only; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to search all ribbon elements.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to exclude quick access toolbar elements from the search; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 A pointer to a ribbon element if it has the specified command ID and search values; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 A ribbon element is any ribbon control that can be added to the ribbon, such as a ribbon button, or a ribbon category, or a ribbon slider.  
  
 In general, there can be more than one ribbon element that has the same command ID. If you want to obtain pointers to all ribbon elements that use a specified command ID, use the [CMFCRibbonBar::GetElementsByID](../vs140/cmfcribbonbar--getelementsbyid.md) method.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)