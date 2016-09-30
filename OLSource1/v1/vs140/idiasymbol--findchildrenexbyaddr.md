---
title: "IDiaSymbol::findChildrenExByAddr"
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
  - "IDiaSymbol::findChildrenExByAddr"
ms.assetid: c1e7885d-2d15-4529-9ac2-32dd22efe31c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::findChildrenExByAddr
Retrieves the children of the symbol that are valid at a specified address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the symbol tags of the children to be retrieved, as defined in the [SymTagEnum Enumeration](../vs140/symtagenum.md). Set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for all children to be retrieved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the name of the children to be retrieved. Set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for all children to be retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Specifies the comparison options to be applied to name matching. Values from the [NameSearchOptions Enumeration](../vs140/namesearchoptions.md) enumeration can be used alone or in combination.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The address of the symbol.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumSymbols](../vs140/idiaenumsymbols.md) object that contains a list of the child symbols retrieved.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if at least one child of the symbol was found, or returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if no children were found; otherwise, returns an error code.  
  
## Remarks  
 The local symbols that are returned include live range information.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)   
 [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)   
 [NameSearchOptions Enumeration](../vs140/namesearchoptions.md)