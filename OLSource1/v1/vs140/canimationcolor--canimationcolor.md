---
title: "CAnimationColor::CAnimationColor"
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
  - "afxanimationcontroller/CAnimationColor::CAnimationColor"
  - "CAnimationColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationColor class, constructor"
ms.assetid: e58c0594-1e4c-49bc-81a0-fbc03f705989
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationColor::CAnimationColor
Constructs a CAnimationColor object.  
  
## Syntax  
  
```  
CAnimationColor();  
CAnimationColor(  
   COLORREF color,  
   UINT32 nGroupID,  
   UINT32 nObjectID = (UINT32)-1,  
   DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 `color`  
 Specifies default color.  
  
 `nGroupID`  
 Specifies Group ID.  
  
 `nObjectID`  
 Specifies Object ID.  
  
 `dwUserData`  
 Specifies user-defined data.  
  
## Remarks  
 The object is constructed with default values for red, green, blue, Object ID and Group ID, which will be set to 0. They can be changed later at runtime using SetDefaultValue and SetID.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationColor Class](../vs140/canimationcolor-class.md)