---
title: "PublicSymbol"
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
  - "data symbols [C++]"
  - "PublicSymbol symbol"
  - "global functions [C++], as public symbols"
ms.assetid: f8d33007-302d-4549-9dad-47fb33ea60b7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PublicSymbol
When the .exe file is created, each public symbol (at a minimum, each global function and data symbol) is given a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_code](../vs140/idiasymbol--get_code.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the symbol's location is in code.|  
|[IDiaSymbol::get_function](../vs140/idiasymbol--get_function.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the symbol is a function.|  
|[length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Length of this symbol in bytes.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Symbol for the global scope.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Public symbols have static locations; for details, see [Symbol Locations](../vs140/symbol-locations.md).|  
|[IDiaSymbol::get_managed](../vs140/idiasymbol--get_managed.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the symbol's location is in managed code.|  
|[IDiaSymbol::get_msil](../vs140/idiasymbol--get_msil.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the symbol's location is in Microsoft Intermediate Language (MSIL) code.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The fully decorated name of the symbol.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Relative position of the symbol within its block.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_undecoratedName](../vs140/idiasymbol--get_undecoratedname.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The undecorated symbol name.|  
|[IDiaSymbol::get_undecoratedNameEx Method](../vs140/idiasymbol--get_undecoratednameex.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Part or all of the undecorated symbol name.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)