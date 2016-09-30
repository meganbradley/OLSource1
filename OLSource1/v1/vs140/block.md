---
title: "Block"
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
  - "SymTagBlock symbol"
  - "nested scopes"
  - "Block symbol"
ms.assetid: 95b7b0c1-ecc9-405f-8456-5f9cfb866498
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Block
Each code block is identified by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol. Block symbols are used to identify nested scopes within functions.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Number of bytes of code in the block.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Symbol of the enclosing block or function.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Returns the ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Blocks have static locations; for details, see [Symbol Locations](../vs140/symbol-locations.md).|  
|[name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Returns the name of the block (which is usually an empty string).|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Returns the virtual address of this block relative to its lexical parent.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Returns the virtual address of this block within the executable.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)