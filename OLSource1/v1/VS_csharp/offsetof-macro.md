---
title: "offsetof Macro"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "offsetof"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "structure members, offset"
  - "offsetof macro"
ms.assetid: f3b4eb16-a882-4d38-afc9-eebd976a7352
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# offsetof Macro
Retrieves the offset of a member from the beginning of its parent structure.  
  
## Syntax  
  
```  
  
      size_t offsetof(  
   structName,  
   memberName   
);  
```  
  
#### Parameters  
 *structName*  
 Name of the parent data structure.  
  
 `memberName`  
 Name of the member in the parent data structure for which to determine the offset.  
  
## Return Value  
 `offsetof` returns the offset in bytes of the specified member from the beginning of its parent data structure. It is undefined for bit fields.  
  
## Remarks  
 The `offsetof` macro returns the offset in bytes of `memberName` from the beginning of the structure specified by *structName* as a value of type `size_t`. You can specify types with the `struct` keyword.  
  
> [!NOTE]
>  `offsetof` is not a function and cannot be described using a C prototype.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`offsetof`|<stddef.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../VS_csharp/crt-library-features.md).  
  
## See Also  
 [Memory Allocation](../VS_csharp/memory-allocation.md)