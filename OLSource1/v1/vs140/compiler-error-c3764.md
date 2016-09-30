---
title: "Compiler Error C3764"
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
  - "C3764"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3764"
ms.assetid: af5d254c-8d4a-4dda-aad9-3c5c1257c868
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3764
'override_function': cannot override base class method 'base_class_function'  
  
 The compiler detected an ill-formed override. For example, the base class function was not <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [override](../vs140/override---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3764.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C3764 can also occur when a base class method is both explicitly and named overridden. The following sample generates C3764.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>