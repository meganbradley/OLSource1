---
title: "DEBUG_NEW"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DEBUG_NEW"
  - "AFX/DEBUG_NEW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DEBUG_NEW macro"
ms.assetid: 9b379344-4093-4bec-a3eb-e0d8a63ada9d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DEBUG_NEW
Assists in finding memory leaks.  
  
## Syntax  
  
```  
  
#define new DEBUG_NEW   
```  
  
## Remarks  
 You can use `DEBUG_NEW` everywhere in your program that you would ordinarily use the **new** operator to allocate heap storage.  
  
 In debug mode (when the **_DEBUG** symbol is defined), `DEBUG_NEW` keeps track of the filename and line number for each object that it allocates. Then, when you use the [CMemoryState::DumpAllObjectsSince](../Topic/CMemoryState::DumpAllObjectsSince.md) member function, each object allocated with `DEBUG_NEW` is shown with the filename and line number where it was allocated.  
  
 To use `DEBUG_NEW`, insert the following directive into your source files:  
  
 [!code[NVC_MFCCObjectSample#14](../VS_csharp/codesnippet/CPP/debug_new_1.cpp)]  
  
 Once you insert this directive, the preprocessor will insert `DEBUG_NEW` wherever you use **new**, and MFC does the rest. When you compile a release version of your program, `DEBUG_NEW` resolves to a simple **new** operation, and the filename and line number information are not generated.  
  
> [!NOTE]
>  In previous versions of MFC (4.1 and earlier) you needed to put the `#define` statement after all statements that called the `IMPLEMENT_DYNCREATE` or `IMPLEMENT_SERIAL` macros. This is no longer necessary.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [MFC Debugging Techniques](../VS_csharp/mfc-debugging-techniques.md)