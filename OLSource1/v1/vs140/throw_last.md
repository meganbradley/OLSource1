---
title: "THROW_LAST"
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
  - "AFX/THROW_LAST"
  - "THROW_LAST"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "THROW_LAST macro"
ms.assetid: a4ca8efc-239d-4da3-add9-c29c82bff338
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# THROW_LAST
Throws the exception back to the next outer **CATCH** block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This macro allows you to throw a locally created exception. If you try to throw an exception that you have just caught, it will normally go out of scope and be deleted. With <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the exception is passed correctly to the next **CATCH** handler.  
  
 For more information, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## Example  
 See the example for [CFile::Abort](../vs140/cfile--abort.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [THROW](../vs140/throw--mfc-.md)   
 [TRY](../vs140/try.md)   
 [CATCH](../vs140/catch.md)   
 [AND_CATCH](../vs140/and_catch.md)   
 [END_CATCH](../vs140/end_catch.md)   
 [CATCH_ALL](../vs140/catch_all.md)   
 [AND_CATCH_ALL](../vs140/and_catch_all.md)   
 [END_CATCH_ALL](../vs140/end_catch_all.md)