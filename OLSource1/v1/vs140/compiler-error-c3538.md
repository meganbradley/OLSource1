---
title: "Compiler Error C3538"
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
  - "C3538"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3538"
ms.assetid: ef3698a5-7356-4c62-b9af-5d3a4baed958
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3538
in a declarator-list 'auto' must always deduce to the same type  
  
 All the declared variables in a declaration list do not resolve to the same type.  
  
### To correct this error  
  
1.  Ensure that all <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> declarations in the list deduce to the same type.  
  
## Example  
 The following statements yield C3538. Each statement declares multiple variables, but each use of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword does not deduce to the same type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)