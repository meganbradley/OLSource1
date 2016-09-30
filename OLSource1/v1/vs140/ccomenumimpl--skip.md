---
title: "CComEnumImpl::Skip"
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
  - "CComEnumImpl.Skip"
  - "ATL.CComEnumImpl.Skip"
  - "Skip"
  - "ATL::CComEnumImpl::Skip"
  - "CComEnumImpl::Skip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Skip method"
ms.assetid: 60608152-dd07-487c-b38a-d5efd8af8684
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumImpl::Skip
This method provides the implementation of the [IEnumXXXX::Skip](https://msdn.microsoft.com/en-us/library/ms690392.aspx) method.  
  
## Syntax  
  
```  
  
      STDMETHOD(Skip)(  
   ULONG celt   
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to skip.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 Returns E_INVALIDARG if `celt` is zero, returns S_FALSE if less than `celt` elements are returned, returns S_OK otherwise.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComEnumImpl Class](../vs140/ccomenumimpl-class.md)