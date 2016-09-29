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
A structure that holds a list of `GUID`s.  
  
## Syntax  
  
```cpp#  
typedef struct tagCONST_GUID_ARRAY {  
   DWORD       dwCount;  
   CONST GUID* Members;  
} CONST_GUID_ARRAY;  
```  
  
```c#  
public struct CONST_GUID_ARRAY {  
   public uint   dwCount;  
   public Guid[] Members;  
}  
```  
  
## Members  
 dwCount  
 Number of `GUID`s in the `Members` array.  
  
 Members  
 Array of `GUID`s.  
  
## Remarks  
 This structure is passed to the [IDebugProgramPublisher2::PublishProgram](../VS_csharp/idebugprogrampublisher2--publishprogram.md) method, and is returned from the [IDebugProgramProvider2::GetProviderProcessData](../VS_csharp/idebugprogramprovider2--getproviderprocessdata.md) and [IDebugProgramProvider2::WatchForProviderEvents](../VS_csharp/idebugprogramprovider2--watchforproviderevents.md) methods.  
  
 The owner of an instance of this structure is responsible for freeing any memory allocated.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../VS_csharp/structures-and-unions.md)   
 [IDebugProgramPublisher2::PublishProgram](../VS_csharp/idebugprogrampublisher2--publishprogram.md)   
 [IDebugProgramProvider2::GetProviderProcessData](../VS_csharp/idebugprogramprovider2--getproviderprocessdata.md)   
 [IDebugProgramProvider2::WatchForProviderEvents](../VS_csharp/idebugprogramprovider2--watchforproviderevents.md)