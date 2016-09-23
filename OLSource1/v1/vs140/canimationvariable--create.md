---
title: "CAnimationVariable::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - Create
  - afxanimationcontroller/CAnimationVariable::Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: b9dba546-3eb4-4671-aa5b-baf05ae7b586
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationVariable::Create
Creates the underlying animation variable COM object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   IUIAnimationManager* pManager  
);  
```  
  
#### Parameters  
 `pManager`  
 A pointer to animation manager.  
  
## Return Value  
 TRUE if the animation variable was successfully created; otherwise FALSE.  
  
## Remarks  
 This method creates the underlying animation variable COM object and sets its default value.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)