---
title: "IDiaEnumSourceFiles"
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
  - "IDiaEnumSourceFiles interface"
ms.assetid: 5c0779a6-a2ea-408a-90da-ebdecf2b83c0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSourceFiles
Enumerates the various source files contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSourceFiles : IUknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSourceFiles`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSourceFiles::get__NewEnum](../vs140/idiaenumsourcefiles--get__newenum.md)|Retrieves the `IEnumVARIANT Interface` version of this enumerator.|  
|[IDiaEnumSourceFiles::get_Count](../vs140/idiaenumsourcefiles--get_count.md)|Retrieves the number of source files.|  
|[IDiaEnumSourceFiles::Item](../vs140/idiaenumsourcefiles--item.md)|Retrieves a source file by means of an index.|  
|[IDiaEnumSourceFiles::Next](../vs140/idiaenumsourcefiles--next.md)|Retrieves a specified number of source files in the enumeration sequence.|  
|[IDiaEnumSourceFiles::Skip](../vs140/idiaenumsourcefiles--skip.md)|Skips a specified number of source files in an enumeration sequence.|  
|[IDiaEnumSourceFiles::Reset](../vs140/idiaenumsourcefiles--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSourceFiles::Clone](../vs140/idiaenumsourcefiles--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the `QueryInterface` method on an [IDiaTable](../vs140/idiatable.md) object. See the example for details.  
  
## Example  
 This example shows how to obtain the `IDiaEnumSourceFiles` interface from the list of tables in a DIA session object. For an example of accessing source file information, see the [IDiaSourceFile](../vs140/idiasourcefile.md) interface.  
  
```cpp#  
  
IDiaEnumSourceFiles* GetEnumSourceFiless(IDiaSession *pSession)  
{  
    IDiaEnumSourceFiles * pUnknown    = NULL;  
    REFIID                iid         = __uuidof(IDiaEnumSourceFiles);  
    IDiaEnumTables*       pEnumTables = NULL;  
    IDiaTable*            pTable      = NULL;  
    ULONG                 celt        = 0;  
  
    if (pSession->getEnumTables(&pEnumTables) != S_OK)  
    {  
        wprintf(L"ERROR - GetTable() getEnumTables\n");  
        return NULL;  
    }  
    while (pEnumTables->Next(1, &pTable, &celt) == S_OK && celt == 1)  
    {  
        // There is only one table that matches the given iid  
        HRESULT hr = pTable->QueryInterface(iid, (void**)&pUnknown);  
        pTable->Release();  
        if (hr == S_OK)  
        {  
            break;  
        }  
    }  
    pEnumTables->Release();  
    return pUnknown;  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::findFile](../vs140/idiasession--findfile.md)   
 [IDiaSession::findLinesByLinenum](../vs140/idiasession--findlinesbylinenum.md)   
 [IDiaTable](../vs140/idiatable.md)