---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonCategoryCaption"
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
  - "CMFCVisualManagerOffice2003.OnDrawRibbonCategoryCaption"
  - "OnDrawRibbonCategoryCaption"
  - "CMFCVisualManagerOffice2003::OnDrawRibbonCategoryCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonCategoryCaption method"
ms.assetid: 24db8e4c-c2e4-46aa-8ebc-f13bbe754b63
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonCategoryCaption
The framework calls this method when it draws the caption bar for a ribbon category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context of the ribbon category.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a caption bar. The visual manager draws this [CMFCRibbonContextCaption](../vs140/cmfcribboncontextcaption-class.md).  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the color of the text on the caption bar.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of the caption bar for a ribbon category.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)