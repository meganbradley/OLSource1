---
title: "COleControlSite::MoveWindow"
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
  - "COleControlSite.MoveWindow"
  - "COleControlSite::MoveWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveWindow method"
  - "COleControlSite class, overridables"
ms.assetid: 929e0381-2958-4343-a398-80b388a5d0fa
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::MoveWindow
Changes the position of the control.  
  
## Syntax  
  
```  
  
      virtual void MoveWindow(  
   int x,  
   int y,  
   int nWidth,  
   int nHeight   
);  
```  
  
#### Parameters  
 *x*  
 The new position of the left side of the window.  
  
 *y*  
 The new position of the top of the window.  
  
 `nWidth`  
 The new width of the window  
  
 `nHeight`  
 The new height of the window.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)