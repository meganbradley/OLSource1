---
title: "CMFCToolBar::GetOrigButtons"
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
  - "CMFCToolBar.GetOrigButtons"
  - "CMFCToolBar::GetOrigButtons"
  - "GetOrigButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOrigButtons method"
ms.assetid: 76ccb57c-de94-4b2f-8079-b02faf9057ff
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetOrigButtons
Retrieves the collection of non-customized buttons of the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the list of non-customized buttons of the toolbar.  
  
## Remarks  
 The framework creates a copy of toolbar buttons before they are customized by the user. The [CMFCToolBar::SetButtons](../vs140/cmfctoolbar--setbuttons.md) method adds a copy of each button in the provided array to the list of original buttons. The [CMFCToolBar::RestoreOriginalstate](../vs140/cmfctoolbar--restoreoriginalstate.md) method restores the original state of the toolbar by loading it from the resource file.  
  
 To set the list of original buttons for your toolbar, call the [CMFCToolBar::SetOrigButtons](../vs140/cmfctoolbar--setorigbuttons.md) method.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetButtons](../vs140/cmfctoolbar--setbuttons.md)   
 [CMFCToolBar::RestoreOriginalstate](../vs140/cmfctoolbar--restoreoriginalstate.md)   
 [CMFCToolBar::SetOrigButtons](../vs140/cmfctoolbar--setorigbuttons.md)