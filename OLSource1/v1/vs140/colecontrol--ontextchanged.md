---
title: "COleControl::OnTextChanged"
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
  - "OnTextChanged"
  - "COleControl.OnTextChanged"
  - "COleControl::OnTextChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTextChanged method"
ms.assetid: 535e43da-e65a-4d38-adf7-e7af60c5abd3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnTextChanged
Called by the framework when the stock Caption or Text property value has changed.  
  
## Syntax  
  
```  
  
virtual void OnTextChanged( );  
```  
  
## Remarks  
 The default implementation calls `InvalidateControl`.  
  
 Override this function if you want notification after this property changes.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetText](../vs140/colecontrol--settext.md)   
 [COleControl::InternalGetText](../vs140/colecontrol--internalgettext.md)   
 [COleControl::InvalidateControl](../vs140/colecontrol--invalidatecontrol.md)