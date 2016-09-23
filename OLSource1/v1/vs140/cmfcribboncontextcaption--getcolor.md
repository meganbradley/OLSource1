---
title: "CMFCRibbonContextCaption::GetColor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetColor
  - CMFCRibbonContextCaption::GetColor
  - CMFCRibbonContextCaption.GetColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetColor method
ms.assetid: f2406fc4-c2dc-41c0-8ad6-5559db4b4b18
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonContextCaption::GetColor
Returns the background color of the caption.  
  
## Syntax  
  
```  
AFX_RibbonCategoryColor GetColor() const;  
```  
  
## Return Value  
 The returned value can be one of the following enumerated values:  
  
-   `AFX_CategoryColor_None`  
  
-   `AFX_CategoryColor_Red`  
  
-   `AFX_CategoryColor_Orange`  
  
-   `AFX_CategoryColor_Yellow`  
  
-   `AFX_CategoryColor_Green`  
  
-   `AFX_CategoryColor_Blue`  
  
-   `AFX_CategoryColor_Indigo`  
  
-   `AFX_CategoryColor_Violet`  
  
## Remarks  
 The color of the caption can be set by calling [CMFCRibbonCategory::SetTabColor](../vs140/cmfcribboncategory--settabcolor.md) or [CMFCRibbonBar::AddContextCategory](../vs140/cmfcribbonbar--addcontextcategory.md).  
  
## Requirements  
 **Header:** afxRibbonBar.h  
  
## See Also  
 [CMFCRibbonContextCaption Class](../vs140/cmfcribboncontextcaption-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)