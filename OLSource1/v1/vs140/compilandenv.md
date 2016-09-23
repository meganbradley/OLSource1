---
title: "CompilandEnv"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - CompilandEnv symbol
ms.assetid: 808404bb-ece1-47f1-b9ea-c76d4d86ddd9
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CompilandEnv
The compiler may include additional environment variables with symbols. There is one `SymTagCompilandEnv` symbol for each of these variables.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the parent compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|`BSTR`|Name of the variable.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagCompilandEnv` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_value](../vs140/idiasymbol--get_value.md)|`VARIANT`|String-valued contents of the variable (`VT_BSTR`).|  
  
## See Also  
 [Compiland](../vs140/compiland.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)