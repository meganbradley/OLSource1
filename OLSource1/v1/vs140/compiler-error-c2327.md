---
title: "Compiler Error C2327"
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
  - "C2327"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2327"
ms.assetid: 95278c95-d1f9-4487-ad27-53311f5e8112
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2327
'symbol' : is not a type name, static, or enumerator  
  
 Code within a nested class attempts to access a member of the enclosing class that is not a type name, a static member, or an enumerator.  
  
 When compiling with **/clr**, a common cause for C2327 is a property with the same name as the property type.  
  
 The following sample generates C2327:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2327 can also occur if the name of a type is hidden by the name of a member:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2327 can also fire in this situation, where you need to fully specify the data type of the parameter:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following sample generates C2327:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 C2327 can also occur when using Managed Extensions for C++:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following sample shows C2327 when a property has the same name as the property type:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following sample shows C2327 when a property has the same name as the property type:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>