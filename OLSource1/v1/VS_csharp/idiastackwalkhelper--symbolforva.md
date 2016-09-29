---
title: "IDiaStackWalkHelper::symbolForVA"
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
  - "IDiaStackWalkHelper::symbolForVA method"
ms.assetid: 8dd9455d-d44c-4dd6-a0aa-31131cbea2aa
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::symbolForVA
Retrieves the symbol that contains the specified virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT symbolForVA(   
   ULONGLONG     va,  
   IDiaSymbol**  ppSymbol  
);  
```  
  
#### Parameters  
 `va`  
 [in] The virtual address that is contained in the requested symbol. The symbol must be a `SymTagFunctionType` (a value from the [SymTagEnum](../VS_csharp/symtagenum.md) enumeration).  
  
 `ppSymbol`  
 [out] An [IDiaSymbol](../VS_csharp/idiasymbol.md) object that represents the symbol at the specified address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md)   
 [IDiaSymbol](../VS_csharp/idiasymbol.md)