---
title: "__super"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__super_cpp"
  - "__super"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__super keyword [C++]"
ms.assetid: f0957c31-9256-405b-b402-cad182404b5f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __super
**Microsoft Specific**  
  
 Allows you to explicitly state that you are calling a base-class implementation for a function that you are overriding.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 All accessible base-class methods are considered during the overload resolution phase, and the function that provides the best match is the one that is called.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can only appear within the body of a member function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used with a using declaration. See [using Declaration](../vs140/using-declaration.md) for more information.  
  
 With the introduction of [attributes](../vs140/c---attributes-reference.md) that inject code, your code might contain one or more base classes whose names you may not know but that contain methods that you wish to call.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)