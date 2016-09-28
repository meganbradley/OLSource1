---
title: "CMFCTasksPaneTaskGroup::m_bIsSpecial"
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
  - "CMFCTasksPaneTaskGroup::m_bIsSpecial"
  - "CMFCTasksPaneTaskGroup.m_bIsSpecial"
  - "m_bIsSpecial"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTasksPaneTaskGroup class, data members"
  - "m_bIsSpecial"
ms.assetid: de6fa7b9-9b2d-4c0c-a5d8-877ef33b3e89
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPaneTaskGroup::m_bIsSpecial
Determines whether the task group is *special* and whether the caption for a special task group should be identified by a different color.  
  
## Syntax  
  
```  
BOOL m_bIsSpecial;  
```  
  
## Remarks  
 If your application is using the Windows XP visual theme and `m_bIsSpecial` is `FALSE`, the framework calls `DrawThemeBackground` with the `EBP_NORMALGROUPBACKGROUND` flag. If `m_bIsSpecial` is `TRUE`, the framework calls `DrawThemeBackground` with the `EBP_SPECIALGROUPBACKGROUND` flag.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTasksPaneTaskGroup Class](../vs140/cmfctaskspanetaskgroup-class.md)