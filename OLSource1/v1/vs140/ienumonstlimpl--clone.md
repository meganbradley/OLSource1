---
title: "IEnumOnSTLImpl::Clone"
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
  - "IEnumOnSTLImpl::Clone"
  - "ATL.IEnumOnSTLImpl.Clone"
  - "Clone"
  - "IEnumOnSTLImpl.Clone"
  - "ATL::IEnumOnSTLImpl::Clone"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Clone method"
ms.assetid: 6b87a9c4-6a0e-42cb-b4eb-03e32a793b4c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IEnumOnSTLImpl::Clone
This method provides the implementation of the [IEnumXXXX::Clone](https://msdn.microsoft.com/en-us/library/ms690336.aspx) method by creating an object of type `CComEnumOnSTL`, initializing it with the same collection and iterator used by the current object, and returning the interface on the newly created object.  
  
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
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)   
 [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md)