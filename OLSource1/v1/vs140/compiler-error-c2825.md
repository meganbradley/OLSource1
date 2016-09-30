---
title: "Compiler Error C2825"
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
  - "C2825"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2825"
ms.assetid: c832f1c1-5184-4fc2-9356-12b21daa7af3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2825
var : must be a class or namespace when followed by '::'  
  
 An unsuccessful attempt was made to form a qualified name.  
  
 For example, make sure that your code does not contain a function declaration where the function name begins with ::.  
  
## Example  
 The following sample generates C2825:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>