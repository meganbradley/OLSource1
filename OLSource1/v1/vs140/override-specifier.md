---
title: "override Specifier"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "override Identifier"
ms.assetid: b286fb46-9374-4ad8-b2e7-4607119b6133
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# override Specifier
You can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword to designate member functions that override a virtual function in a base class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is context-sensitive and has special meaning only when it's used after a member function declaration; otherwise, it's not a reserved keyword.  
  
## Example  
 Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to help prevent inadvertent inheritance behavior in your code. The following example shows where, without using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the member function behavior of the derived class may not have been intended. The compiler doesn't emit any errors for this code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the compiler generates errors instead of silently creating new member functions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To specify that functions cannot be overridden and that classes cannot be inherited, use the [final](../vs140/final-specifier.md) keyword.  
  
## See Also  
 [final Specifier](../vs140/final-specifier.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [(NOTINBUILD) C++ Type Names](assetId:///b53ba470-e583-4e5c-b634-6018f6110674)