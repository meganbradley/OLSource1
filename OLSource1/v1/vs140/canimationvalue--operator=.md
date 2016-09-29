---
title: "CAnimationValue::operator="
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
  - "operator="
  - "afxanimationcontroller/CAnimationValue::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: cf8fb466-6ae8-4627-851f-6a37d75b4f5d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationValue::operator=
Assigns a DOUBLE value to CAnimationValue.  
  
## Syntax  
  
```  
void operator=(  
   DOUBLE dblVal  
);  
void operator=(  
   INT32 nVal  
);  
```  
  
#### Parameters  
 `dblVal`  
 Specifies the value to be assigned to Animation Value.  
  
 `nVal`  
 Specifies the value to be assigned to Animation Value.  
  
## Remarks  
 Assigns a DOUBLE value to CAnimationValue. This value is set as a default value for encapsulated animation variable. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationValue Class](../vs140/canimationvalue-class.md)