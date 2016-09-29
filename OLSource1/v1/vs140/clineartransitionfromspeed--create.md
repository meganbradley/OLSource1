---
title: "CLinearTransitionFromSpeed::Create"
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
  - "Create"
  - "afxanimationcontroller/CLinearTransitionFromSpeed::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 240728d7-9615-44bf-bfda-d3e96abbd6db
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinearTransitionFromSpeed::Create
Calls the transition library to create encapsulated transition COM object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   IUIAnimationTransitionLibrary* pLibrary,  
   IUIAnimationTransitionFactory* */  
);  
```  
  
#### Parameters  
 `pLibrary`  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
## Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CLinearTransitionFromSpeed Class](../vs140/clineartransitionfromspeed-class.md)