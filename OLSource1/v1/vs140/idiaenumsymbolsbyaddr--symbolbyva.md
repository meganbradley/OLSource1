---
title: "IDiaEnumSymbolsByAddr::symbolByVA"
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
  - "IDiaEnumSymbolsByAddr::symbolByVA method"
ms.assetid: ac84339f-70c6-48ed-85d0-6d7d1b5194e8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSymbolsByAddr::symbolByVA
Positions the enumerator by performing a lookup by virtual address (VA).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 virtualAddress  
 [in] Virtual address.  
  
 ppsymbol  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object representing the symbol found.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the symbol could not be found. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSymbolsByAddr](../vs140/idiaenumsymbolsbyaddr.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)