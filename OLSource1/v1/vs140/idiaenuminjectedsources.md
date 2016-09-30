---
title: "IDiaEnumInjectedSources"
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
  - "IDiaEnumInjectedSources interface"
ms.assetid: f97e2392-22e1-48da-b7ce-ad94c8b684b0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumInjectedSources
Enumerate the various injected sources contained in the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumInjectedSources::get__NewEnum](../vs140/idiaenuminjectedsources--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumInjectedSources::get_Count](../vs140/idiaenuminjectedsources--get_count.md)|Retrieves the number of injected sources.|  
|[IDiaEnumInjectedSources::Item](../vs140/idiaenuminjectedsources--item.md)|Retrieves an injected source by means of an index.|  
|[IDiaEnumInjectedSources::Next](../vs140/idiaenuminjectedsources--next.md)|Retrieves a specified number of injected sources in the enumeration sequence.|  
|[IDiaEnumInjectedSources::Skip](../vs140/idiaenuminjectedsources--skip.md)|Skips a specified number of injected sources in an enumeration sequence.|  
|[IDiaEnumInjectedSources::Reset](../vs140/idiaenuminjectedsources--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumInjectedSources::Clone](../vs140/idiaenuminjectedsources--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 This interface is obtained by calling the [IDiaSession::findInjectedSource](../vs140/idiasession--findinjectedsource.md) method with the name of a specific source file or by calling the [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md) method with the GUID of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface.  
  
## Example  
 This example shows how to obtain (the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function) and use (the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function) the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface. See the [IDiaPropertyStorage](../vs140/idiapropertystorage.md) interface for an implementation of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function. For an alternative output, see the [IDiaInjectedSource](../vs140/idiainjectedsource.md) interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::findInjectedSource](../vs140/idiasession--findinjectedsource.md)   
 [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md)   
 [IDiaPropertyStorage](../vs140/idiapropertystorage.md)   
 [IDiaInjectedSource](../vs140/idiainjectedsource.md)