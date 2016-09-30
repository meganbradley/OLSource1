---
title: "CMFCToolBar::AllowChangeTextLabels"
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
  - "AllowChangeTextLabels"
  - "CMFCToolBar.AllowChangeTextLabels"
  - "CMFCToolBar::AllowChangeTextLabels"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AllowChangeTextLabels method"
ms.assetid: 7e5d0e7d-0428-46a0-ac3c-ce270724c390
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::AllowChangeTextLabels
Specifies whether text labels can be shown under images on the toolbar buttons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if it is allowed to display text labels below images; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is called by the customization dialog box to determine whether to enable a **Show text labels** check-box on the **Toolbars** page for the selected toolbar.  
  
 The default implementation returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Override this method in an object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) and return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when you do not want the user to decide whether text labels are displayed on toolbar buttons under the images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)