---
title: "CComVariant::GetSize"
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
  - "ATL::CComVariant::GetSize"
  - "CComVariant::GetSize"
  - "CComVariant.GetSize"
  - "ATL.CComVariant.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 242d7b30-109f-479a-a32a-77a1db52eb08
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::GetSize
For simple-fixed size `VARIANT`s, this method returns the `sizeof` the underlying data type plus `sizeof(VARTYPE)`.  
  
## Syntax  
  
```  
ULONG GetSize() const;  
```  
  
## Return Value  
 The size in bytes of the current contents of the `CComVariant` object.  
  
## Remarks  
 If the `VARIANT` contains an interface pointer, `GetSize` queries for `IPersistStream` or `IPersistStreamInit`. If successful, the return value is the low-order 32 bits of the value returned by `GetSizeMax` plus the `sizeof` a `CLSID` and `sizeof(VARTYPE)`. If the interface pointer is `NULL`, `GetSize` returns the `sizeof` a `CLSID` plus `sizeof(VARTYPE)`. If the total size is larger than `ULONG_MAX`, `GetSize` returns `sizeof(VARTYPE)` which indicates an error.  
  
 In all other cases, a temporary `VARIANT` of type `VT_BSTR` is coerced from the current `VARIANT`. The length of this `BSTR` is calculated as the size of the length of the string plus the length of the string itself plus the size of the null character plus `sizeof(VARTYPE)`. If the `VARIANT` cannot be coerced to a `VARIANT` of type `VT_BSTR`, `GetSize` returns `sizeof(VARTYPE)`.  
  
 The size returned by this method matches the number of bytes used by [CComVariant::WriteToStream](../vs140/ccomvariant--writetostream.md) under successful conditions.  
  
## Requirements  
 `Header`: atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)