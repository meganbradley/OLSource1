---
title: "CToolBar::SetHeight"
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
  - SetHeight
  - CToolBar.SetHeight
  - CToolBar::SetHeight
dev_langs: 
  - C++
helpviewer_keywords: 
  - toolbars [C++], constructing or destroying
  - SetHeight method
  - toolbars [C++], size
  - CToolBar class, construction/destruction
ms.assetid: c824092b-3647-41c3-b275-c2e1144eee6a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBar::SetHeight
This member function sets the toolbar's height to the value, in pixels, specified in `cyHeight`.  
  
## Syntax  
  
```  
  
      void SetHeight(  
   int cyHeight   
);  
```  
  
#### Parameters  
 `cyHeight`  
 The height in pixels of the toolbar.  
  
## Remarks  
 After calling [SetSizes](../vs140/ctoolbar--setsizes.md), use this member function to override the standard toolbar height. If the height is too small, the buttons will be clipped at the bottom.  
  
 If this function is not called, the framework uses the size of the button to determine the toolbar height.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::SetSizes](../vs140/ctoolbar--setsizes.md)   
 [CToolBar::SetButtonInfo](../vs140/ctoolbar--setbuttoninfo.md)   
 [CToolBar::SetButtons](../vs140/ctoolbar--setbuttons.md)