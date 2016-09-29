---
title: "COleControl::BoundPropertyChanged"
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
  - "COleControl.BoundPropertyChanged"
  - "COleControl::BoundPropertyChanged"
  - "BoundPropertyChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BoundPropertyChanged method"
ms.assetid: 330bea4a-c138-4451-89bb-60365e5bb719
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::BoundPropertyChanged
Signals that the bound property value has changed.  
  
## Syntax  
  
```  
  
      void BoundPropertyChanged(  
   DISPID dispid   
);  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of a bound property of the control.  
  
## Remarks  
 This must be called every time the value of the property changes, even in cases where the change was not made through the property Set method. Be particularly aware of bound properties that are mapped to member variables. Any time such a member variable changes, `BoundPropertyChanged` must be called.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::BoundPropertyRequestEdit](../vs140/colecontrol--boundpropertyrequestedit.md)