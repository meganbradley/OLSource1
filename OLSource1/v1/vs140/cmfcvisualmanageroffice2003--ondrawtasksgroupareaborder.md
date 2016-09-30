---
title: "CMFCVisualManagerOffice2003::OnDrawTasksGroupAreaBorder"
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
  - "CMFCVisualManagerOffice2003::OnDrawTasksGroupAreaBorder"
  - "CMFCVisualManagerOffice2003.OnDrawTasksGroupAreaBorder"
  - "OnDrawTasksGroupAreaBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTasksGroupAreaBorder method"
ms.assetid: b9c3f17d-162d-491f-ae15-dd63fae431ef
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawTasksGroupAreaBorder
The framework calls this method when it draws a border around a group on a [CMFCTasksPane](../vs140/cmfctaskspane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the group area on the task pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies if the border is highlighted. A value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> indicates that the border is highlighted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the group area has a title. A value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> indicates that the group area does not have a title.  
  
## Remarks  
 Override this function in a derived class to customize the border around a group area on the task pane.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)