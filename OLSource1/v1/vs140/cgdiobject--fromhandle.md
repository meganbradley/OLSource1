---
title: "CGdiObject::FromHandle"
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
  - "CGdiObject::FromHandle"
  - "CGdiObject.FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandle method [MFC]"
  - "CGdiObject class, operations"
ms.assetid: 983a787e-404c-4874-aace-c91523ae147d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::FromHandle
Returns a pointer to a `CGdiObject` object given a handle to a Windows GDI object.  
  
## Syntax  
  
```  
  
      static CGdiObject* PASCAL FromHandle(  
   HGDIOBJ hObject   
);  
```  
  
#### Parameters  
 `hObject`  
 A `HANDLE` to a Windows GDI object.  
  
## Return Value  
 A pointer to a `CGdiObject` that may be temporary or permanent.  
  
## Remarks  
 If a `CGdiObject` object is not already attached to the Windows GDI object, a temporary `CGdiObject` object is created and attached.  
  
 This temporary `CGdiObject` object is only valid until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is only valid during the processing of one window message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::DeleteTempMap](../vs140/cgdiobject--deletetempmap.md)