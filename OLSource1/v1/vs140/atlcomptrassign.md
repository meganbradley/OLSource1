---
title: "AtlComPtrAssign"
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
  - ATL.AtlComPtrAssign
  - AtlComPtrAssign
  - ATL::AtlComPtrAssign
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlComPtrAssign function
ms.assetid: ad99044f-5080-4cdc-bf56-a67b1b415b21
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlComPtrAssign
Assigns an interface pointer to another interface pointer of the same type.  
  
## Syntax  
  
```  
  
      ATLINLINE ATLAPI_(IUnknown*) AtlComPtrAssign(  
   IUnknown** pp,  
   IUnknown* lp  
);  
```  
  
#### Parameters  
 `pp`  
 Address of an **IUnknown** pointer to which to assign another pointer.  
  
 `lp`  
 An **IUnknown** pointer of the same type as the one in `pp`. This is assigned to the pointer in `pp`.  
  
## Return Value  
 Returns NULL on error; otherwise returns `lp`.  
  
## Remarks  
 This function copies an interface pointer using COM reference counting rules. It calls **Release** on the interface pointed to by `pp` and then assigns `lp` to it after incrementing the reference count.  
  
 This smart pointer helper function is used by [CComPtr Class](../vs140/ccomptr-class.md) and [CComQIPtr Class](../vs140/ccomqiptr-class.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtr Class](../vs140/ccomptr-class.md)   
 [CComQIPtr Class](../vs140/ccomqiptr-class.md)