---
title: "IDiaEnumSymbolsByAddr::symbolByAddr"
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
  - "IDiaEnumSymbolsByAddr::symbolByAddr method"
ms.assetid: 0b6f5a68-8402-4f29-8219-20576fda8166
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSymbolsByAddr::symbolByAddr
Positions the enumerator by performing a lookup by image section number and offset.  
  
## Syntax  
  
```cpp#  
HRESULT symbolByAddr (   
   DWORD**      isect,  
   DWORD**      offsect,  
   IDiaSymbol** ppsymbol  
);  
```  
  
#### Parameters  
 isect  
 [in] Image section number.  
  
 offsect  
 [in] Offset in section.  
  
 ppsymbol  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object representing the symbol found.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSymbolsByAddr](../vs140/idiaenumsymbolsbyaddr.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)