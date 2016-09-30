---
title: "CMFCToolBar::SetCustomizeMode"
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
  - "CMFCToolBar::SetCustomizeMode"
  - "SetCustomizeMode"
  - "CMFCToolBar.SetCustomizeMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCustomizeMode method"
ms.assetid: 79cf3cee-cb0b-4bc0-bcab-799ede9ae720
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetCustomizeMode
Enables or disables customization mode for all toolbars in the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to enable or disable customization mode. Set this parameter to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to enable customization mode or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to disable it.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if calling this method changes the customization mode; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method adjusts the layout of and redraws each toolbar in the application. Call the [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md) method to determine whether the application is in customization mode,  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md)