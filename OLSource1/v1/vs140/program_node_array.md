---
title: "PROGRAM_NODE_ARRAY"
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
  - "PROGRAM_NODE_ARRAY"
helpviewer_keywords: 
  - "PROGRAM_NODE_ARRAY structure"
ms.assetid: 8eeea600-eda5-4b7c-868a-0b86d177b0a5
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PROGRAM_NODE_ARRAY
Contains an array of objects that describe programs of interest.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 dwCount  
 Number of objects in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array.  
  
 Members  
 An array of [IDebugProgramNode2](../vs140/idebugprogramnode2.md) objects describing the programs requested.  
  
## Remarks  
 This structure is part of the [PROVIDER_PROCESS_DATA](../vs140/provider_process_data.md) structure which in turn is filled in by a call to the [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [PROVIDER_PROCESS_DATA](../vs140/provider_process_data.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md)