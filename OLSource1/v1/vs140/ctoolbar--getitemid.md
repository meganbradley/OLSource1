---
title: "CToolBar::GetItemID"
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
  - "CToolBar::GetItemID"
  - "GetItemID"
  - "CToolBar.GetItemID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemID method"
  - "CToolBar class, attributes"
  - "toolbars [C++], attributes"
ms.assetid: 1330b82f-9ea1-4978-a247-4d6e68c58dbb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::GetItemID
This member function returns the command ID of the button or separator specified by `nIndex`.  
  
## Syntax  
  
```  
  
      UINT GetItemID(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Index of the item whose ID is to be retrieved.  
  
## Return Value  
 The command ID of the button or separator specified by `nIndex`.  
  
## Remarks  
 Separators return **ID_SEPARATOR**.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::CommandToIndex](../vs140/ctoolbar--commandtoindex.md)   
 [CControlBar::GetCount](../vs140/ccontrolbar--getcount.md)