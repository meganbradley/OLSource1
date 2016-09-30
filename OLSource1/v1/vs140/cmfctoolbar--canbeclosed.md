---
title: "CMFCToolBar::CanBeClosed"
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
  - "CanBeClosed"
  - "CMFCToolBar.CanBeClosed"
  - "CMFCToolBar::CanBeClosed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeClosed method"
ms.assetid: f2e642b1-57df-4476-9d00-b11da0044351
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CanBeClosed
Specifies whether a user can close the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the toolbar can be closed by the user; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method to determine whether the user can close a toolbar. If the method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the framework enables the SC_CLOSE command in the system menu of the toolbar and the user can close the toolbar by using a check box in the list of toolbars in the customization dialog box.  
  
 The default implementation returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) to make toolbar objects that cannot be closed by the user.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)