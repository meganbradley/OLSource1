---
title: "CMFCAcceleratorKeyAssignCtrl::IsKeyDefined"
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
  - "CMFCAcceleratorKeyAssignCtrl.IsKeyDefined"
  - "CMFCAcceleratorKeyAssignCtrl::IsKeyDefined"
  - "IsKeyDefined"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsKeyDefined method"
ms.assetid: 96d3d8e9-e0c3-40cb-b25c-ff98ea918be4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAcceleratorKeyAssignCtrl::IsKeyDefined
Determines whether a shortcut key has been defined in the [CMFCAcceleratorKeyAssignCtrl](../vs140/cmfcacceleratorkeyassignctrl-class.md) object.  
  
## Syntax  
  
```  
BOOL IsKeyDefined() const;  
```  
  
## Return Value  
 Nonzero if the user has already pressed a valid combination of keys that define a shortcut key; otherwise 0.  
  
## Remarks  
 Use this function to determine whether the user entered a valid shortcut key in your `CMFCAcceleratorKeyAssignCtrl` object. If a shortcut key exists, you can use [CMFCAcceleratorKeyAssignCtrl::GetAccel](../vs140/cmfcacceleratorkeyassignctrl--getaccel.md) method to obtain the `ACCEL` structure associated with this shortcut key.  
  
## Requirements  
 **Header:**afxacceleratorkeyassignctrl.h  
  
## See Also  
 [CMFCAcceleratorKeyAssignCtrl Class](../vs140/cmfcacceleratorkeyassignctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)