---
title: "Custom (Debug Interface Access SDK)"
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
  - "Custom symbol"
ms.assetid: a219fc83-d2a8-4bc5-b7e1-bfafeb247f16
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Custom (Debug Interface Access SDK)
Some compilers introduce symbols that are not identified by any of the standard lexical symbol types. These symbols are identified by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_dataBytes](../vs140/idiasymbol--get_databytes.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Array of data associated with the symbol.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)