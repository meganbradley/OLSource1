---
title: "CAnimationSize::SetDefaultValue"
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
  - "SetDefaultValue"
  - "afxanimationcontroller/CAnimationSize::SetDefaultValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultValue method"
ms.assetid: c5acf342-a761-4bf1-9d9c-0d01ddba73dc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationSize::SetDefaultValue
Sets default value.  
  
## Syntax  
  
```  
void SetDefaultValue(  
   const CSize& szDefault  
);  
```  
  
#### Parameters  
 `szDefault`  
 Specifies new default size.  
  
## Remarks  
 Use this function to set a default value to animation object. This methods assigns default values to Width and Height of animation size. It also recreates underlying COM objects if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationSize Class](../vs140/canimationsize-class.md)