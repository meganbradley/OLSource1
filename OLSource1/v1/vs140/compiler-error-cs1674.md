---
title: "Compiler Error CS1674"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1674"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1674"
ms.assetid: 7a018629-35f4-406a-8a5f-1cee7343da6d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1674
'T': type used in a using statement must be implicitly convertible to 'System.IDisposable'  
  
 The [using Statement](../vs140/using-statement--csharp-reference-.md) is intended to be used to ensure the disposal of an object at the end of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block, thus, only types which are disposable may be used in such a statement. For example, value types are not disposable, and type parameters which are not constrained to be classes may not be assumed to be disposable.  
  
## Example  
 The following sample generates CS1674.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS1674.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following case illustrates the need for a class type constraint to guarantee that an unknown type parameter is disposable. The following sample generates CS1674.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>