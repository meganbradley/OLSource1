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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *exception_object_pointer*  
 Points to an exception object derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 **THROW** interrupts program execution, passing control to the associated **CATCH** block in your program. If you have not provided the **CATCH** block, then control is passed to a Microsoft Foundation Class Library module that prints an error message and exits.  
  
 For more information, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [THROW_LAST](../vs140/throw_last.md)   
 [TRY](../vs140/try.md)   
 [CATCH](../vs140/catch.md)   
 [AND_CATCH](../vs140/and_catch.md)   
 [END_CATCH](../vs140/end_catch.md)   
 [CATCH_ALL](../vs140/catch_all.md)   
 [AND_CATCH_ALL](../vs140/and_catch_all.md)   
 [END_CATCH_ALL](../vs140/end_catch_all.md)   
 [AfxThrowArchiveException](../vs140/afxthrowarchiveexception.md)   
 [AfxThrowFileException](../vs140/afxthrowfileexception.md)   
 [AfxThrowMemoryException](../vs140/afxthrowmemoryexception.md)   
 [AfxThrowNotSupportedException](../vs140/afxthrownotsupportedexception.md)   
 [AfxThrowResourceException](../vs140/afxthrowresourceexception.md)   
 [AfxThrowUserException](../vs140/afxthrowuserexception.md)