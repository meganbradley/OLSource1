---
title: "Compiler Error C2381"
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
  - "C2381"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2381"
ms.assetid: cc765f67-64ac-406f-93ef-ae7d548d58d7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2381
'function' : redefinition; __declspec(noreturn) differs  
  
 A function was declared and then defined but the definition used the [noreturn](../vs140/noreturn.md) <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier. The use of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> constitutes a redefinition of the function; the declaration and definition need to agree on the use of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following sample generates C2381:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>