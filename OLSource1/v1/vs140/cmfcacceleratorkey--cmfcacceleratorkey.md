---
title: "CMFCAcceleratorKey::CMFCAcceleratorKey"
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
  - "CMFCAcceleratorKey"
  - "CMFCAcceleratorKey::CMFCAcceleratorKey"
  - "CMFCAcceleratorKey.CMFCAcceleratorKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCAcceleratorKey class, constructor"
ms.assetid: 3dd387c8-a753-40db-b587-5692ddddb198
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAcceleratorKey::CMFCAcceleratorKey
Constructs a [CMFCAcceleratorKey](../vs140/cmfcacceleratorkey-class.md) object.  
  
## Syntax  
  
```  
CMFCAcceleratorKey();  
  
CMFCAcceleratorKey(  
   LPACCEL lpAccel   
);  
```  
  
#### Parameters  
 [in] `lpAccel`  
 A pointer to a shortcut key.  
  
## Remarks  
 If you do not provide a shortcut key when you create a `CMFCAccleratorKey`, use the [CMFCAcceleratorKey::SetAccelerator](../vs140/cmfcacceleratorkey--setaccelerator.md) method to associate a shortcut key with your `CMFCAcceleratorKey` object.  
  
## Requirements  
 **Header:** afxacceleratorkey.h  
  
## See Also  
 [CMFCAcceleratorKey Class](../vs140/cmfcacceleratorkey-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)