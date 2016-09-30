---
title: "Compiler Error C3531"
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
  - "C3531"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3531"
ms.assetid: 2bdb9fdc-9ddf-403e-8b92-02763d434487
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3531
'symbol': a symbol whose type contains 'auto' must have an initializer  
  
 The specified variable does not have an initializer expression.  
  
### To correct this error  
  
1.  Specify an initializer expression, such as a simple assignment that uses equal-sign syntax, when you declare the variable.  
  
## Example  
 The following example yields C3531 because variables <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are not initialized.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)