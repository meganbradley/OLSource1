---
title: "CAnimationColor::SetDefaultValue"
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
  - "afxanimationcontroller/CAnimationColor::SetDefaultValue"
  - "SetDefaultValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultValue method"
ms.assetid: 6c0508a1-0643-41ed-8217-628bf5a17159
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationColor::SetDefaultValue
Sets default value.  
  
## Syntax  
  
```  
void SetDefaultValue(  
   COLORREF color  
);  
```  
  
#### Parameters  
 `color`  
 Specifies new default values for red, green and blue components.  
  
## Remarks  
 Use this function to set a default value to animation object. This methods assigns default values to color components of animation color. It also recreates underlying COM objects if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationColor Class](../vs140/canimationcolor-class.md)