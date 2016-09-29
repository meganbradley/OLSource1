---
title: "IDiaSymbol::get_compilerName"
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
  - "IDiaSymbol::get_compilerName method"
ms.assetid: 66eaaf72-68d4-40ee-b132-97bea9fe395c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_compilerName
Returns the name of the compiler used to generate the [Compiland](../vs140/compiland.md).  
  
## Syntax  
  
```cpp#  
HRESULT get_compilerName (  
   BSTR *pName  
);  
```  
  
#### Parameters  
 `pName`  
 Pointer to a BSTR that will contain the Unicode name of the compiler.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol Interface](../vs140/idiasymbol.md)