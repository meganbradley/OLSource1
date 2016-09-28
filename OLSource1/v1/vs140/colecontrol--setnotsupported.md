---
title: "COleControl::SetNotSupported"
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
  - "SetNotSupported"
  - "COleControl.SetNotSupported"
  - "COleControl::SetNotSupported"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetNotSupported method"
ms.assetid: 910ecffb-d7d6-4d5a-b809-716d4ed1a1ee
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetNotSupported
Prevents modification to a control's property value by the user.  
  
## Syntax  
  
```  
  
void SetNotSupported( );  
```  
  
## Remarks  
 Call this function in place of the Set function of any property where modification of the property value by the control's user is not supported. One example would be a property that is read only.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetNotSupported](../vs140/colecontrol--getnotsupported.md)