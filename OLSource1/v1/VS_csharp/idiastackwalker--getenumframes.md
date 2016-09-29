---
title: "IDiaStackWalker::getEnumFrames"
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
  - "IDiaStackWalker2::getEnumFrames method"
ms.assetid: f9f09729-4c34-441c-989c-e0b7339ee32c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalker::getEnumFrames
Retrieves a stack frame enumerator for x86 platforms.  
  
## Syntax  
  
```cpp#  
HRESULT getEnumFrames(   
   IDiaStackWalkHelper*   pHelper,  
   IDiaEnumStackFrames**  ppEnum  
);  
```  
  
#### Parameters  
 `pHelper`  
 [in] The helper [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../VS_csharp/idiaenumstackframes.md) object that contains a list of [IDiaStackFrame](../VS_csharp/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To get a stack frame list on any other platform, call the [IDiaStackWalker::getEnumFrames2](../VS_csharp/idiastackwalker--getenumframes2.md) method.  
  
## See Also  
 [IDiaStackWalker](../VS_csharp/idiastackwalker.md)   
 [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md)   
 [IDiaStackFrame](../VS_csharp/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames2](../VS_csharp/idiastackwalker--getenumframes2.md)