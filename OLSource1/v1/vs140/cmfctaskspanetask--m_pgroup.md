---
title: "CMFCTasksPaneTask::m_pGroup"
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
  - CMFCTasksPaneTask::m_pGroup
  - m_pGroup
  - CMFCTasksPaneTask.m_pGroup
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCTasksPaneTask class, data members
  - m_pGroup
ms.assetid: 67f99e13-583f-4161-8569-7914436c2714
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPaneTask::m_pGroup
Pointer to the [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) to which this task belongs.  
  
## Syntax  
  
```  
CMFCTasksPaneTaskGroup* m_pGroup;  
```  
  
## Remarks  
 Every task must have a parent group. You add groups to a task pane by calling [CMFCTasksPane::AddGroup](../vs140/cmfctaskspane--addgroup.md).  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTasksPaneTask Class](../vs140/cmfctaskspanetask-class.md)   
 [CMFCTasksPaneTaskGroup Class](../vs140/cmfctaskspanetaskgroup-class.md)