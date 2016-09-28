---
title: "CBaseTransition::Clear"
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
  - "afxanimationcontroller/CBaseTransition::Clear"
  - "Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Clear method"
ms.assetid: e9bca8e6-0e22-4dfa-877a-d33cfee89497
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTransition::Clear
Releases encapsulated IUIAnimationTransition COM object.  
  
## Syntax  
  
```  
void Clear();  
```  
  
## Remarks  
 This method should be called from a derived class's Create method in order to prevent IUITransition interface leak.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseTransition Class](../vs140/cbasetransition-class.md)