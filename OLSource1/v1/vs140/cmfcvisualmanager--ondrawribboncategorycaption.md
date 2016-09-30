---
title: "CMFCVisualManager::OnDrawRibbonCategoryCaption"
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
  - "CMFCVisualManager.OnDrawRibbonCategoryCaption"
  - "CMFCVisualManager::OnDrawRibbonCategoryCaption"
  - "OnDrawRibbonCategoryCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonCategoryCaption method"
ms.assetid: 0ef3fc40-2410-4bf7-a651-16f94b012fc4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonCategoryCaption
The framework calls this method when it draws the caption bar for a ribbon category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The drawing context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a caption bar. The visual manager draws this [CMFCRibbonContextCaption Class](../vs140/cmfcribboncontextcaption-class.md) object.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the color of the text on the caption bar.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of the caption bar for a ribbon category. For more information about the caption bar, see [CMFCRibbonContextCaption Class](../vs140/cmfcribboncontextcaption-class.md).  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonContextCaption Class](../vs140/cmfcribboncontextcaption-class.md)