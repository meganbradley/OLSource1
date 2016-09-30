---
title: "CMFCVisualManager::OnDrawTask"
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
  - "CMFCVisualManager::OnDrawTask"
  - "CMFCVisualManager.OnDrawTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTask method"
ms.assetid: 5f71a094-a322-45f6-b9b8-8166b19fe2fa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawTask
The framework calls this method when it draws a [CMFCTasksPane](../vs140/cmfctaskspane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCTasksPaneTask](../vs140/cmfctaskspanetask-class.md) object. The framework draws this task.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the image list associated with the task pane. Each task contains an index for an image in this list.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the displayed task is highlighted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the displayed task is selected.  
  
## Remarks  
 The framework displays tasks on the task bar as both an icon and text. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter contains the icon for the task indicated by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Override this method in a derived class to customize the appearance of tasks on the task bar.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [CMFCTasksPaneTask Class](../vs140/cmfctaskspanetask-class.md)