---
title: "CMFCToolBar::GetOrigResetButtons"
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
  - "GetOrigResetButtons"
  - "CMFCToolBar::GetOrigResetButtons"
  - "CMFCToolBar.GetOrigResetButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOrigResetButtons method"
ms.assetid: fa4eff78-3ac1-4fba-96e4-32c55cd255b8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetOrigResetButtons
Retrieves the collection of non-customized reset buttons of the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the list of non-customized reset buttons of the toolbar.  
  
## Remarks  
 When the user clicks the **Reset** button during customization mode, the framework uses this method to restore buttons that were removed from the toolbar.  
  
 The [CMFCToolBar::SetButtons](../vs140/cmfctoolbar--setbuttons.md) method adds a copy of each toolbar button to the list of original reset buttons after it calls the [CMFCToolBar::OnReset](../vs140/cmfctoolbar--onreset.md) method. You can override the [CMFCToolBar::OnReset](../vs140/cmfctoolbar--onreset.md) method to customize the appearance of buttons after the user presses the **Reset** button.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetButtons](../vs140/cmfctoolbar--setbuttons.md)   
 [CMFCToolBar::OnReset](../vs140/cmfctoolbar--onreset.md)