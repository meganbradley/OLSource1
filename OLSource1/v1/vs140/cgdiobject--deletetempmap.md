---
title: "CGdiObject::DeleteTempMap"
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
  - "CGdiObject.DeleteTempMap"
  - "DeleteTempMap"
  - "CGdiObject::DeleteTempMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteTempMap method"
  - "CGdiObject class, operations"
ms.assetid: e420b381-1efc-43f4-8c22-18e4d1a6265e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::DeleteTempMap
Called automatically by the `CWinApp` idle-time handler, `DeleteTempMap` deletes any temporary `CGdiObject` objects created by `FromHandle`.  
  
## Syntax  
  
```  
  
static void PASCAL DeleteTempMap( );  
```  
  
## Remarks  
 `DeleteTempMap` detaches the Windows GDI object attached to a temporary `CGdiObject` object before deleting the `CGdiObject` object.  
  
## Example  
 [!code[NVC_MFCDocView#175](../vs140/codesnippet/CPP/cgdiobject--deletetempmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::Detach](../vs140/cgdiobject--detach.md)   
 [CGdiObject::FromHandle](../vs140/cgdiobject--fromhandle.md)