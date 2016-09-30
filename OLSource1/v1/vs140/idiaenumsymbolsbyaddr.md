---
title: "IDiaEnumSymbolsByAddr"
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
  - "IDiaEnumSymbolsbyAddr interface"
ms.assetid: 37d3dcdf-e4fa-4354-b5e1-8843566b52ac
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSymbolsByAddr
Enumerates by address the various symbols contained in the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSymbolsByAddr::symbolByAddr](../vs140/idiaenumsymbolsbyaddr--symbolbyaddr.md)|Positions the enumerator by performing a lookup by section and offset.|  
|[IDiaEnumSymbolsByAddr::symbolByRVA](../vs140/idiaenumsymbolsbyaddr--symbolbyrva.md)|Positions the enumerator by performing a lookup by relative virtual address (RVA).|  
|[IDiaEnumSymbolsByAddr::symbolByVA](../vs140/idiaenumsymbolsbyaddr--symbolbyva.md)|Positions the enumerator by performing a lookup by virtual address (VA).|  
|[IDiaEnumSymbolsByAddr::Next](../vs140/idiaenumsymbolsbyaddr--next.md)|Retrieves the next symbols in order by address. Updates the enumerator position by number of elements fetched.|  
|[IDiaEnumSymbolsByAddr::Prev](../vs140/idiaenumsymbolsbyaddr--prev.md)|Retrieves the previous symbols in order by address. Updates the enumerator position by number of elements fetched.|  
|[IDiaEnumSymbolsByAddr::Clone](../vs140/idiaenumsymbolsbyaddr--clone.md)|Makes a copy of an object.|  
  
## Remarks  
 This interface provides symbols grouped by address. To work with symbols grouped by type, for example <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (user-defined type) or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, use the [IDiaEnumSymbols](../vs140/idiaenumsymbols.md) interface.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaSession::getSymbolsByAddr](../vs140/idiasession--getsymbolsbyaddr.md) method.  
  
## Example  
 This function displays the name and address of all symbols ordered by relative virtual address.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::getSymbolsByAddr](../vs140/idiasession--getsymbolsbyaddr.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)