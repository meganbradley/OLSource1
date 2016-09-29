---
title: "CHeaderCtrl::SetItem"
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
  - "CHeaderCtrl::SetItem"
  - "CHeaderCtrl.SetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItem method"
ms.assetid: f293d1f1-daf8-486e-b3e4-66c11bd6b925
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::SetItem
Sets the attributes of the specified item in a header control.  
  
## Syntax  
  
```  
  
      BOOL SetItem(  
   int nPos,  
   HDITEM* pHeaderItem   
);  
```  
  
#### Parameters  
 `nPos`  
 The zero-based index of the item to be manipulated.  
  
 `pHeaderItem`  
 Pointer to an [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure that contains information about the new item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CHeaderCtrl::GetItem](../vs140/cheaderctrl--getitem.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::GetItem](../vs140/cheaderctrl--getitem.md)   
 [CHeaderCtrl::GetItemCount](../vs140/cheaderctrl--getitemcount.md)