---
title: "Compiler Error C3849"
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
  - "C3849"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3849"
ms.assetid: 5347140e-1a81-4841-98c0-b63d98264b64
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3849
function-style call on an expression of type 'type' would lose const and/or volatile qualifiers for all number available operator overloads  
  
 A variable with a specified const-volatile type can only call member functions defined with same or greater const-volatile qualifications.  
  
 To fix this error, provide an appropriate member function. You cannot execute a conversion on a const or volatile qualified object when the conversion causes loss of qualification. You can gain qualifiers but you cannot lose qualifiers in a conversion.  
  
 The following samples generate C3849:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>