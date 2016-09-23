---
title: "CAnimationBaseObject::CAnimationBaseObject"
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
  - afxanimationcontroller/CAnimationBaseObject::CAnimationBaseObject
  - CAnimationBaseObject
dev_langs: 
  - C++
helpviewer_keywords: 
  - CAnimationBaseObject class, constructor
ms.assetid: da0918e9-df9d-4a8f-9579-4604ede99203
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationBaseObject::CAnimationBaseObject
Constructs an animation object.  
  
## Syntax  
  
```  
CAnimationBaseObject();  
CAnimationBaseObject(  
   UINT32 nGroupID,  
   UINT32 nObjectID = (UINT32)-1,  
   DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 `nGroupID`  
 Specifies Group ID.  
  
 `nObjectID`  
 Specifies Object ID.  
  
 `dwUserData`  
 User-defined data, which can be associated with animation object and retrieved later at runtime.  
  
## Remarks  
 Constructs an animation objects and assigns default Object ID (0) and Group ID (0).  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)