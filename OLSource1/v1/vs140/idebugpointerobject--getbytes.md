---
title: "IDebugPointerObject::GetBytes"
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
  - "IDebugPointerObject::GetBytes"
helpviewer_keywords: 
  - "IDebugPointerObject::GetBytes method"
ms.assetid: e986c188-87fb-4b51-86e9-ee6a0035bdab
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPointerObject::GetBytes
Gets the value pointed to as a series of consecutive bytes.  
  
## Syntax  
  
```cpp#  
HRESULT GetBytes(   
   DWORD  dwStart,  
   DWORD  dwCount,  
   BYTE*  pBytes,  
   DWORD* pdwBytes  
);  
```  
  
```c#  
int GetBytes(  
   uint       dwStart,   
   uint       dwCount,   
   out byte[] pBytes,   
   out uint   pdwBytes  
);  
```  
  
#### Parameters  
 `dwStart`  
 [in] An offset, in bytes, from the start of the object pointed to.  
  
 `dwCount`  
 [in] The number of bytes to retrieve.  
  
 `pBytes`  
 [in, out] An array that is filled in with the value as a series of consecutive bytes, starting at the given offset from the object pointed to.  
  
 `pdwBytes`  
 [out] Returns the number of bytes actually retrieved.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method is used if the pointer as represented by this [IDebugPointerObject](../vs140/idebugpointerobject.md) points to a primitive type or a simple array of primitive types (that is, an array that can be represented by a simple sequence of bytes).  
  
## See Also  
 [IDebugPointerObject](../vs140/idebugpointerobject.md)   
 [SetBytes](../vs140/idebugpointerobject--setbytes.md)