---
title: "CMFCToolBar::RemoveButton"
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
  - RemoveButton
  - CMFCToolBar::RemoveButton
  - CMFCToolBar.RemoveButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveButton method
ms.assetid: 4200d498-1c38-4321-b1ee-77e87823b174
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::RemoveButton
Removes from the toolbar the button that has the specified index.  
  
## Syntax  
  
```  
virtual BOOL RemoveButton(  
   int iIndex   
);  
```  
  
#### Parameters  
 [in] `iIndex`  
 Specifies the zero-based index of the button to remove.  
  
## Return Value  
 `TRUE` if the method succeeds, or `FALSE` if the specified index is invalid or the index refers to the **Customize** button.  
  
## Remarks  
 This method updates additional toolbar attributes that are affected by the removal of the button. For example, this method removes nonessential separators from the toolbar and rebuilds the table of shortcut keys.  
  
 For more information about the **Customize** button, see [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md)