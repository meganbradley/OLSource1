---
title: "CComVariant::Copy"
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
  - "ATL.CComVariant.Copy"
  - "CComVariant.Copy"
  - "ATL::CComVariant::Copy"
  - "CComVariant::Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Copy method"
ms.assetid: a6899159-b05c-4def-9c66-87ffb1590d5f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::Copy
Frees the `CComVariant` object and then assigns it a copy of the specified **VARIANT**.  
  
## Syntax  
  
```  
  
      HRESULT Copy(  
   const VARIANT* pSrc   
);  
```  
  
#### Parameters  
 `pSrc`  
 [in] A pointer to the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be copied.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::operator =](../vs140/ccomvariant--operator-=.md)   
 [VariantCopy](assetId:///f6ddbe1f-37b0-44f1-a3f0-b7ef4df88f8a)   
 [CComVariant::CopyTo](../vs140/ccomvariant--copyto.md)