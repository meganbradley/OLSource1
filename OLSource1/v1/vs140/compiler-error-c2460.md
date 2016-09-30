---
title: "Compiler Error C2460"
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
  - "C2460"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2460"
ms.assetid: d969fca9-3ac5-4e4e-88fc-df05510e2093
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2460
'identifier1' : uses 'identifier2', which is being defined  
  
 A class or structure (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) is declared as a member of itself (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). Recursive definitions of classes and structures are not allowed.  
  
 The following sample generates C2460:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Instead, use a pointer reference in the class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>