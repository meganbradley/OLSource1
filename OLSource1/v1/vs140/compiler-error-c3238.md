---
title: "Compiler Error C3238"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3238"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3238"
ms.assetid: 19942497-b3c5-4df0-9144-142ced92468b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3238
'type' : a type with this name has already been forwarded to assembly 'assembly'  
  
 A type was defined in a client application that is also defined, via type forwarding syntax, in a referenced assembly. Both types cannot be defined in the scope of the application.  
  
 See [Type Forwarding](../vs140/type-forwarding--c---cli-.md) for more information.  
  
## Example  
 The following sample creates an assembly that contains a type that was forwarded from another assembly.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample creates an assembly that used to contain the type definition, but not only contains type forwarding syntax.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3238.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>