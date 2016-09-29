---
title: "TRY"
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
  - "AFX/TRY"
  - "TRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try blocks"
ms.assetid: a50dde15-8e3f-4747-a07f-ed09d342577c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TRY
Sets up a **TRY** block.  
  
## Syntax  
  
```  
  
TRY  
  
```  
  
## Remarks  
 A **TRY** block identifies a block of code that might throw exceptions. Those exceptions are handled in the following **CATCH** and `AND_CATCH` blocks. Recursion is allowed: exceptions may be passed to an outer **TRY** block, either by ignoring them or by using the `THROW_LAST` macro. End the **TRY** block with an `END_CATCH` or `END_CATCH_ALL` macro.  
  
 For more information, see the article [Exceptions](../VS_csharp/exception-handling-in-mfc.md).  
  
## Example  
 See the example for [CATCH](../VS_csharp/catch.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CATCH](../VS_csharp/catch.md)   
 [AND_CATCH](../VS_csharp/and_catch.md)   
 [END_CATCH](../VS_csharp/end_catch.md)   
 [CATCH_ALL](../VS_csharp/catch_all.md)   
 [AND_CATCH_ALL](../VS_csharp/and_catch_all.md)   
 [END_CATCH_ALL](../VS_csharp/end_catch_all.md)   
 [THROW](../VS_csharp/throw--mfc-.md)   
 [THROW_LAST](../VS_csharp/throw_last.md)