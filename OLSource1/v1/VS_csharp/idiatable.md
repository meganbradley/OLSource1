---
title: "IDiaTable"
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
  - "IDiaTable interface"
ms.assetid: c99a2c44-7b72-4e3c-b963-25fe3df3a555
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaTable
Enumerates a DIA data source table.  
  
## Syntax  
  
```  
IDiaTable : IEnumUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaTable`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaTable::get__NewEnum](../VS_csharp/idiatable--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaTable::get_name](../VS_csharp/idiatable--get_name.md)|Retrieves the name of the table.|  
|[IDiaTable::get_Count](../VS_csharp/idiatable--get_count.md)|Retrieves the number of items in the table.|  
|[IDiaTable::Item](../VS_csharp/idiatable--item.md)|Retrieves a reference to a particular entry index.|  
  
## Remarks  
 This interface implements the `IEnumUnknown` enumeration methods in the Microsoft.VisualStudio.OLE.Interop namespace. The `IEnumUnknown` enumeration interface is much more efficient for iterating over the table contents than the [IDiaTable::get_Count](../VS_csharp/idiatable--get_count.md) and [IDiaTable::Item](../VS_csharp/idiatable--item.md) methods.  
  
 The interpretation of the `IUnknown` interface returned from either the `IDiaTable::Item` method or the `Next` method (in the Microsoft.VisualStudio.OLE.Interop namespace) is dependent on the type of table. For example, if the `IDiaTable` interface represents a list of injected sources, the `IUnknown` interface should be queried for the [IDiaInjectedSource](../VS_csharp/idiainjectedsource.md) interface.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumTables::Item](../VS_csharp/idiaenumtables--item.md) or [IDiaEnumTables::Next](../VS_csharp/idiaenumtables--next.md) methods.  
  
 The following interfaces are implemented with the `IDiaTable` interface (that is, you can query the `IDiaTable` interface for one of the following interfaces):  
  
-   [IDiaEnumSymbols](../VS_csharp/idiaenumsymbols.md)  
  
-   [IDiaEnumSourceFiles](../VS_csharp/idiaenumsourcefiles.md)  
  
-   [IDiaEnumLineNumbers](../VS_csharp/idiaenumlinenumbers.md)  
  
-   [IDiaEnumSectionContribs](../VS_csharp/idiaenumsectioncontribs.md)  
  
-   [IDiaEnumSegments](../VS_csharp/idiaenumsegments.md)  
  
-   [IDiaEnumInjectedSources](../VS_csharp/idiaenuminjectedsources.md)  
  
-   [IDiaEnumFrameData](../VS_csharp/idiaenumframedata.md)  
  
## Example  
 The first function, `ShowTableNames`, displays the names of all the tables in the session. The second function, `GetTable`, searches all of the tables for a table that implements a specified interface. The third function, `UseTable`, shows how to use the `GetTable` function.  
  
> [!NOTE]
>  `CDiaBSTR` is a class that wraps a `BSTR` and automatically handles freeing the string when the instantiation goes out of scope.  
  
```cpp#  
void ShowTableNames(IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumTables> pTables;  
    if ( FAILED( psession->getEnumTables( &pTables ) ) )  
    {  
        Fatal( "getEnumTables" );  
    }  
    CComPtr< IDiaTable > pTable;  
    while ( SUCCEEDED( hr = pTables->Next( 1, &pTable, &celt ) )  
            && celt == 1 )  
    {  
        CDiaBSTR bstrTableName;  
        if ( pTable->get_name( &bstrTableName ) != 0 )  
        {  
            Fatal( "get_name" );  
        }  
        printf( "Found table: %ws\n", bstrTableName );  
    }  
  
// Searches the list of all tables for a table that supports  
// the specified interface.  Use this function to obtain an  
// enumeration interface.  
HRESULT GetTable(IDiaSession* pSession,  
                 REFIID       iid,  
                 void**       ppUnk)  
{  
    CComPtr<IDiaEnumTables> pEnumTables;  
    HRESULT hResult;  
  
    if (FAILED(pSession->getEnumTables(&pEnumTables)))  
        Fatal("getEnumTables");  
  
    CComPtr<IDiaTable> pTable;  
    ULONG celt = 0;  
    while (SUCCEEDED(hResult = pEnumTables->Next(1, &pTable, &celt)) &&  
           celt == 1)  
    {  
        if (pTable->QueryInterface(iid, (void**)ppUnk) == S_OK)  
        {  
            return S_OK;  
        }  
        pTable = NULL;  
    }  
  
    if (FAILED(hResult))  
        Fatal("EnumTables->Next");  
  
    return E_FAIL;  
}  
  
// This function shows how to use the GetTable function.  
void UseTable(IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumSegments> pEnumSegments;  
    if (SUCCEEDED(GetTable(pSession, __uuidof(IDiaEnumSegments), &pEnumSegments)))  
    {  
        // Do something with pEnumSegments.  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_csharp/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumTables](../VS_csharp/idiaenumtables.md)   
 [IDiaEnumTables::Item](../VS_csharp/idiaenumtables--item.md)   
 [IDiaEnumTables::Next](../VS_csharp/idiaenumtables--next.md)