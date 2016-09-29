---
title: "COleControl::OnEnabledChanged"
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
  - "COleControl.OnEnabledChanged"
  - "OnEnabledChanged"
  - "COleControl::OnEnabledChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEnabledChanged method"
ms.assetid: 2d54297b-8fc4-497e-a935-36d921be5997
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnEnabledChanged
Called by the framework when the stock Enabled property value has changed.  
  
## Syntax  
  
```  
  
virtual void OnEnabledChanged( );  
```  
  
## Remarks  
 Override this function if you want notification after this property changes. The default implementation calls [InvalidateControl](../vs140/colecontrol--invalidatecontrol.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetEnabled](../vs140/colecontrol--setenabled.md)   
 [COleControl::GetEnabled](../vs140/colecontrol--getenabled.md)