---
title: "Compiler Error C3203"
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
  - "C3203"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3203"
ms.assetid: 6356770e-22c1-434c-91fe-f60b0aa23b91
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3203
'type' : unspecialized class template or generic can't be used as a template or generic argument for template or generic parameter 'param', expected a real type  
  
 You passed an invalid argument to a class template or generic. The class template or generic expects a type as a parameter.  
  
 This error can be generated as a result of compiler conformance work that was done for Visual C++ 2005: an unspecialized class template can't be used as a template argument in a base class list. To resolve C3203, explicitly add the template type parameter(s) to the template class name when using it as a template parameter in a base class list.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3203 and shows how to fix it:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C3203 can also occur when using generics:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>