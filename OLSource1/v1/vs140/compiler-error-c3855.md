---
title: "Compiler Error C3855"
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
  - "C3855"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3855"
ms.assetid: ed90f8c0-4154-4243-b066-493913df5727
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3855
'class': type parameter 'param' is incompatible with the declaration  
  
 The compiler found nontype template or generic parameters with different names. This can occur when a specified template parameter in the definition of a template specialization is incompatible with its declaration.  
  
 The following sample generates C3855:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C3855 can also occur when using generics:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>