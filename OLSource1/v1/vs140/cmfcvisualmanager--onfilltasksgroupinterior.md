---
title: "CMFCVisualManager::OnFillTasksGroupInterior"
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
  - CMFCVisualManager.OnFillTasksGroupInterior
  - CMFCVisualManager::OnFillTasksGroupInterior
  - OnFillTasksGroupInterior
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFillTasksGroupInterior method
ms.assetid: 77a0429e-e029-4e64-bcb1-58ae59db8dee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnFillTasksGroupInterior
The framework calls this method when it fills the interior of a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object.  
  
## Syntax  
  
```  
virtual void OnFillTasksGroupInterior(  
   CDC* pDC,  
   CRect rect,  
   BOOL bSpecial = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the task group.  
  
 [in] `bSpecial`  
 A Boolean that indicates if the interior is filled with a special color.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a task group.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPaneTaskGroup Class](../vs140/cmfctaskspanetaskgroup-class.md)   
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)