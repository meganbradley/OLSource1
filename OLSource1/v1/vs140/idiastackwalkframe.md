---
title: "IDiaStackWalkFrame"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDiaStackWalkFrame interface
ms.assetid: 42d82845-d6f6-4846-9ecd-9dd169216077
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaStackWalkFrame
Maintains stack context between invocations of the [IDiaFrameData::execute](../vs140/idiaframedata--execute.md) method.  
  
## Syntax  
  
```  
IDiaStackWalkFrame : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaStackWalkFrame`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackWalkFrame::get_registerValue](../vs140/idiastackwalkframe--get_registervalue.md)|Retrieves the value of a register.|  
|[IDiaStackWalkFrame::put_registerValue](../vs140/idiastackwalkframe--put_registervalue.md)|Sets the value of a register.|  
|[IDiaStackWalkFrame::readMemory](../vs140/idiastackwalkframe--readmemory.md)|Reads memory from image.|  
|[IDiaStackWalkFrame::searchForReturnAddress](../vs140/idiastackwalkframe--searchforreturnaddress.md)|Searches the specified stack frame for the nearest function return address.|  
|[IDiaStackWalkFrame::searchForReturnAddressStart](../vs140/idiastackwalkframe--searchforreturnaddressstart.md)|Searches the specified stack frame for a return address at or near the specified address.|  
  
## Remarks  
 This interface is used during program execution to read and write registers as well as access memory and find return addresses.  
  
## Notes for Callers  
 The client application implements this interface and passes an instance of the interface to the [IDiaFrameData::execute](../vs140/idiaframedata--execute.md) method. The same instance of this interface is used again and again to maintain the state of the registers during each invocation of the `execute` method. The `execute` method also uses this interface to determine the return address.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaFrameData::execute](../vs140/idiaframedata--execute.md)