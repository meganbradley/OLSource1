---
title: "CAnimationBaseObject::GetObjectID"
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
  - "afxanimationcontroller/CAnimationBaseObject::GetObjectID"
  - "GetObjectID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetObjectID method"
ms.assetid: 8f46505d-50da-4cd1-b9be-6f8750f5026f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::GetObjectID
Returns current Object ID.  
  
## Syntax  
  
```  
UINT32 GetObjectID() const;  
```  
  
## Return Value  
 Current Object ID.  
  
## Remarks  
 Use this method to retrieve Object ID. It's 0 if Object ID has not been set explicitly in constructor or with SetID.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)