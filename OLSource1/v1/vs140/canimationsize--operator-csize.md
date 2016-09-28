---
title: "CAnimationSize::operator CSize"
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
  - "afxanimationcontroller/CAnimationSize::operator CSize"
  - "operator CSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator CSize operator"
ms.assetid: 2e06c0e8-8d3c-4bc9-90a1-09abd616f201
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationSize::operator CSize
Converts a CAnimationSize to a CSize.  
  
## Syntax  
  
```  
operator CSize();  
```  
  
## Return Value  
 Current value of animation size as CSize.  
  
## Remarks  
 This function internally calls GetValue. If GetValue for some reason fails, the returned size will contain default values for Width and Height.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationSize Class](../vs140/canimationsize-class.md)