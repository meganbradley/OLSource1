---
title: "GUID_ARRAY"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - GUID_ARRAY structure
ms.assetid: 9e12500c-2c1c-49b1-a0ba-e08366c97eb8
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# GUID_ARRAY
Describes an array of unique identifiers for available debug engines.  
  
## Syntax  
  
```cpp#  
typedef struct tagGUID_ARRAY  
{  
   DWORD dwCount;  
   GUID *Members;  
} GUID_ARRAY;  
```  
  
```c#  
public struct GUID_ARRAY  
{  
   public uint dwCount;  
   public Guid Members;  
}  
```  
  
## Terms  
 dwCount  
 Number of unique identifiers in the array.  
  
 Members  
 Array that contains unique identifiers.  
  
## Remarks  
 This structure is returned by the [IDebugProcess3::GetEngineFilter](../vs140/idebugprocess3--getenginefilter.md) method.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugProcess3::GetEngineFilter](../vs140/idebugprocess3--getenginefilter.md)