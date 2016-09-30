---
title: "CMFCRibbonBar::AddMainCategory"
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
  - "CMFCRibbonBar::AddMainCategory"
  - "CMFCRibbonBar.AddMainCategory"
  - "AddMainCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddMainCategory method"
ms.assetid: f2a9c3dc-236e-4ec6-97cf-b54b1194b45c
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::AddMainCategory
Creates a new main ribbon category for the ribbon bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the main ribbon category.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Resource ID of small images.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Resource ID of large images.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of small images.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The size of large images.  
  
## Return Value  
 Pointer to the new main ribbon category if the method was successful; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If a main ribbon category already exists, it is deleted.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#4](../vs140/codesnippet/CPP/cmfcribbonbar--addmaincategory_1.cpp)]  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)