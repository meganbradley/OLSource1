---
title: "IDebugDisassemblyStream2::GetScope"
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
  - "IDebugDisassemblyStream2::GetScope"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetScope"
ms.assetid: 71c6e632-642a-42d8-a995-77e4ac190a5b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::GetScope
Gets the scope of the disassembly stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns a value from the [DISASSEMBLY_STREAM_SCOPE](../vs140/disassembly_stream_scope.md) enumeration that describes the scope of this disassembly stream.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The scope of a disassembly could be a function or the whole module, for example.  
  
## See Also  
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)   
 [DISASSEMBLY_STREAM_SCOPE](../vs140/disassembly_stream_scope.md)