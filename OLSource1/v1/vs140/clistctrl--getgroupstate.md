---
title: "CListCtrl::GetGroupState"
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
  - "GetGroupState method"
  - "CListCtrl::GetGroupState"
  - "CListCtrl.GetGroupState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGroupState method"
ms.assetid: 3d496073-989c-4247-962b-c4c2b84bb651
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetGroupState
Retrieves the state for a specified group in the current list-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Zero-based index of a group.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Mask that specifies the state value to retrieve for the specified group. For more information, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of the [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769) structure.|  
  
## Return Value  
 The requested state for the specified group, or 0 if the group cannot be found.  
  
## Remarks  
 The return value is the result of a bitwise AND operation on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter and the value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member of an [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769) structure that represents the current list-view control.  
  
 This method sends the [LVM_GETGROUPSTATE](http://msdn.microsoft.com/library/windows/desktop/bb774936) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see the [ListView_GetGroupState](http://msdn.microsoft.com/library/windows/desktop/bb761288) macro.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETGROUPSTATE](http://msdn.microsoft.com/library/windows/desktop/bb774936)   
 [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769)   
 [ListView_GetGroupState](http://msdn.microsoft.com/library/windows/desktop/bb761288)