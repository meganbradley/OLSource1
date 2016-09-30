---
title: "IDiaEnumFrameData"
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
  - "IDiaEnumFrameData interface"
ms.assetid: 2ca7fd5a-b2fa-4b3a-9492-0263eafc435b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumFrameData
Enumerates the various frame data elements contained in the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumFrameData::get__NewEnum](../vs140/idiaenumframedata--get__newenum.md)|Retrieves the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> version of this enumerator.|  
|[IDiaEnumFrameData::get_Count](../vs140/idiaenumframedata--get_count.md)|Retrieves the number of frame data elements.|  
|[IDiaEnumFrameData::Item](../vs140/idiaenumframedata--item.md)|Retrieves a frame data element by means of an index.|  
|[IDiaEnumFrameData::Next](../vs140/idiaenumframedata--next.md)|Retrieves a specified number of frame data elements in the enumeration sequence.|  
|[IDiaEnumFrameData::Skip](../vs140/idiaenumframedata--skip.md)|Skips a specified number of frame data elements in an enumeration sequence.|  
|[IDiaEnumFrameData::Reset](../vs140/idiaenumframedata--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumFrameData::Clone](../vs140/idiaenumframedata--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[IDiaEnumFrameData::frameByRVA](../vs140/idiaenumframedata--framebyrva.md)|Returns a frame by relative virtual address (RVA).|  
|[IDiaEnumFrameData::frameByVA](../vs140/idiaenumframedata--framebyva.md)|Returns a frame by virtual address (VA).|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface from the [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md) method. See the example for details.  
  
## Example  
 This example shows how to obtain (the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function) and use (the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function) the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface. See the [IDiaFrameData](../vs140/idiaframedata.md) interface for an example of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** Dia2.h  
  
 **Library:** diaguids.lib  
  
 **DLL:** msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)