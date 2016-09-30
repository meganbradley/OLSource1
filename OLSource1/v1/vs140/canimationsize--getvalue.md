---
title: "CAnimationSize::GetValue"
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
  - "GetValue"
  - "afxanimationcontroller/CAnimationSize::GetValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValue method"
ms.assetid: 67bbbfce-3438-4aee-9ea6-dccbc0abf27b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationSize::GetValue
Returns current value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Output. Contains the current value when this method returns.  
  
## Return Value  
 TRUE, if the current value was successfully retrieved; otherwise FALSE.  
  
## Remarks  
 Call this function to retrieve the current value of animation size. If this method fails or underlying COM objects for Width and Size have not been initialized, szValue contains default value, which was previously set in constructor or by SetDefaultValue.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationSize Class](../vs140/canimationsize-class.md)