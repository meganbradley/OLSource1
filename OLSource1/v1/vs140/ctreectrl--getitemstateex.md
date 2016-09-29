---
title: "CTreeCtrl::GetItemStateEx"
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
  - "CTreeCtrl::GetItemStateEx"
  - "GetItemStateEx method"
  - "CTreeCtrl.GetItemStateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemStateEx method"
ms.assetid: 43ed8ce0-7d83-48e9-abbc-732c9b6b5209
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetItemStateEx
Retrieves the extended state of the specified item in the current tree-view control.  
  
## Syntax  
  
```  
UINT GetItemStateEx(  
     HTREEITEM hItem  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `hItem`|Handle to a tree-view control item.|  
  
## Return Value  
 The extended state of the item. For more information, see the `uStateEx` member of the [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459) structure.  
  
## Remarks  
 This method sends the [TVM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb773596) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. That message returns the [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459) structure that describes the tree-view control item, and this method retrieves the `uStateEx` member from that structure.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetItemStateEx](../vs140/ctreectrl--setitemstateex.md)   
 [TVM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb773596)   
 [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459)