---
title: "CComBSTR::ArrayToBSTR"
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
  - "ATL::CComBSTR::ArrayToBSTR"
  - "CComBSTR::ArrayToBSTR"
  - "ArrayToBSTR"
  - "CComBSTR.ArrayToBSTR"
  - "ATL.CComBSTR.ArrayToBSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ArrayToBSTR method"
ms.assetid: 27b5fb73-5592-4587-825d-ddfcfef1112f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::ArrayToBSTR
Frees any existing string held in the `CComBSTR` object, then creates a `BSTR` from the first character of each element in the safearray and attaches it to the `CComBSTR` object.  
  
## Syntax  
  
```  
  
      HRESULT ArrayToBSTR(  
   const SAFEARRAY* pSrc   
) throw( );  
```  
  
#### Parameters  
 `pSrc`  
 [in] The safearray containing the elements used to create the string.  
  
## Return Value  
 `S_OK` on success, or any standard `HRESULT` error value.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)