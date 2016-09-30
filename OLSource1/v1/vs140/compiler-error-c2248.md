---
title: "Compiler Error C2248"
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
  - "C2248"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2248"
ms.assetid: 7a3ba0e8-d3b9-4bb9-95db-81ef17e31d23
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2248
'member' : cannot access 'access' member declared in class 'class'  
  
 Members of a derived class cannot access <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> members of a base class. You cannot access <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> members of class instances.  
  
 See Knowledge Base article KB243351 for more information on C2248.  
  
 The following sample generates C2248:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Another conformance issue that exposes C2248 is the use of template friends and specialization. For more information, see [Linker Tools Error LNK2019](../vs140/linker-tools-error-lnk2019.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Another conformance issue that exposes C2248 is when you attempt to declare a friend of a class and when the class is not visible to the friend declaration in the scope of the class. In this case, grant friendship to the enclosing class to resolve the error.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>