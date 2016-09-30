---
title: "IDiaImageData"
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
  - "IDiaImageData interface"
ms.assetid: b696f350-fc08-4352-9287-a15e87512c1e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaImageData
Exposes the details of the base location and memory offsets of the module or image.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaImageData::get_relativeVirtualAddress](../vs140/idiaimagedata--get_relativevirtualaddress.md)|Retrieves the location in virtual memory of the module relative to the application.|  
|[IDiaImageData::get_virtualAddress](../vs140/idiaimagedata--get_virtualaddress.md)|Retrieves the location in virtual memory of the image.|  
|[IDiaImageData::get_imageBase](../vs140/idiaimagedata--get_imagebase.md)|Retrieves the memory location where the image should be based.|  
  
## Remarks  
 Some debug streams (XDATA, PDATA) contain copies of data also stored in the image. These stream data objects can be queried for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface. See the "Notes for Callers" section in this topic for details.  
  
## Notes for Callers  
 Obtain this interface by calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on an [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md) object. Note that not all debug streams support the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface. For example, currently only the XDATA and PDATA streams support the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface.  
  
## Example  
 This example searches all of the debug streams for any stream that supports the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface. If such a stream is found, some information about that stream is displayed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)