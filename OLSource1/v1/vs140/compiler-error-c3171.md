---
title: "Compiler Error C3171"
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
  - "C3171"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3171"
ms.assetid: 1ce26997-7ef1-4c9f-84da-003ea1a4251e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3171
'module': cannot specify different module attributes in a project  
  
 [module](../vs140/module--c---.md) attributes with different parameter lists were found in two of the files in a compilation. Only one unique <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute can be specified per compilation.  
  
 Identical <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attributes can be specified in more than one source code file.  
  
 For example, if the following <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attributes were found:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 the compiler would generate C3171 (note the different version values).