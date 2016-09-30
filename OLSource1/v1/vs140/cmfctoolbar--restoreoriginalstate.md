---
title: "CMFCToolBar::RestoreOriginalState"
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
  - "CMFCToolBar.RestoreOriginalstate"
  - "CMFCToolBar::RestoreOriginalstate"
  - "RestoreOriginalstate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreOriginalstate method"
ms.assetid: 41eb2fea-890c-46fe-b393-c70e67ad1b88
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::RestoreOriginalState
Restores the original state of a toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the method succeeds, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the method fails or the toolbar is user-defined.  
  
## Remarks  
 This method loads the toolbar from the resource file by using the [CMFCToolBar::LoadToolBar](../vs140/cmfctoolbar--loadtoolbar.md) method.  
  
 The framework calls this method when the user chooses the **Reset All** button on the **Toolbars** page of a customization dialog box.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::LoadToolBar](../vs140/cmfctoolbar--loadtoolbar.md)