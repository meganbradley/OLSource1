---
title: "IDiaEnumSymbols::get__NewEnum"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSymbols::get__NewEnum method"
ms.assetid: 879609ea-8e5a-4fa3-afa6-d24870fb4392
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSymbols::get__NewEnum
Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT*> version of this enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT get__NewEnum (   
   IUnknown** pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns the `IUnknown` interface that represents the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT*> version of this enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)