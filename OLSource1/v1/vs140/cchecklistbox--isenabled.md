---
title: "CCheckListBox::IsEnabled"
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
  - IsEnabled
  - CCheckListBox::IsEnabled
  - CCheckListBox.IsEnabled
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsEnabled method
ms.assetid: de8b16f1-78ab-4f22-858e-9ca3126967eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCheckListBox::IsEnabled
Call this function to determine whether an item is enabled.  
  
## Syntax  
  
```  
  
      BOOL IsEnabled(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 Index of the item.  
  
## Return Value  
 Nonzero if the item is enabled; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::Enable](../vs140/cchecklistbox--enable.md)