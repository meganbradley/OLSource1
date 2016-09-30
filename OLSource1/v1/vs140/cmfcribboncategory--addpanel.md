---
title: "CMFCRibbonCategory::AddPanel"
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
  - "CMFCRibbonCategory.AddPanel"
  - "CMFCRibbonCategory::AddPanel"
  - "AddPanel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPanel method"
ms.assetid: b92994b8-47d5-4e04-bb30-ada6514fcc40
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::AddPanel
Creates a ribbon panel for the ribbon category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the name of the new ribbon panel.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Handle to the default icon for the new ribbon panel.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to runtime class information for a custom ribbon panel.  
  
## Return Value  
 Pointer to the new ribbon panel if the method was successful; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the panel was not created.  
  
## Remarks  
 If you want to create a custom ribbon panel, you must specify its runtime class information in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The custom ribbon panel class must be derived from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class.  
  
 The default icon for the ribbon panel is displayed when there is insufficient space to display the ribbon elements.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#10](../vs140/codesnippet/CPP/cmfcribboncategory--addpanel_1.cpp)]  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)