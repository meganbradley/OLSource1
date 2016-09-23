---
title: "CListCtrl::IsItemVisible"
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
  - CListCtrl.IsItemVisible
  - IsItemVisible method
  - CListCtrl::IsItemVisible
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsItemVisible method
ms.assetid: aa0995c0-fbfa-4bc3-8995-8a3154f74546
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::IsItemVisible
Indicates whether a specified item in the current list-view control is visible.  
  
## Syntax  
  
```  
BOOL IsItemVisible(  
     int index  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `index`|Zero-based index of an item in the current list-view control.|  
  
## Return Value  
 `true` if the specified item is visible;otherwise, `false`.  
  
## Remarks  
 This method sends the [LVM_ISITEMVISIBLE](http://msdn.microsoft.com/library/windows/desktop/bb761135) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_ISITEMVISIBLE](http://msdn.microsoft.com/library/windows/desktop/bb761135)