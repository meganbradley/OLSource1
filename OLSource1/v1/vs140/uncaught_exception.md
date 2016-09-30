---
title: "uncaught_exception"
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
  - "uncaught_exception"
  - "std::uncaught_exception"
  - "std.uncaught_exception"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uncaught_exception function"
ms.assetid: 9d4973d2-134e-49c6-aa2c-a9535e6832ae
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uncaught_exception
Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only if a thrown exception is being currently processed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> after completing evaluation of a throw expression and before completing initialization of the exception declaration in the matching handler or calling [unexpected](../vs140/unexpected---exception--.md) as a result of the throw expression. In particular, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when called from a destructor that is being invoked during an exception unwind. On devices, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is only supported on Windows CE 5.00 and higher versions, including Windows Mobile 2005 platforms.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **In Test::Test("outside try block")**  
**In Test::Test("inside try block")**  
**In Test::~Test("inside try block")**  
 **std::uncaught_exception( ) = 1**  
**In Test::~Test("outside try block")**  
 **std::uncaught_exception( ) = 0**   
## Requirements  
 **Header:** \<exception>  
  
 **Namespace:** std