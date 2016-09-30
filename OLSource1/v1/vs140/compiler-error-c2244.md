---
title: "Compiler Error C2244"
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
  - "C2244"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2244"
ms.assetid: d9911c12-ceb5-4f93-ac47-b44a485215c2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2244
'identifier' : unable to match function definition to an existing declaration  
  
 An unusual use of the unary + operator was used in front of a function call that did not have parenthesis.  
  
 This error only occurs in C++ projects.  
  
 The following sample generates C2244:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2244 can also occur when an incorrect function signature is used for a member function of a class template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2244 can also occur when an incorrect function signature is used for a member function template.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You cannot partially specialize a function template.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>