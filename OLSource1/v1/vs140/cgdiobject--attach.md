---
title: "CGdiObject::Attach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CGdiObject::Attach
  - CGdiObject.Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [MFC]
  - CGdiObject class, operations
ms.assetid: 44f7a4ab-4a3b-4f13-a0d8-3374b3674f6e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGdiObject::Attach
Attaches a Windows GDI object to a `CGdiObject` object.  
  
## Syntax  
  
```  
  
      BOOL Attach(  
   HGDIOBJ hObject   
);  
```  
  
#### Parameters  
 `hObject`  
 A `HANDLE` to a Windows GDI object (for example, `HPEN` or `HBRUSH`).  
  
## Return Value  
 Nonzero if attachment is successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::Detach](../vs140/cgdiobject--detach.md)