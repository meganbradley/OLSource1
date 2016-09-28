---
title: "CSimpleMapEqualHelperFalse::IsEqualKey"
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
  - "CSimpleMapEqualHelperFalse.IsEqualKey"
  - "CSimpleMapEqualHelperFalse::IsEqualKey"
  - "ATL::CSimpleMapEqualHelperFalse::IsEqualKey"
  - "IsEqualKey"
  - "ATL.CSimpleMapEqualHelperFalse.IsEqualKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEqualKey method"
ms.assetid: a31369a0-f92e-4554-9b06-9713cf7eb708
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMapEqualHelperFalse::IsEqualKey
Tests two keys for equality.  
  
## Syntax  
  
```  
  
      static bool IsEqualKey(  
   const TKey& k1,  
   const TKey& k2   
);  
```  
  
#### Parameters  
 `k1`  
 The first key.  
  
 `k2`  
 The second key.  
  
## Return Value  
 Returns true if the keys are equal, false otherwise.  
  
## Remarks  
 This method calls [CSimpleArrayEqualHelper](../vs140/csimplearrayequalhelper-class.md).  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMapEqualHelperFalse Class](../vs140/csimplemapequalhelperfalse-class.md)   
 [CSimpleMapEqualHelperFalse::IsEqualValue](../vs140/csimplemapequalhelperfalse--isequalvalue.md)