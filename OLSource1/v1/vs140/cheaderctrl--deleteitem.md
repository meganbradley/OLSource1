---
title: "CHeaderCtrl::DeleteItem"
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
  - CHeaderCtrl::DeleteItem
  - CHeaderCtrl.DeleteItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - DeleteItem method
ms.assetid: 750ce05f-4919-48ea-b734-823efc219ea8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHeaderCtrl::DeleteItem
Deletes an item from a header control.  
  
## Syntax  
  
```  
  
      BOOL DeleteItem(  
   int nPos   
);  
```  
  
#### Parameters  
 `nPos`  
 Specifies the zero-based index of the item to delete.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#5](../vs140/codesnippet/CPP/cheaderctrl--deleteitem_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::InsertItem](../vs140/cheaderctrl--insertitem.md)