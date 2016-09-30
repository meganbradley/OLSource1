---
title: "Compiler Error C2217"
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
  - "C2217"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2217"
ms.assetid: 1ce1e3f5-4171-4376-804d-967f7e612935
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2217
'attribute1' requires 'attribute2'  
  
 The first function attribute requires the second attribute.  
  
### To fix by checking the following possible causes  
  
1.  Interrupt (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) function declared as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Interrupt functions must be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
2.  Interrupt function declared with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Interrupt functions must use C calling conventions.  
  
## Example  
 C2217 can also occur if you attempt to bind a delegate to a CLR function that takes a variable number of arguments. If the function also has e param array overload, use that instead. The following sample generates C2217.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>