---
title: "Compiler Warning (level 4) C4337"
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
  - "C4337"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4337"
ms.assetid: 70bc72d9-aac5-45cd-abd3-ebe42a05897b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4337
cross-referenced type library 'typelib1' in 'typelib2' is being automatically imported  
  
 The auto_search attribute of [the #import directive](../vs140/sharpimport-directive--c---.md) caused a type library to be implicitly imported.  
  
 Given two type libraries on disk created from the following two files (compiled with midl.exe):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then the second .idl file,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates C4337:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>