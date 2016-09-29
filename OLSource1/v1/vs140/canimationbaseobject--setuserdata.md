---
title: "CAnimationBaseObject::SetUserData"
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
  - "SetUserData"
  - "afxanimationcontroller/CAnimationBaseObject::SetUserData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetUserData method"
ms.assetid: 34003d54-e35b-4493-bd2f-7c0bf5ae482c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::SetUserData
Sets user-defined data.  
  
## Syntax  
  
```  
void SetUserData (  
   DWORD dwUserData  
);  
```  
  
#### Parameters  
 `dwUserData`  
 Specifies the custom data.  
  
## Remarks  
 Use this method to associate a custom data with an animation object. This data may be retrieved later at runtime by GetUserData.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)