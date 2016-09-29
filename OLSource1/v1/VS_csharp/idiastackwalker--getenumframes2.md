---
title: "IDiaStackWalker::getEnumFrames2"
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
  - "IDiaStackWalker2::getEnumFrames2 method"
ms.assetid: 73196d3f-112c-4b3a-997b-7c6b815d4afc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalker::getEnumFrames2
Retrieves a stack frame enumerator for a specific platform type.  
  
## Syntax  
  
```cpp#  
  
      HRESULT getEnumFrames2(   
   enum  CV_CPU_TYPE_e    cpuid,  
   IDiaStackWalkHelper*   pHelper,  
   IDiaEnumStackFrames**  ppEnum  
);  
```  
  
#### Parameters  
 `cpuid`  
 [in] A value from the [CV_CPU_TYPE_e Enumeration](../VS_csharp/cv_cpu_type_e.md) enumeration, specifying the platform type.  
  
 `pHelper`  
 [in] The helper [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../VS_csharp/idiaenumstackframes.md) object containing a list of [IDiaStackFrame](../VS_csharp/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To obtain a stack frame list for just the x86 platform, call the [IDiaStackWalker::getEnumFrames](../VS_csharp/idiastackwalker--getenumframes.md) method.  
  
## See Also  
 [IDiaStackWalker](../VS_csharp/idiastackwalker.md)   
 [CV_CPU_TYPE_e Enumeration](../VS_csharp/cv_cpu_type_e.md)   
 [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md)   
 [IDiaStackFrame](../VS_csharp/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames](../VS_csharp/idiastackwalker--getenumframes.md)