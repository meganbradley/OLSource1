---
title: "CToolBar::CommandToIndex"
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
  - CommandToIndex
  - CToolBar.CommandToIndex
  - CToolBar::CommandToIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - CommandToIndex method
  - CToolBar class, attributes
  - button index
  - indexes, toolbar buttons
  - toolbars [C++]
ms.assetid: 5eedd98f-0431-41f6-ab0f-3606a4c8fc8c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBar::CommandToIndex
This member function returns the index of the first toolbar button, starting at position 0, whose command ID matches `nIDFind`.  
  
## Syntax  
  
```  
  
      int CommandToIndex(  
   UINT nIDFind   
) const;  
```  
  
#### Parameters  
 `nIDFind`  
 Command ID of a toolbar button.  
  
## Return Value  
 The index of the button, or –1 if no button has the given command ID.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::GetItemID](../vs140/ctoolbar--getitemid.md)