---
title: "CMFCTasksPaneTaskGroup::CMFCTasksPaneTaskGroup"
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
  - CMFCTasksPaneTaskGroup.CMFCTasksPaneTaskGroup
  - CMFCTasksPaneTaskGroup
  - CMFCTasksPaneTaskGroup::CMFCTasksPaneTaskGroup
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCTasksPaneTaskGroup class, constructor
ms.assetid: 7a433840-2365-4786-bd73-f97213ba407e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPaneTaskGroup::CMFCTasksPaneTaskGroup
Constructs a `CMFCTasksPaneTaskGroup` object.  
  
## Syntax  
  
```  
CMFCTasksPaneTaskGroup(  
    LPCTSTR lpszName,  
    BOOL bIsBottom,  
    BOOL bIsSpecial=FALSE,  
    BOOL bIsCollapsed=FALSE,  
    CMFCTasksPanePropertyPage* pPage=NULL,  
    HICON hIcon=NULL  
);  
```  
  
#### Parameters  
 `lpszName`  
 Specifies the name of the group in the group caption.  
  
 `bIsBottom`  
 Specifies whether the group is aligned to the bottom of the task pane control.  
  
 `bIsSpecial`  
 Specifies whether the group is designated as *special* and thus, whether the group caption is filled with a different color.  
  
 `bIsCollapsed`  
 Specifies whether the group is collapsed.  
  
 `pPage`  
 Specifies the property page that this task group belongs to.  
  
 `hIcon`  
 Specifies the icon that displays in the group caption.  
  
## Remarks  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTasksPaneTaskGroup Class](../vs140/cmfctaskspanetaskgroup-class.md)