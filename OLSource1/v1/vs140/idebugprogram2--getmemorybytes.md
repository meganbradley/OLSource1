---
title: "IDebugProgram2::GetMemoryBytes"
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
  - "IDebugProgram2::GetMemoryBytes"
helpviewer_keywords: 
  - "IDebugProgram2::GetMemoryBytes"
ms.assetid: 1cdedb47-caf8-468e-aaf4-163f16afb403
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::GetMemoryBytes
Retrieves the memory bytes occupied by the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md) object that represents the memory bytes of the program.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The memory bytes as represented by the [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md) object is for the program's image in memory and not any memory that was allocated when the program was executed.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md)