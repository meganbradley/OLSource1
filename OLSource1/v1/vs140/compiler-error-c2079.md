---
title: "Compiler Error C2079"
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
  - "C2079"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2079"
ms.assetid: ca58d6d5-eccd-40b7-ba14-c003223c5bc7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2079
'identifier' uses undefined class/struct/union 'name'  
  
 The specified identifier is an undefined class, structure, or union.  
  
 This error can be caused by initializing an anonymous union.  
  
 The following sample generates C2079:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2079 can also occur if you attempt to declare an object on the stack of a type whose forward declaration is only in scope.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>