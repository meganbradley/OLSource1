---
title: "CMFCVisualManager::OnFillTasksPaneBackground"
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
  - "CMFCVisualManager::OnFillTasksPaneBackground"
  - "OnFillTasksPaneBackground"
  - "CMFCVisualManager.OnFillTasksPaneBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillTasksPaneBackground method"
ms.assetid: dc0285d8-d3e3-41aa-91f6-e1c4e0fbd393
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillTasksPaneBackground
The framework calls this method when it fills the background of a [CMFCTasksPane](../vs140/cmfctaskspane-class.md) control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the task pane.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)