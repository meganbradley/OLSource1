---
title: "Compiler Warning (level 1) C4929"
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
  - "C4929"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4929"
ms.assetid: 95f8ab4f-4468-4caa-acd5-8f4592f03b3c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4929
'file': typelibrary contains a union; ignoring the 'embedded_idl' qualifier  
  
 The embedded_idl attribute of [#import](../vs140/sharpimport-directive--c---.md) could not be applied to the type library because a union is present in the type library. To resolve this warning, don't use embedded_idl.  
  
## Example  
 The following sample defines a component.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C4929.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>