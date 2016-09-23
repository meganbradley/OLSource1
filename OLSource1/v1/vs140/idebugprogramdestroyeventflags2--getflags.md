---
title: "IDebugProgramDestroyEventFlags2::GetFlags"
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
  - GetFlags
  - IDebugProgramDestroyEventFlags2::GetFlags
ms.assetid: dd53bd0c-459a-4077-ba81-780defb71e87
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProgramDestroyEventFlags2::GetFlags
Retrieves the program destroy flags.  
  
## Syntax  
  
```cpp#  
HRESULT GetFlags(  
   PROGRAM_DESTROY_FLAGS* pdwFlags  
);  
```  
  
```c#  
public int GetFlags(  
   out enum_PROGRAM_DESTROY_FLAGS pdwFlags  
);  
```  
  
#### Parameters  
 `pdwFlags`  
 [out] Represents the program destroy flags.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramDestroyEventFlags2](../vs140/idebugprogramdestroyeventflags2.md)   
 [PROGRAM_DESTROY_FLAGS](../vs140/program_destroy_flags.md)