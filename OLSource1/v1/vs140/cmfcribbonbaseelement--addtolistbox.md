---
title: "CMFCRibbonBaseElement::AddToListBox"
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
  - "CMFCRibbonBaseElement.AddToListBox"
  - "AddToListBox"
  - "CMFCRibbonBaseElement::AddToListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToListBox method"
ms.assetid: 4a352402-1c6b-44d9-88ca-e2bc2a72dce9
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::AddToListBox
Adds a ribbon element to the specified ribbon commands list box.  
  
## Syntax  
  
```  
virtual int AddToListBox(  
   CMFCRibbonCommandsListBox* pWndListBox,  
   BOOL bDeep  
);  
```  
  
#### Parameters  
 [in] `pWndListBox`  
 Pointer to a commands list box.  
  
 [in] `bDeep`  
 This parameter is not used.  
  
## Return Value  
 The zero-based index of the added ribbon element.  
  
## Remarks  
 The framework adds ribbon elements to a commands list box to enable the user to customize the user interface.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)