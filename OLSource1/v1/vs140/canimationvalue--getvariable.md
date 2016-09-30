---
title: "CAnimationValue::GetVariable"
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
  - "afxanimationcontroller/CAnimationValue::GetVariable"
  - "GetVariable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetVariable method"
ms.assetid: 3e130b1f-a7d8-4d65-a46e-b80476638597
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationValue::GetVariable
Provides access to encapsulated animation variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to encapsulated animation variable.  
  
## Remarks  
 Use this method to access the encapsulated animation variable. From CAnimationVariable you get access to underlying IUIAnimationVariable object, whose pointer can be NULL if animation variable has not been created.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationValue Class](../vs140/canimationvalue-class.md)