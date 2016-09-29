---
title: "CMFCVisualManager::OnDrawTasksGroupAreaBorder"
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
  - "CMFCVisualManager::OnDrawTasksGroupAreaBorder"
  - "OnDrawTasksGroupAreaBorder"
  - "CMFCVisualManager.OnDrawTasksGroupAreaBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTasksGroupAreaBorder method"
ms.assetid: 41a78615-a85b-4134-bfcf-83e60b370dfd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawTasksGroupAreaBorder
The framework calls this method when it draws a border around a group on a [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawTasksGroupAreaBorder(  
   CDC* pDC,  
   CRect rect,  
   BOOL bSpecial = FALSE,  
   BOOL bNoTitle = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the group area on the task pane.  
  
 [in] `bSpecial`  
 A Boolean parameter that specifies if the border is highlighted. A value of `TRUE` indicates that the border is highlighted.  
  
 [in] `bNoTitle`  
 A Boolean parameter that specifies whether the group area has a title. A value of `TRUE` indicates that the group area does not have a title.  
  
## Remarks  
 Override this function in a derived class to customize the border around a group area on the task pane.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)