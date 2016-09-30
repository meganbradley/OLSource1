---
title: "CAnimationPoint::GetValue"
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
  - "afxanimationcontroller/CAnimationPoint::GetValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValue method"
ms.assetid: ee6f1a0f-0a10-4ddc-afb8-a44d1dead1ca
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationPoint::GetValue
Returns current value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Output. Contains the current value when this method returns.  
  
## Return Value  
 TRUE, if the current value was successfully retrieved; otherwise FALSE.  
  
## Remarks  
 Call this function to retrieve the current value of animation point. If this method fails or underlying COM objects for X and Y coordinates have not been initialized, ptValue contains default value, which was previously set in constructor or by SetDefaultValue.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationPoint Class](../vs140/canimationpoint-class.md)