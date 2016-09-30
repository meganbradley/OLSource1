---
title: "CAnimationValue::SetDefaultValue"
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
  - "afxanimationcontroller/CAnimationValue::SetDefaultValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultValue method"
ms.assetid: ebee016f-2d51-4bec-9e2c-71f65581d706
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationValue::SetDefaultValue
Sets default value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the default value.  
  
## Remarks  
 Use this method to set a default value. A default value is returned to application when animation has not been started and/or underlying COM object has not been created. If the underlying COM object encapsulated in CAnimationVarible was already created, this method recreates it, therefore you might need to call EnableValueChanged/EnableIntegerValueChanged methods again.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationValue Class](../vs140/canimationvalue-class.md)