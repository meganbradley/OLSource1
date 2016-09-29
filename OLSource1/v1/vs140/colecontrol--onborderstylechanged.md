---
title: "COleControl::OnBorderStyleChanged"
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
  - "COleControl::OnBorderStyleChanged"
  - "COleControl.OnBorderStyleChanged"
  - "OnBorderStyleChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBorderStyleChanged method"
ms.assetid: 1024a22d-6467-4753-97de-9f322aabe952
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnBorderStyleChanged
Called by the framework when the stock BorderStyle property value has changed.  
  
## Syntax  
  
```  
  
virtual void OnBorderStyleChanged( );  
```  
  
## Remarks  
 The default implementation calls `InvalidateControl`.  
  
 Override this function if you want notification after this property changes.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetBorderStyle](../vs140/colecontrol--setborderstyle.md)   
 [COleControl::InvalidateControl](../vs140/colecontrol--invalidatecontrol.md)