---
title: "IDiaEnumLineNumbers"
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
  - "IDiaEnumLineNumbers interface"
ms.assetid: cdf07b4f-19e4-4dcd-8af8-c2dbca586a7c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumLineNumbers
Enumerates the various line numbers contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumLineNumbers : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumLineNumbers`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumLineNumbers::get__NewEnum](../VS_csharp/idiaenumlinenumbers--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumLineNumbers::get_Count](../VS_csharp/idiaenumlinenumbers--get_count.md)|Retrieves the number of line numbers.|  
|[IDiaEnumLineNumbers::Item](../VS_csharp/idiaenumlinenumbers--item.md)|Retrieves a line number by means of an index.|  
|[IDiaEnumLineNumbers::Next](../VS_csharp/idiaenumlinenumbers--next.md)|Retrieves a specified number of line numbers in the enumeration sequence.|  
|[IDiaEnumLineNumbers::Skip](../VS_csharp/idiaenumlinenumbers--skip.md)|Skips a specified number of line numbers in an enumeration sequence.|  
|[IDiaEnumLineNumbers::Reset](../VS_csharp/idiaenumlinenumbers--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumLineNumbers::Clone](../VS_csharp/idiaenumlinenumbers--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 This interface is obtained by calling one of the following methods in the [IDiaSession](../VS_csharp/idiasession.md) interface:  
  
-   [IDiaSession::findLines](../VS_csharp/idiasession--findlines.md)  
  
-   [IDiaSession::findLinesByAddr](../VS_csharp/idiasession--findlinesbyaddr.md)  
  
-   [IDiaSession::findLinesByRVA](../VS_csharp/idiasession--findlinesbyrva.md)  
  
-   [IDiaSession::findLinesByVA](../VS_csharp/idiasession--findlinesbyva.md)  
  
-   [IDiaSession::findLinesByLinenum](../VS_csharp/idiasession--findlinesbylinenum.md)  
  
## Example  
 This example shows how to obtain the `IDiaEnumLineNumbers` interface from a session. In this case, the example shows how to get the line number enumeration for a function (represented by `pSymbol`). For a more complete example of using line numbers, see the [IDiaLineNumber](../VS_csharp/idialinenumber.md) interface.  
  
```cpp#  
void dumpFunctionLines( IDiaSymbol* pSymbol, IDiaSession* pSession )  
{  
    ULONGLONG length = 0;  
    DWORD isect = 0;  
    DWORD offset = 0;  
    pSymbol->get_addressSection( &isect );  
    pSymbol->get_addressOffset( &offset );  
    pSymbol->get_length( &length );  
    if ( isect != 0 && length > 0 )  
    {  
        CComPtr< IDiaEnumLineNumbers > pLines;  
        if ( SUCCEEDED( pSession->findLinesByAddr(  
                                      isect,  
                                      offset,  
                                      static_cast<DWORD>( length ),  
                                      &pLines )  
                      )  
           )  
        {  
            // Do something with the enumeration  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_csharp/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession](../VS_csharp/idiasession.md)   
 [IDiaSession::findLinesByLinenum](../VS_csharp/idiasession--findlinesbylinenum.md)   
 [IDiaSession::findLinesByRVA](../VS_csharp/idiasession--findlinesbyrva.md)   
 [IDiaSession::findLinesByVA](../VS_csharp/idiasession--findlinesbyva.md)   
 [IDiaSession::findLines](../VS_csharp/idiasession--findlines.md)   
 [IDiaSession::findLinesByAddr](../VS_csharp/idiasession--findlinesbyaddr.md)