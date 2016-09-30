---
title: "Compiler Error C2707"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2707"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2707"
ms.assetid: 3deaf45c-74da-4c9d-acc6-b82412720b74
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2707
'identifier' : bad context for intrinsic function  
  
 Structured exception-handling intrinsics are invalid in certain contexts:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> outside an exception filter or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> outside an exception filter  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> outside a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block  
  
 To resolve the error, be sure that the exception-handling intrinsics are placed in the appropriate context.  
  
## Example  
 The following sample generates C2707.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>