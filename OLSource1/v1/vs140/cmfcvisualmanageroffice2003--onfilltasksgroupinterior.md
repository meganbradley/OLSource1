---
title: "CMFCVisualManagerOffice2003::OnFillTasksGroupInterior"
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
  - "CMFCVisualManagerOffice2003.OnFillTasksGroupInterior"
  - "CMFCVisualManagerOffice2003::OnFillTasksGroupInterior"
  - "OnFillTasksGroupInterior"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillTasksGroupInterior method"
ms.assetid: cfe4f012-3550-4be5-b484-d81fdb9a13eb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillTasksGroupInterior
The framework calls this method when it fills the interior of a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the task group.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean that indicates if the interior is filled with a special color.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a task group.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)