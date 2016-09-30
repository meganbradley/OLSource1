---
title: "Compiler Error C3824"
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
  - "C3824"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3824"
ms.assetid: b6c6adf1-0a29-401c-a06e-616fd50d4c37
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3824
'member': this type cannot appear in this context (function parameter, return type, or a static member)  
  
 Pinning pointers cannot be function parameters, return types, or declared <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 The following sample generates C3824:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Managed Extensions for C++**  
  
 Local pointers declared with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword cannot be declared <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and cannot be interior pointers.  
  
 The following sample generates C3824:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>