---
title: "IDebugProgram2::WriteDump"
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
  - "IDebugProgram2::WriteDump"
helpviewer_keywords: 
  - "IDebugProgram2::WriteDump"
ms.assetid: 375afb8c-882d-44db-bfa7-e2c9eb555122
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::WriteDump
Writes a dump to a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [DUMPTYPE](../vs140/dumptype.md) enumeration that specifies the type of dump, for example, short or long.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The URL to write the dump to. Typically, this is in the form of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, but may be any valid URL.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A program dump would typically include the current stack frame, the stack itself, a list of the threads running in the program, and possibly any memory that the program owns.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)