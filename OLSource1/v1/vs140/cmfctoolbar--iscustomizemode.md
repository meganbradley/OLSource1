---
title: "CMFCToolBar::IsCustomizeMode"
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
  - "CMFCToolBar::IsCustomizeMode"
  - "CMFCToolBar.IsCustomizeMode"
  - "IsCustomizeMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsCustomizeMode method"
ms.assetid: 01f909c9-637a-4fd5-be29-981185b1e1fc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsCustomizeMode
Specifies whether the toolbar framework is in customization mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the framework is in customization mode; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 You can toggle customization mode by calling [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar--setcustomizemode.md).  
  
 The framework changes the mode when the user invokes the customization dialog box ([CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md)).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)