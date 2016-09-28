---
title: "CSimpleArrayEqualHelperFalse::IsEqual"
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
  - "CSimpleArrayEqualHelperFalse<T>::IsEqual"
  - "CSimpleArrayEqualHelperFalse.IsEqual"
  - "ATL::CSimpleArrayEqualHelperFalse::IsEqual"
  - "ATL.CSimpleArrayEqualHelperFalse.IsEqual"
  - "CSimpleArrayEqualHelperFalse::IsEqual"
  - "ATL::CSimpleArrayEqualHelperFalse<T>::IsEqual"
  - "IsEqual"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEqual function"
ms.assetid: fb289ea3-2309-45fe-b1ba-40c2d688dcfd
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArrayEqualHelperFalse::IsEqual
Returns false.  
  
## Syntax  
  
```  
  
      static bool IsEqual(  
   const T& ,  
   const T&   
);  
```  
  
## Return Value  
 Returns false.  
  
## Remarks  
 This method always returns false, and will call `ATLASSERT` with an argument of false if referenced. The purpose of `CSimpleArrayEqualHelperFalse::IsEqual` is to force methods using comparisons to fail in a well-defined manner when equality tests have not been adequately defined.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArrayEqualHelperFalse Class](../vs140/csimplearrayequalhelperfalse-class.md)