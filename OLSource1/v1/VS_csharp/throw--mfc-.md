---
title: "THROW (MFC)"
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
  - "AFX/THROW"
  - "THROW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "THROW macro"
ms.assetid: 794b8de1-bf90-4877-b96a-bc7b17b1e460
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# THROW (MFC)
Throws the specified exception.  
  
## Syntax  
  
```  
  
THROW(  
exception_object_pointer )  
```  
  
#### Parameters  
 *exception_object_pointer*  
 Points to an exception object derived from `CException`.  
  
## Remarks  
 **THROW** interrupts program execution, passing control to the associated **CATCH** block in your program. If you have not provided the **CATCH** block, then control is passed to a Microsoft Foundation Class Library module that prints an error message and exits.  
  
 For more information, see the article [Exceptions](../VS_csharp/exception-handling-in-mfc.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [THROW_LAST](../VS_csharp/throw_last.md)   
 [TRY](../VS_csharp/try.md)   
 [CATCH](../VS_csharp/catch.md)   
 [AND_CATCH](../VS_csharp/and_catch.md)   
 [END_CATCH](../VS_csharp/end_catch.md)   
 [CATCH_ALL](../VS_csharp/catch_all.md)   
 [AND_CATCH_ALL](../VS_csharp/and_catch_all.md)   
 [END_CATCH_ALL](../VS_csharp/end_catch_all.md)   
 [AfxThrowArchiveException](../VS_csharp/afxthrowarchiveexception.md)   
 [AfxThrowFileException](../VS_csharp/afxthrowfileexception.md)   
 [AfxThrowMemoryException](../VS_csharp/afxthrowmemoryexception.md)   
 [AfxThrowNotSupportedException](../VS_csharp/afxthrownotsupportedexception.md)   
 [AfxThrowResourceException](../VS_csharp/afxthrowresourceexception.md)   
 [AfxThrowUserException](../VS_csharp/afxthrowuserexception.md)