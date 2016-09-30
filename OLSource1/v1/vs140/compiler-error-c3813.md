---
title: "Compiler Error C3813"
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
  - "C3813"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3813"
ms.assetid: ffdbc489-71bf-4cd6-988c-f824c9ab3ceb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3813
a property declaration can only appear within the definition of a managed or WinRTtype  
  
 A [property](../vs140/__property.md) can only be declared within a managed or Windows Runtime type. Native types do not support the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword.  
  
 The following sample generates C3813 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>