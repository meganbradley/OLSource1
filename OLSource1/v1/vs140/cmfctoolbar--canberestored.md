---
title: "CMFCToolBar::CanBeRestored"
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
  - "CMFCToolBar::CanBeRestored"
  - "CMFCToolBar.CanBeRestored"
  - "CanBeRestored"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeRestored method"
ms.assetid: 86b73e4f-c303-4a9c-90a9-573c2141ab18
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CanBeRestored
Determines whether the system can restore a toolbar to its original state after customization.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the toolbar can be restored from the application resources; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method to determine whether a toolbar can be returned to its original state after customization. The original state is loaded from the application resources.  
  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the **Toolbars** page of the customization dialog box enables the **Reset** button for the selected toolbar.  
  
 The default implementation returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the original resource ID of the toolbar when it was loaded is non-zero. Usually, only user-defined toolbars cannot be restored.  
  
 You can override the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method to customize this behavior in derived classes.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)