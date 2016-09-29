---
title: "CAnimationSize::CAnimationSize"
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
  - "CAnimationSize"
  - "afxanimationcontroller/CAnimationSize::CAnimationSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationSize class, constructor"
ms.assetid: 73edefcc-3d60-4a02-9d5a-f159041cf03b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationSize::CAnimationSize
Constructs an animation size object.  
  
## Syntax  
  
```  
CAnimationSize();  
CAnimationSize(  
   const CSize& szDefault,  
   UINT32 nGroupID,  
   UINT32 nObjectID = (UINT32)-1,  
   DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 `szDefault`  
 Specifies default size.  
  
 `nGroupID`  
 Specifies Group ID.  
  
 `nObjectID`  
 Specifies Object ID.  
  
 `dwUserData`  
 Specifies user-defined data.  
  
## Remarks  
 The object is constructed with default values for width, height, Object ID and Group ID, which will be set to 0. They can be changed later at runtime using SetDefaultValue and SetID.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationSize Class](../vs140/canimationsize-class.md)