---
title: "Compiler Error C2955"
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
  - "C2955"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2955"
ms.assetid: 77709fb6-d69b-46fd-a62f-e8564563d01b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2955
'identifier' : use of class template or alias generic requires template or generic argument list  
  
 You cannot use a class template or class generic as an identifier without a template or generic argument list.  
  
 For more information, see [Class Templates](../vs140/class-templates.md).  
  
 The following sample generates C2955 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2955 can also occur when attempting an out-of-line definition for a function declared in a class template:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2955 can also occur when using generics:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>