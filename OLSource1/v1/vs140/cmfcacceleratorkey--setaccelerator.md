---
title: "CMFCAcceleratorKey::SetAccelerator"
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
  - "SetAccelerator"
  - "CMFCAcceleratorKey.SetAccelerator"
  - "CMFCAcceleratorKey::SetAccelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAccelerator method"
ms.assetid: 8bcb051f-582a-4bdf-b14b-8b2a3067ef80
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAcceleratorKey::SetAccelerator
Sets the shortcut key for the [CMFCAcceleratorKey](../vs140/cmfcacceleratorkey-class.md) object.  
  
## Syntax  
  
```  
void SetAccelerator(  
   LPACCEL lpAccel   
);  
```  
  
#### Parameters  
 [in] `lpAccel`  
 A pointer to a shortcut key.  
  
## Remarks  
 Use this method to set the shortcut key for a `CMFCAcceleratorKey` if you did not provide a shortcut key when you created the `CMFCAcceleratorKey`.  
  
## Requirements  
 **Header:** afxacceleratorkey.h  
  
## See Also  
 [CMFCAcceleratorKey Class](../vs140/cmfcacceleratorkey-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)