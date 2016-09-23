---
title: "CTreeCtrl::GetItemText"
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
  - CTreeCtrl::GetItemText
  - CTreeCtrl.GetItemText
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemText method
ms.assetid: 0403cb14-c4ea-4ffb-9613-9f872e334c89
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::GetItemText
Returns the text of the item specified by `hItem`.  
  
## Syntax  
  
```  
  
      CString GetItemText(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of the item whose text is to be retrieved.  
  
## Return Value  
 A `CString` object containing the item's text.  
  
## Example  
 See the example for [CTreeCtrl::GetNextItem](../vs140/ctreectrl--getnextitem.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetItemText](../vs140/ctreectrl--setitemtext.md)