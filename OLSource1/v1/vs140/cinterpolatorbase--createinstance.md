---
title: "CInterpolatorBase::CreateInstance"
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
  - "afxanimationcontroller/CInterpolatorBase::CreateInstance"
  - "CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 2cb66419-6d5a-4453-a7f0-18f88453f604
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterpolatorBase::CreateInstance
Creates an instance of CInterpolatorBase and stores a pointer to custom interpolator, which will be handling events.  
  
## Syntax  
  
```  
static COM_DECLSPEC_NOTHROW HRESULT CreateInstance(  
   CCustomInterpolator* pInterpolator,  
   IUIAnimationInterpolator **ppHandler  
);  
```  
  
#### Parameters  
 `pInterpolator`  
 A pointer to custom interpolator.  
  
 `ppHandler`  
 Output. Contains a pointer to instance of CInterpolatorBase when the function returns.  
  
## Return Value  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CInterpolatorBase Class](../vs140/cinterpolatorbase-class.md)