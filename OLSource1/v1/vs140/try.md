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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A **TRY** block identifies a block of code that might throw exceptions. Those exceptions are handled in the following **CATCH** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> blocks. Recursion is allowed: exceptions may be passed to an outer **TRY** block, either by ignoring them or by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro. End the **TRY** block with an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro.  
  
 For more information, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## Example  
 See the example for [CATCH](../vs140/catch.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CATCH](../vs140/catch.md)   
 [AND_CATCH](../vs140/and_catch.md)   
 [END_CATCH](../vs140/end_catch.md)   
 [CATCH_ALL](../vs140/catch_all.md)   
 [AND_CATCH_ALL](../vs140/and_catch_all.md)   
 [END_CATCH_ALL](../vs140/end_catch_all.md)   
 [THROW](../vs140/throw--mfc-.md)   
 [THROW_LAST](../vs140/throw_last.md)