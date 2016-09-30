---
title: "COleControlContainer::BroadcastAmbientPropertyChange"
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
  - "COleControlContainer.BroadcastAmbientPropertyChange"
  - "BroadcastAmbientPropertyChange"
  - "COleControlContainer::BroadcastAmbientPropertyChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BroadcastAmbientPropertyChange method"
ms.assetid: f547200a-33ed-45c3-90d2-8970912aeb3f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::BroadcastAmbientPropertyChange
Informs all hosted controls that an ambient property has changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The dispatch ID of the ambient property being changed.  
  
## Remarks  
 This function is called by the framework when an ambient property has changed value. Override this function to customize this behavior.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnAmbientPropertyChange](../vs140/colecontrol--onambientpropertychange.md)