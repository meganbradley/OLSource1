---
title: "IDiaEnumStackFrames"
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
  - "IDiaEnumStackFrames interface"
ms.assetid: 3d1e8403-c9fc-42ff-ae35-0ab9a5ed2ad7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumStackFrames
Enumerates the various stack frames available.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumStackFrames::Next](../vs140/idiaenumstackframes--next.md)|Retrieves a specified number of stack frame elements from the enumeration sequence.|  
|[IDiaEnumStackFrames::Reset](../vs140/idiaenumstackframes--reset.md)|Resets an enumeration sequence to the beginning.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaStackWalker::getEnumFrames](../vs140/idiastackwalker--getenumframes.md) or [IDiaStackWalker::getEnumFrames2](../vs140/idiastackwalker--getenumframes2.md) methods.  
  
## Example  
 This example shows how to obtain and use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface. See the [IDiaStackFrame](../vs140/idiastackframe.md) interface for an implementation of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaStackWalkFrame](../vs140/idiastackwalkframe.md)   
 [IDiaStackWalker::getEnumFrames2](../vs140/idiastackwalker--getenumframes2.md)   
 [IDiaStackWalker::getEnumFrames](../vs140/idiastackwalker--getenumframes.md)