---
title: "Compiler Error C3815"
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
  - "C3815"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3815"
ms.assetid: c5a3b404-6341-4fd3-92af-152b404c4dde
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3815
return type of method 'get_accessor' must match type of the last parameter of a setter  
  
 When declaring [properties](../vs140/__property.md), the return value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method must match the last parameter in the declaration of the set accessor method.  
  
 C3815 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3815:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample shows how you can overload properties, so that the return type of the getter does not match the last parameter of the setter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>