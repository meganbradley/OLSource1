---
title: "CMFCVisualManagerOffice2003::OnDrawTask"
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
  - "OnDrawTask"
  - "CMFCVisualManagerOffice2003::OnDrawTask"
  - "CMFCVisualManagerOffice2003.OnDrawTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTask method"
ms.assetid: 58e8d084-0435-4e0c-b2a9-d39a3b5eb146
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawTask
The framework calls this method when it draws a [CMFCTasksPaneTask](../vs140/cmfctaskspanetask-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawTask(  
   CDC* pDC,  
   CMFCTasksPaneTask* pTask,  
   CImageList* pIcons,  
   BOOL bIsHighlighted = FALSE,  
   BOOL bIsSelected = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pTask`  
 A pointer to a [CMFCTasksPaneTask](../vs140/cmfctaskspanetask-class.md) object. The framework draws this task.  
  
 [in] `pIcons`  
 A pointer to the image list associated with the task pane. Each task contains an index for an image in this list.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that specifies whether the displayed task is highlighted.  
  
 [in] `bIsSelected`  
 A Boolean parameter that specifies whether the displayed task is selected.  
  
## Remarks  
 The framework displays tasks on the task bar as both an icon and text. The `pIcons` parameter contains the icon for the task indicated by `pTask`. Override this method in a derived class to customize the appearance of tasks on the task bar.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)