---
title: "#error Directive (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "#error Directive (C/C++)"
f1_keywords: 
  - "#error"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "#error directive"
  - "preprocessor, directives"
  - "error directive (#error directive)"
ms.assetid: d550a802-ff19-4347-9597-688935d23b2b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #error Directive (C-C++)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive emits a user-specified error message at compile time and then terminates the compilation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The error message that this directive emits includes the *token-string* parameter. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is not subject to macro expansion. This directive is most useful during preprocessing for notifying the developer of a program inconsistency or the violation of a constraint. The following example demonstrates error processing during preprocessing:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Preprocessor Directives](../vs140/preprocessor-directives.md)