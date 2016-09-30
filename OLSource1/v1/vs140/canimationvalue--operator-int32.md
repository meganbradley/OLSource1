---
title: "CAnimationValue::operator INT32"
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
  - "afxanimationcontroller/CAnimationValue::operator INT32"
  - "operator INT32"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator INT32 operator"
ms.assetid: df887c58-5522-435e-bb89-e325bb2c6888
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationValue::operator INT32
Provides conversion between CAnimationValue and INT32.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Current value of Animation Value as integer.  
  
## Remarks  
 Provides conversion between CAnimationValue and INT32. This method internally calls GetValue and doesn't check for errors. If GetValue fails, the returned value will contain a default value previously set in constructor or with SetDefaultValue.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationValue Class](../vs140/canimationvalue-class.md)