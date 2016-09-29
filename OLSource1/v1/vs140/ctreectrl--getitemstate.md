---
title: "CTreeCtrl::GetItemState"
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
  - "CTreeCtrl::GetItemState"
  - "CTreeCtrl.GetItemState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemState method"
ms.assetid: 904aa149-1658-4d73-82eb-12d9f1d84089
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetItemState
Returns the state of the item specified by `hItem`.  
  
## Syntax  
  
```  
  
      UINT GetItemState(  
   HTREEITEM hItem,  
   UINT nStateMask   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of the item whose state is to be retrieved.  
  
 `nStateMask`  
 Mask indicating one or more states to be retrieved. For more information on possible values for `nStateMask`, see the discussion of the **state** and **stateMask** members of the [TVITEM](http://msdn.microsoft.com/library/windows/desktop/bb773456) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A **UINT** that holds the bitwise OR of the values specified by nStateMask. For information on possible values, see [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md). To find the value for a specific state, perform a bitwise AND operation of the state value and the return value, as shown in the following example.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#18](../vs140/codesnippet/CPP/ctreectrl--getitemstate_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Tree Control Item States Overview](../vs140/tree-control-item-states-overview.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)