---
title: "IDiaEnumSegments"
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
  - "IDiaEnumSegments interface"
ms.assetid: 0c9edd5e-b9ce-43e1-a791-cd4c5d16d923
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSegments
Enumerates the various segments contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSegments : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSegments`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSegments::get__NewEnum](../VS_csharp/idiaenumsegments--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumSegments::get_Count](../VS_csharp/idiaenumsegments--get_count.md)|Retrieves the number of segments.|  
|[IDiaEnumSegments::Item](../VS_csharp/idiaenumsegments--item.md)|Retrieves a segment by means of an index.|  
|[IDiaEnumSegments::Next](../VS_csharp/idiaenumsegments--next.md)|Retrieves a specified number of segments in the enumeration sequence.|  
|[IDiaEnumSegments::Skip](../VS_csharp/idiaenumsegments--skip.md)|Skips a specified number of segments in an enumeration sequence.|  
|[IDiaEnumSegments::Reset](../VS_csharp/idiaenumsegments--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSegments::Clone](../VS_csharp/idiaenumsegments--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the `QueryInterface` method on an [IDiaTable](../VS_csharp/idiatable.md) object. See the example for details.  
  
## Example  
 This example shows how to obtain the `IDiaEnumSections` interface from a table. For a more complete example of using segments, see the [IDiaSegment](../VS_csharp/idiasegment.md) interface.  
  
```cpp#  
void ShowSegments(IDiaTable *pTable, IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumSegments> pSegments;  
    if ( SUCCEEDED( pTable->QueryInterface(  
                                __uuidof( IDiaEnumSegments ),  
                                (void**)&pSegments )  
                  )  
       )  
    {  
        // Do something with this enumeration  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_csharp/interfaces--debug-interface-access-sdk-.md)   
 [IDiaTable](../VS_csharp/idiatable.md)   
 [IDiaSegment](../VS_csharp/idiasegment.md)