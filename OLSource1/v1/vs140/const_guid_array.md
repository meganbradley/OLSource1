---
title: "CONST_GUID_ARRAY"
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
  - "CONST_GUID_ARRAY"
helpviewer_keywords: 
  - "CONST_GUID_ARRAY structure"
ms.assetid: bd55e7d8-372c-4c3e-9eed-28f6b415a5db
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CONST_GUID_ARRAY
A structure that holds a list of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 dwCount  
 Number of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>s in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array.  
  
 Members  
 Array of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>s.  
  
## Remarks  
 This structure is passed to the [IDebugProgramPublisher2::PublishProgram](../vs140/idebugprogrampublisher2--publishprogram.md) method, and is returned from the [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md) and [IDebugProgramProvider2::WatchForProviderEvents](../vs140/idebugprogramprovider2--watchforproviderevents.md) methods.  
  
 The owner of an instance of this structure is responsible for freeing any memory allocated.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugProgramPublisher2::PublishProgram](../vs140/idebugprogrampublisher2--publishprogram.md)   
 [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md)   
 [IDebugProgramProvider2::WatchForProviderEvents](../vs140/idebugprogramprovider2--watchforproviderevents.md)