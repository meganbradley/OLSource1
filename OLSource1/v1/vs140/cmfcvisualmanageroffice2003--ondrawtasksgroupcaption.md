---
title: "CMFCVisualManagerOffice2003::OnDrawTasksGroupCaption"
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
  - OnDrawTasksGroupCaption
  - CMFCVisualManagerOffice2003::OnDrawTasksGroupCaption
  - CMFCVisualManagerOffice2003.OnDrawTasksGroupCaption
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawTasksGroupCaption method
ms.assetid: ae42a2a8-27a7-4937-8ef4-c34b1f21b122
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::OnDrawTasksGroupCaption
The framework calls this method when it draws the caption for a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawTasksGroupCaption(  
   CDC* pDC,  
   CMFCTasksPaneTaskGroup* pGroup,  
   BOOL bIsHighlighted = FALSE,  
   BOOL bIsSelected = FALSE,  
   BOOL bCanCollapse = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pGroup`  
 A pointer to a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object. The framework draws the caption for this group.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates whether the group is highlighted.  
  
 [in] `bIsSelected`  
 A Boolean parameter that indicates whether the group is currently selected.  
  
 [in] `bCanCollapse`  
 A Boolean parameter that indicates whether the group can be collapsed.  
  
## Remarks  
 Override this method in a derived class to customize the caption for a `CMFCTasksPaneTaskGroup`.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)