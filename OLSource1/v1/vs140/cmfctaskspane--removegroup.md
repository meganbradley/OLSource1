---
title: "CMFCTasksPane::RemoveGroup"
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
  - "CMFCTasksPane.RemoveGroup"
  - "RemoveGroup"
  - "CMFCTasksPane::RemoveGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveGroup method"
ms.assetid: a5ac7750-0bca-44dd-8ed1-698941feea9a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::RemoveGroup
Removes a group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the group to remove.  
  
## Remarks  
 This method removes a single group. To remove all groups, call [CMFCTasksPane::RemoveAllGroups](../vs140/cmfctaskspane--removeallgroups.md) instead.  
  
 When the framework removes a group, all tasks and user windows associated with it are destroyed.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)