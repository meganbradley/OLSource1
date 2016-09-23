---
title: "CGdiObject::operator HGDIOBJ"
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
  - CGdiObject::operatorHGDIOBJ
  - operatorHGDIOBJ
  - CGdiObject.operatorHGDIOBJ
dev_langs: 
  - C++
helpviewer_keywords: 
  - HGDIOBJ operator
  - operator HGDIOBJ
ms.assetid: 178da4e7-15b1-41ed-841f-9efe5061982e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGdiObject::operator HGDIOBJ
Retrieves a `HANDLE` to the attached Windows GDI object; otherwise **NULL** if no object is attached.  
  
## Syntax  
  
```  
  
operator HGDIOBJ() const;  
  
```  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::GetSafeHandle](../vs140/cgdiobject--getsafehandle.md)