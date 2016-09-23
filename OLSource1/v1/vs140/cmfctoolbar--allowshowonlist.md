---
title: "CMFCToolBar::AllowShowOnList"
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
  - AllowShowOnList
  - CMFCToolBar::AllowShowOnList
  - CMFCToolBar.AllowShowOnList
dev_langs: 
  - C++
helpviewer_keywords: 
  - AllowShowOnList method
ms.assetid: 6e56df84-4881-4fc7-99b4-7c26b96517fb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::AllowShowOnList
Determines whether the toolbar is displayed in the list of toolbars on the **Toolbars** pane of the **Customize** dialog box.  
  
## Syntax  
  
```  
virtual BOOL AllowShowOnList() const;  
```  
  
## Return Value  
 `TRUE` if the toolbar object can be displayed in the list box on the toolbar customization page; otherwise `FALSE`.  
  
## Remarks  
 This method is called by the framework to determine whether the list on the toolbar customization page should include a particular object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md).  
  
 The default implementation always returns `TRUE`. Override this method when you do not want a toolbar to appear in the toolbars list in the customization dialog box.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)