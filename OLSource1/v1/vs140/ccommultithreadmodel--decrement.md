---
title: "CComMultiThreadModel::Decrement"
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
  - "CComMultiThreadModel.Decrement"
  - "CComMultiThreadModel::Decrement"
  - "Decrement"
  - "ATL.CComMultiThreadModel.Decrement"
  - "ATL::CComMultiThreadModel::Decrement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Decrement method"
ms.assetid: 1f8a6b1e-faab-485b-be81-321d0f377f3d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModel::Decrement
This static function calls the Win32 function [InterlockedDecrement](http://msdn.microsoft.com/library/windows/desktop/ms683580), which decrements the value of the variable pointed to by `p`.  
  
## Syntax  
  
```  
  
      static ULONG WINAPI Decrement(  
   LPLONG p   
) throw ( );  
```  
  
#### Parameters  
 `p`  
 [in] Pointer to the variable to be decremented.  
  
## Return Value  
 If the result of the decrement is 0, then `Decrement` returns 0. If the result of the decrement is nonzero, the return value is also nonzero but may not equal the result of the decrement.  
  
## Remarks  
 **InterlockedDecrement** prevents more than one thread from simultaneously using this variable.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModel Class](../vs140/ccommultithreadmodel-class.md)   
 [CComMultiThreadModel::Increment](../vs140/ccommultithreadmodel--increment.md)