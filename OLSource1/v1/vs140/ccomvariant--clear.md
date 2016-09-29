---
title: "CComVariant::Clear"
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
  - "CComVariant.Clear"
  - "ATL::CComVariant::Clear"
  - "ATL.CComVariant.Clear"
  - "CComVariant::Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Clear method"
ms.assetid: 5bc68c46-2a57-48fe-a1d4-7bc0df94a124
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::Clear
Clears the `CComVariant` object by calling the `VariantClear` Win32 function.  
  
## Syntax  
  
```  
  
HRESULT Clear( );  
  
```  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The destructor automatically calls **Clear**.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)