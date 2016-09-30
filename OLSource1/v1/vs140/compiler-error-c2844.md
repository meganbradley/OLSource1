---
title: "Compiler Error C2844"
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
  - "C2844"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2844"
ms.assetid: dcaf4cd2-21b0-4280-ae42-0a706c524d83
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2844
'member' : cannot be a member of interface 'interface'  
  
 An [interface class](../vs140/interface-class---c---component-extensions-.md) cannot contain a data member unless it is also a property.  
  
 Anything other than a property or member function is not allowed in an interface. Furthermore, constructors, destructors, and operators are not allowed.  
  
 The following sample generates C2844:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C2844:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>