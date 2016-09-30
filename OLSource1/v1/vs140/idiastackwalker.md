---
title: "IDiaStackWalker"
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
  - "IDiaStackWalker interface"
ms.assetid: 4a61a22a-9cf8-4ea1-9e6e-b42f96872d40
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalker
Provides methods to do a stack walk using information in the .pdb file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackWalker::getEnumFrames](../vs140/idiastackwalker--getenumframes.md)|Retrieves a stack frame enumerator for x86 platforms.|  
|[IDiaStackWalker::getEnumFrames2](../vs140/idiastackwalker--getenumframes2.md)|Retrieves a stack frame enumerator for a specific platform type.|  
  
## Remarks  
 This interface is used to obtain a list of stack frames for a loaded module. Each of the methods is passed an [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md) object (implemented by the client application) which provides the necessary information to create the list of stack frames.  
  
## Notes for Callers  
 This interface is obtained by calling the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method with the class identifier <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and the interface ID of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The example shows how this interface is obtained.  
  
## Example  
 This example shows how to obtain the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)