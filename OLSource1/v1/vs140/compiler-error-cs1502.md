---
title: "Compiler Error CS1502"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1502"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1502"
ms.assetid: f302f00a-5fe1-4e42-b91c-f185d6311671
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1502
The best overloaded method match for 'name' has some invalid arguments  
  
 This error occurs when the argument types being passed to the method do not match the parameter types of that method. If the called method is overloaded, then none of the overloaded versions has a signature that matches the argument types being passed.  
  
 To resolve this problem, do one of the following:  
  
-   Double-check the types of the arguments being passed. Make sure that they match the arguments of the method being called.  
  
-   If appropriate, convert any mismatched parameters using the \<xref:System.Convert*> class.  
  
-   If appropriate, cast any mismatched parameters to match the type that the method is expecting.  
  
-   If appropriate, define another overloaded version of the method to match the parameter types that are being sent.  
  
 The following sample generates CS1502:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>