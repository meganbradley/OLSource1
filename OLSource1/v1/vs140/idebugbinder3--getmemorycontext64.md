---
title: "IDebugBinder3::GetMemoryContext64"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "GetMemoryContext64"
  - "IDebugBinder3::GetMemoryContext64"
ms.assetid: f021fd16-9fc7-4c41-86af-e54e6224cfbb
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetMemoryContext64
Converts either an object location or a 64-bit memory address to a memory context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An [IDebugField](../vs140/idebugfield.md) that describes the object to locate. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> instead.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A 64-bit memory address, such as 0x50000000.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) interface that represents the address of the object, or the address in memory.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following examples creates an object that implements the [IDebugBinder3](../vs140/idebugbinder3.md) interface and uses this method to retrieve the memory context.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)