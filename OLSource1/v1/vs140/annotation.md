---
title: "Annotation"
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
  - "SymTabAnnotation symbol"
  - "Annotation symbol"
ms.assetid: eb9f759b-98a5-45fc-b085-91f1f2666e72
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Annotation
A location program code can be annotated with a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_dataKind](../vs140/idiasymbol--get_datakind.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|One of the [DataKind Enumeration](../vs140/datakind.md) values.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Relative position of this annotation within its module.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_value](../vs140/idiasymbol--get_value.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The value of constant data.|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Position of this annotation within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)