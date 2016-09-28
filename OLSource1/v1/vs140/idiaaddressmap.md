---
title: "IDiaAddressMap"
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
  - "IDiaAddressMap interface"
ms.assetid: e6467529-508c-4328-85d7-89444ae4d1c1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaAddressMap
Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.  
  
## Syntax  
  
```  
IDiaAddressMap : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaAddressMap`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaAddressMap::get_addressMapEnabled](../vs140/idiaaddressmap--get_addressmapenabled.md)|Indicates whether an address map has been established for a particular session.|  
|[IDiaAddressMap::put_addressMapEnabled](../vs140/idiaaddressmap--put_addressmapenabled.md)|Specifies whether the address map should be used to translate symbol addresses.|  
|[IDiaAddressMap::get_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--get_relativevirtualaddressenabled.md)|Indicates whether the calculation and use of relative virtual addresses is enabled.|  
|[IDiaAddressMap::put_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--put_relativevirtualaddressenabled.md)|Allows the client to enable or disable the calculation of relative virtual addresses.|  
|[IDiaAddressMap::get_imageAlign](../vs140/idiaaddressmap--get_imagealign.md)|Retrieves the current image alignment.|  
|[IDiaAddressMap::put_imageAlign](../vs140/idiaaddressmap--put_imagealign.md)|Sets the image alignment.|  
|[IDiaAddressMap::set_imageHeaders](../vs140/idiaaddressmap--set_imageheaders.md)|Sets image headers to enable the translation of relative virtual addresses.|  
|[IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md)|Provides an address map to support image layout translations.|  
  
## Remarks  
 The control provided by this interface is encapsulated in two sets of data you supply: image headers and address maps. Most clients use the [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md) method to find the proper debug information for an image and the method can typically discover all of the necessary headers and maps data itself. However some clients implement specialized processing and searching for data. Such clients use the methods of the `IDiaAddressMap` interface to provide the DIA SDK with the search results.  
  
## Notes for Callers  
 This interface is available from the DIA session object. The client calls the `QueryInterface` method on DIA session object interface, usually [IDiaSession](../vs140/idiasession.md), to retrieve the `IDiaAddressMap` interface.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md)   
 [IDiaSession](../vs140/idiasession.md)