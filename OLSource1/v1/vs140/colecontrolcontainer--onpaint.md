---
title: "COleControlContainer::OnPaint"
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
  - "COleControlContainer::OnPaint"
  - "COleControlContainer.OnPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "OnPaint method"
ms.assetid: 2669597b-0037-4e5b-b205-80ce67d31dee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::OnPaint
Called by the framework to handle `WM_PAINT` requests.  
  
## Syntax  
  
```  
  
      virtual BOOL OnPaint(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to the device context used by the container.  
  
## Return Value  
 Nonzero if the message was handled; otherwise zero.  
  
## Remarks  
 Override this function to customize the painting process.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)