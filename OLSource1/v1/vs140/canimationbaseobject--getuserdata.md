---
title: "CAnimationBaseObject::GetUserData"
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
  - "afxanimationcontroller/CAnimationBaseObject::GetUserData"
  - "GetUserData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUserData method"
ms.assetid: 622ce40c-ea59-4c69-970f-a89d26903390
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::GetUserData
Returns user defined data.  
  
## Syntax  
  
```  
DWORD GetUserData() const;  
```  
  
## Return Value  
 A value of custom data.  
  
## Remarks  
 Call this method to retrieve the custom data at runtime. The returned value will be 0 if it was not explicitly initialized in constructor or with SetUserData.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)