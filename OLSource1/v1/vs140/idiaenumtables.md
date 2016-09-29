---
title: "IDiaEnumTables"
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
  - "IDiaEnumTables interface"
ms.assetid: 016190c5-09e4-48f2-bf60-9b02603a03e0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumTables
Enumerates the various tables contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumTables : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumTables`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumTables::get__NewEnum](../vs140/idiaenumtables--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumTables::get_Count](../vs140/idiaenumtables--get_count.md)|Retrieves the number of tables.|  
|[IDiaEnumTables::Item](../vs140/idiaenumtables--item.md)|Retrieves a table by means of an index or a name.|  
|[IDiaEnumTables::Next](../vs140/idiaenumtables--next.md)|Retrieves a specified number of tables in the enumeration sequence.|  
|[IDiaEnumTables::Skip](../vs140/idiaenumtables--skip.md)|Skips a specified number of tables in an enumeration sequence.|  
|[IDiaEnumTables::Reset](../vs140/idiaenumtables--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumTables::Clone](../vs140/idiaenumtables--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md) method.  
  
## Example  
 This example shows how to obtain the `IDiaEnumTables` interface from a session. For a more complete example of using tables, see the [IDiaTable](../vs140/idiatable.md) interface.  
  
```cpp#  
void ShowTableNames(IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumTables> pTables;  
    if ( FAILED( psession->getEnumTables( &pTables ) ) )  
    {  
        Fatal( "getEnumTables" );  
    }  
    // Do something with table  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md)