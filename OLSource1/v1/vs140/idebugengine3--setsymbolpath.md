---
title: "IDebugEngine3::SetSymbolPath"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugEngine3::SetSymbolPath"
helpviewer_keywords: 
  - "IDebugEngine3::SetSymbolPath"
ms.assetid: 47b48f84-8a96-401f-84df-0baa8a96d26e
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine3::SetSymbolPath
Sets the path or paths that are searched for debugging symbols.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|[in] String containing the symbol search path or paths. See "Remarks" for details. Cannot be null.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|[in] String containing the local path where symbols can be cached. Cannot be null.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[in] Not used; always set to 0.|  
  
## Return Value  
 If successful, returns S_OK; otherwise returns an error code.  
  
## Remarks  
 The string <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a list of one or more paths, separated by semicolons, to search for symbols. These paths can be a local path, a UNC-style path, or a URL. These paths can also be a mix of different types. If the path is UNC (for example, \\\Symserver\Symbols), then the debug engine should determine if the path is to a symbol server and should be able to load symbols from that server, caching them in the path specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The symbol path can also contain one or more cache locations. Caches are listed in priority order, with the highest priority cache first, and separated by * symbols. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [IDebugEngine3::LoadSymbols](../vs140/idebugengine3--loadsymbols.md) method performs the actual load of the symbols.  
  
## See Also  
 [IDebugEngine3::LoadSymbols](../vs140/idebugengine3--loadsymbols.md)   
 [IDebugEngine3](../vs140/idebugengine3.md)