---
title: "CMFCRibbonSeparator::AddToListBox"
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
  - "CMFCRibbonSeparator::AddToListBox"
  - "AddToListBox"
  - "CMFCRibbonSeparator.AddToListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToListBox method"
ms.assetid: dd2e39ff-bc09-4188-902a-57631bf52080
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonSeparator::AddToListBox
Adds a separator to the **Commands** list in the **Customize** dialog box.  
  
## Syntax  
  
```  
virtual int AddToListBox(  
   CMFCRibbonCommandsListBox* pWndListBox,  
   BOOL bDeep  
);  
```  
  
#### Parameters  
 [in] `pWndListBox`  
 A pointer to the **Commands** list where the separator is added.  
  
 [in] `bDeep`  
 Ignored.  
  
## Return Value  
 Zero-based index to the string in the list box specified by `pWndListBox`.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonSeparator Class](../vs140/cmfcribbonseparator-class.md)