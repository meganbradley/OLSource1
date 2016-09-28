---
title: "CMFCToolBarButton::IsWindowVisible"
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
  - "IsWindowVisible"
  - "CMFCToolBarButton.IsWindowVisible"
  - "CMFCToolBarButton::IsWindowVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsWindowVisible method"
ms.assetid: 5d8b7f43-fd19-4bd9-8b6a-459cc1f2f264
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsWindowVisible
Determines whether the underlying window handle of the button is visible.  
  
## Syntax  
  
```  
virtual BOOL IsWindowVisible();  
```  
  
## Return Value  
 Nonzero if the underlying window handle of the button is visible; otherwise 0.  
  
## Remarks  
 This method returns nonzero if the styles attribute of the underlying window handle contains the `WS_VISIBLE` style. This method returns `FALSE` if the underlying window handle of the button is `NULL`.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton--gethwnd.md)