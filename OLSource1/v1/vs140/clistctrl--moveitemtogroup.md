---
title: "CListCtrl::MoveItemToGroup"
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
  - "CListCtrl.MoveItemToGroup"
  - "MoveItemToGroup"
  - "CListCtrl::MoveItemToGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveItemToGroup method"
ms.assetid: 124a649a-b898-4c1b-8fc9-f8b338522cc0
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::MoveItemToGroup
Moves the specified item into the specified group.  
  
## Syntax  
  
```  
void MoveItemToGroup(  
   int idItemFrom,  
   int idGroupTo  
);  
```  
  
#### Parameters  
 [in] `idItemFrom`  
 The index of the item to be moved.  
  
 [in] `idGroupTo`  
 The identifier of the group the item will be moved to.  
  
## Remarks  
  
> [!NOTE]
>  This method currently is not implemented.  
  
 This method emulates the functionality of the [LVM_MOVEITEMTOGROUP](http://msdn.microsoft.com/library/windows/desktop/bb761143) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)