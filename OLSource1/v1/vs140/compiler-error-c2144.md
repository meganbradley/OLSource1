---
title: "Compiler Error C2144"
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
  - "C2144"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2144"
ms.assetid: 49f3959b-324f-4c06-9588-c0ecef5dc5b3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2144
syntax error : 'type' should be preceded by 'token'  
  
 The compiler expected <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and found <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> instead.  
  
 This error may be caused by a missing closing brace, right parenthesis, or semicolon.  
  
 C2144 can also occur when attempting to create a macro from a CLR keyword that contains a white space character.  
  
 You may also see C2144 if you are trying to do type forwarding. See [Type Forwarders](../vs140/type-forwarding--c---cli-.md) for more information.  
  
## Example  
 The following sample generates C2144.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C2144.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>