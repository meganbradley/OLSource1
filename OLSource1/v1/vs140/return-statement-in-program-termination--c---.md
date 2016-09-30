---
title: "return Statement in Program Termination (C++)"
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
  - "data types [C++], function return types"
  - "function return types, return statement"
  - "return keyword [C++], syntax"
ms.assetid: 66d002ab-5625-4b68-8446-71e1b8fcdbd8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# return Statement in Program Termination (C++)
Issuing a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement from **main** is functionally equivalent to calling the **exit** function. Consider the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The **exit** and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements in the preceding example are functionally identical. However, C++ requires that functions that have return types other than <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> return a value. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement allows you to return a value from **main**.  
  
## See Also  
 [Program Termination](../vs140/program-termination.md)