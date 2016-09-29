---
title: "CListCtrl::MapIDToIndex"
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
  - "MapIDToIndex method"
  - "CListCtrl::MapIDToIndex"
  - "CListCtrl.MapIDToIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapIDToIndex method"
ms.assetid: a70a3b8a-570a-4bb6-8b03-89d9a2012d2e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::MapIDToIndex
Maps the unique ID of an item in the current list-view control to an index.  
  
## Syntax  
  
```  
UINT MapIDToIndex(  
     UINT id  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `id`|The unique ID of an item.|  
  
## Return Value  
 The current index for the specified ID.  
  
## Remarks  
 A list-view control internally tracks items by index. This can present problems because indexes can change during the control's lifetime. The list-view control can tag an item with an ID when the item is created and you can use this ID to guarantee uniqueness during the lifetime of the list-view control.  
  
 Note that in a multithreaded environment the index is guaranteed only on the thread that hosts the list-view control, not on background threads.  
  
 This method sends the [LVM_MAPIDTOINDEX](http://msdn.microsoft.com/library/windows/desktop/bb761137) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_MAPIDTOINDEX](http://msdn.microsoft.com/library/windows/desktop/bb761137)   
 [CListCtrl::MapIndexToID](../vs140/clistctrl--mapindextoid.md)