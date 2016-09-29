---
title: "CMFCTasksPaneTask::m_nIcon"
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
  - "m_nIcon"
  - "CMFCTasksPaneTask.m_nIcon"
  - "CMFCTasksPaneTask::m_nIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTasksPaneTask class, data members"
  - "m_nIcon"
ms.assetid: e19ebb40-3526-43aa-9333-4f3ae7540e4a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPaneTask::m_nIcon
The index position in an image list that identifies an image that is displayed next to the specified task.  
  
## Syntax  
  
```  
int m_nIcon;  
```  
  
## Remarks  
 The image list is set by [CMFCTasksPane::SetIconsList](../vs140/cmfctaskspane--seticonslist.md).  
  
 Set `m_nIcon` to -1 if you want to display the task without an image.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTasksPaneTask Class](../vs140/cmfctaskspanetask-class.md)