---
title: "CMFCVisualManager::OnEraseMDIClientArea"
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
  - "CMFCVisualManager::OnEraseMDIClientArea"
  - "CMFCVisualManager.OnEraseMDIClientArea"
  - "OnEraseMDIClientArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEraseMDIClientArea method"
ms.assetid: 58a69a5c-f559-4eea-a143-0d33e8ff2865
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnEraseMDIClientArea
The framework calls this method when it erases the MDI client area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the MDI client area.  
  
## Return Value  
 A reserved value. The default implementation returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method to execute custom code when the visual manager erases the MDI client area.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)