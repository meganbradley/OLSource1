---
title: "IDiaStackWalkHelper::readMemory"
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
  - "IDiaStackWalkHelper2::readMemory method"
ms.assetid: e1eb90aa-49b7-476c-9e70-7e8f08994cbe
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::readMemory
Reads a block of data from the executable's image in memory.  
  
## Syntax  
  
```cpp#  
HRESULT readMemory(   
   enum MemoryTypeEnum type,  
   ULONGLONG           va,  
   DWORD               cbData,  
   DWORD*              pcbData,  
   BYTE*               pbData  
);  
```  
  
#### Parameters  
 `type`  
 [in] A value from the [MemoryTypeEnum](../VS_csharp/memorytypeenum.md) enumeration specifying the type of memory to read.  
  
 va  
 [in] Virtual address in the image from which to begin reading.  
  
 `cbData`  
 [in] The size of the data buffer in bytes.  
  
 `pcbData`  
 [out] Returns the number of bytes actually read. If `pbData` is `NULL`, then this is the total number of bytes of data available.  
  
 `pbData`  
 [in, out] A buffer that is filled in with the memory read.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md)   
 [MemoryTypeEnum](../VS_csharp/memorytypeenum.md)