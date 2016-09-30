---
title: "CMFCRibbonPanel::ReplaceByID"
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
  - "ReplaceByID"
  - "CMFCRibbonPanel::ReplaceByID"
  - "CMFCRibbonPanel.ReplaceByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReplaceByID method"
ms.assetid: 4072e987-238c-41a6-8355-c00e71c6e1f8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::ReplaceByID
Replaces one element with another based on a specified command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the command ID of the element to replace.  
  
 [in] [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A valid pointer to the element that will replace the original element.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the original ribbon element has been replaced successfully by the new ribbon element; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the ribbon element was not replaced or if no element with the specified command ID actually exists.  
  
## Remarks  
 To replace a ribbon element based on position, call [CMFCRibbonPanel::Replace](../vs140/cmfcribbonpanel--replace.md).  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)