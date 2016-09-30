---
title: "Compiler Error C3633"
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
  - "C3633"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3633"
ms.assetid: 7d65babf-2191-4d67-a69f-f5c4c2ddf946
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3633
cannot define 'member' as a member of managed 'type'  
  
 CLR reference class data members cannot be of a non-POD C++ type.  You can only instantiate a POD native type in a CLR type.  For example, a POD type cannot contain a copy constructor or an assignment operator.  
  
## Example  
 The following sample generates C3633.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3633.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>