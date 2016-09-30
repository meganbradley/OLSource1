---
title: "Compiler Error C2483"
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
  - "C2483"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2483"
ms.assetid: 5762b325-914b-442d-a604-e4617ba04038
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2483
'identifier' : object with constructor or destructor cannot be declared 'thread'  
  
 Variables declared with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attribute cannot be initialized with a constructor or other expression that requires run-time evaluation. A static expression is required to initialize <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data.  
  
## Example  
 The following sample generates C2483.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [thread](../vs140/thread.md)