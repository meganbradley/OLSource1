---
title: "CComEnumImpl::Next"
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
  - "CComEnumImpl.Next"
  - "CComEnumImpl::Next"
  - "ATL.CComEnumImpl.Next"
  - "ATL::CComEnumImpl::Next"
  - "Next"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Next method"
ms.assetid: 976ddce7-a0af-468b-9770-3743a21d6fb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumImpl::Next
This method provides the implementation of the [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) method.  
  
## Syntax  
  
```  
  
      STDMETHOD(Next)(  
   ULONG celt,  
   T* rgelt,  
   ULONG* pceltFetched   
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements requested.  
  
 `rgelt`  
 [out] The array to be filled with the elements.  
  
 `pceltFetched`  
 [out] The number of elements actually returned in `rgelt`. This can be less than `celt` if fewer than `celt` elements remained in the list.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComEnumImpl Class](../vs140/ccomenumimpl-class.md)