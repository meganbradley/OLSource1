---
title: "COleControl::OnClose"
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
  - "COleControl.OnClose"
  - "COleControl::OnClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClose method"
ms.assetid: 1cf8a86c-2420-494d-a626-1e18815539cc
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnClose
Called by the framework when the container has called the control's **IOleControl::Close** function.  
  
## Syntax  
  
```  
  
      virtual void OnClose(  
   DWORD dwSaveOption   
);  
```  
  
#### Parameters  
 `dwSaveOption`  
 Flag that indicates whether the object should be saved before loading. Valid values are:  
  
-   `OLECLOSE_SAVEIFDIRTY`  
  
-   `OLECLOSE_NOSAVE`  
  
-   `OLECLOSE_PROMPTSAVE`  
  
## Remarks  
 By default, `OnClose` saves the control object if it has been modified and `dwSaveOption` is either `OLECLOSE_SAVEIFDIRTY` or `OLECLOSE_PROMPTSAVE`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)