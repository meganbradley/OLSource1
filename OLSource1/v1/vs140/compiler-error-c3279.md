---
title: "Compiler Error C3279"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3279"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3279"
ms.assetid: 639afc20-984c-4a95-be35-8bf9409f02d5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3279
partial and explicit specializations as well as explicit instantiations of class templates declared in the cli namespace are disallowed  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> namespace is defined by Microsoft and contains pseudo-templates. The Visual C++ compiler does not allow user-defined, partial and explicit specializations, and explicit instantiations of class templates in this namespace.  
  
 The following sample generates C3279:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>