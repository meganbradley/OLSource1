---
title: "Compiler Error C3172"
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
  - "C3172"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3172"
ms.assetid: 1834e2fd-6036-4c33-aff2-b51bc7c99441
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3172
'module_name': cannot specify different idl_module attributes in a project  
  
 [idl_module](../vs140/idl_module.md) attributes with the same name but different <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>parameters were found in two of the files in a compilation. Only one unique <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute can be specified per compilation.  
  
 Identical <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attributes can be specified in more than one source code file.  
  
 For example, if the following <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attributes were found:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 the compiler would generate C3172 (note the different version values).