---
title: "CMFCRibbonBar::GetElementsByID"
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
  - "CMFCRibbonBar.GetElementsByID"
  - "GetElementsByID"
  - "CMFCRibbonBar::GetElementsByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElementsByID method"
ms.assetid: 52368660-9367-4953-8ec3-3417aa971827
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::GetElementsByID
Retrieves an array of pointers to all ribbon elements that have a specific command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Command ID of a ribbon element.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An array of pointers to ribbon elements.  
  
## Remarks  
 Multiple ribbon elements can have the same command ID because some ribbon elements can be copied to the quick access toolbar.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)