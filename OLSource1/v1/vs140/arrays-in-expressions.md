---
title: "Arrays in Expressions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "expressions [C++], arrays in"
  - "arrays [C++], in expressions"
ms.assetid: 6e5a795b-d6bd-4e39-b313-6a20d47c4d4b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arrays in Expressions
When an identifier of an array type appears in an expression other than <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, address-of (**&**), or initialization of a reference, it is converted to a pointer to the first array element. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The pointer <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> points to the first element of the array <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Note that arrays, unlike pointers, are not modifiable l-values. Therefore, the following assignment is illegal:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Arrays](../vs140/arrays--c---.md)