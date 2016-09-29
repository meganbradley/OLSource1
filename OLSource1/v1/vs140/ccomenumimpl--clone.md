---
title: "CComEnumImpl::Clone"
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
  - "ATL::CComEnumImpl::Clone"
  - "CComEnumImpl.Clone"
  - "ATL.CComEnumImpl.Clone"
  - "CComEnumImpl::Clone"
  - "Clone"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Clone method"
ms.assetid: 9565fc0b-178f-433d-aea7-a08c3daf3047
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumImpl::Clone
This method provides the implementation of the [IEnumXXXX::Clone](https://msdn.microsoft.com/en-us/library/ms690336.aspx) method by creating an object of type `CComEnum`, initializing it with the same array and iterator used by the current object, and returning the interface on the newly created object.  
  
## Syntax  
  
```  
  
      STDMETHOD(Clone)(  
   Base** ppEnum   
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] The enumerator interface on a newly created object cloned from the current enumerator.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 Note that cloned enumerators never make their own copy (or take ownership) of the data used by the original enumerator. If necessary, cloned enumerators will keep the original enumerator alive (using a COM reference) to ensure that the data is available for as long as they need it.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComEnumImpl Class](../vs140/ccomenumimpl-class.md)   
 [CComEnumImpl::Init](../vs140/ccomenumimpl--init.md)