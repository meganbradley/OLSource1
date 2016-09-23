---
title: "CComSafeArrayBound::SetLowerBound"
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
  - ATL::CComSafeArrayBound::SetLowerBound
  - ATL.CComSafeArrayBound.SetLowerBound
  - CComSafeArrayBound.SetLowerBound
  - SetLowerBound
  - CComSafeArrayBound::SetLowerBound
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetLowerBound method
ms.assetid: 98198291-c12d-4745-95cb-e74d9275f922
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComSafeArrayBound::SetLowerBound
Call this method to set the lower bound.  
  
## Syntax  
  
```  
  
      LONG SetLowerBound(  
   LONG lLowerBound   
) throw( );  
```  
  
#### Parameters  
 `lLowerBound`  
 The lower bound.  
  
## Return Value  
 Returns the new lower bound of the `CComSafeArrayBound` object.  
  
## Remarks  
 If the array is to be accessed from a Visual C++ program, it is recommended that the lower bound be defined as 0. It may be preferable to use a different lower bound value if the array is to be used with other languages, such as Visual Basic.  
  
 The upper bound depends on the number of elements and the lower bound value. For example, if the lower bound is 0 and the number of elements is 10, the upper bound will automatically be set to 9.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArrayBound Class](../vs140/ccomsafearraybound-class.md)   
 [CComSafeArrayBound::GetUpperBound](../vs140/ccomsafearraybound--getupperbound.md)   
 [CComSafeArrayBound::GetLowerBound](../vs140/ccomsafearraybound--getlowerbound.md)   
 [CComSafeArrayBound::SetCount](../vs140/ccomsafearraybound--setcount.md)