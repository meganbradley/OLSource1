---
title: "Compiler Error C3699"
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
  - "C3699"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3699"
ms.assetid: 47c29afc-ab8b-4238-adfe-788dd6e00b3b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3699
'operator' : cannot use this indirection on type 'type'  
  
 An attempt was made to use indirection that is not allowed on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates C3699.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 A trivial property cannot have reference type. See [property](../vs140/property---c---component-extensions-.md) for more information. The following sample generates C3699.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The equivalent of a "pointer to a pointer" syntax is a handle to a tracking reference. The following sample generates C3699.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>