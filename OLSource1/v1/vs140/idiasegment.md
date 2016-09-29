---
title: "IDiaSegment"
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
  - "IDiaSegment interface"
ms.assetid: 384ae0e1-077e-4d4f-98de-ac43c32c882f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSegment
Maps data from the section number to segments of address space.  
  
## Syntax  
  
```  
IDiaSegment : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaSegment`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSegment::get_frame](../vs140/idiasegment--get_frame.md)|Retrieves the segment number.|  
|[IDiaSegment::get_offset](../vs140/idiasegment--get_offset.md)|Retrieves the offset in segments where the section begins.|  
|[IDiaSegment::get_length](../vs140/idiasegment--get_length.md)|Retrieves the number of bytes in the segment.|  
|[IDiaSegment::get_read](../vs140/idiasegment--get_read.md)|Retrieves a flag that indicates whether the segment can be read.|  
|[IDiaSegment::get_write](../vs140/idiasegment--get_write.md)|Retrieves a flag that indicates whether the segment can be modified.|  
|[IDiaSegment::get_execute](../vs140/idiasegment--get_execute.md)|Retrieves a flag that indicates whether the segment is executable.|  
|[IDiaSegment::get_addressSection](../vs140/idiasegment--get_addresssection.md)|Retrieves the section number that maps to this segment.|  
|[IDiaSegment::get_relativeVirtualAddress](../vs140/idiasegment--get_relativevirtualaddress.md)|Retrieves the relative virtual address (RVA) of the beginning of the section.|  
|[IDiaSegment::get_virtualAddress](../vs140/idiasegment--get_virtualaddress.md)|Retrieves the virtual address (VA) of the beginning of the section.|  
  
## Remarks  
 Because the DIA SDK already performs translations from the section offset to relative virtual addresses, most applications will not make use of the information in the segment map.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumSegments::Item](../vs140/idiaenumsegments--item.md) or [IDiaEnumSegments::Next](../vs140/idiaenumsegments--next.md) methods. See the example for details.  
  
## Example  
 This function displays the address of all segments in a table and the nearest symbol.  
  
```cpp#  
void ShowSegments(IDiaTable *pTable, IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumSegments> pSegments;  
    if ( SUCCEEDED( pTable->QueryInterface(  
                                _uuidof( IDiaEnumSegments ),  
                               (void**)&pSegments )  
                  )  
       )  
    {  
        CComPtr<IDiaSegment> pSegment;  
        while ( SUCCEEDED( hr = pSegments->Next( 1, &pSegment, &celt ) ) &&  
                celt == 1 )  
        {  
            DWORD rva;  
            DWORD seg;  
  
            pSegment->get_addressSection( &seg );  
            if ( pSegment->get_relativeVirtualAddress( &rva ) == S_OK )  
            {  
                printf( "Segment %i addr: 0x%.8X\n", seg, rva );  
                pSegment = NULL;  
  
                CComPtr<IDiaSymbol> pSym;  
                if ( psession->findSymbolByRVA( rva, SymTagNull, &pSym ) == S_OK )  
                {  
                    CDiaBSTR name;  
                    DWORD    tag;  
  
                    pSym->get_symTag( &tag );  
                    pSym->get_name( &name );  
                    printf( "\tClosest symbol: %ws (%ws)\n",  
                            name != NULL ? name : L"",  
                            szTags[ tag ] );  
                }  
            }  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumSegments::Item](../vs140/idiaenumsegments--item.md)   
 [IDiaEnumSegments::Next](../vs140/idiaenumsegments--next.md)