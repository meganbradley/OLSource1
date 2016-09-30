---
title: "Compiler Error C3227"
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
  - "C3227"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3227"
ms.assetid: 7939c23a-96c8-43c2-89e9-f217d132d155
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3227
'parameter' : cannot use 'keyword' to allocate a generic type  
  
 In order to instantiate a type, an appropriate constructor is required. However, the compiler is not able to ensure that an appropriate constructor is available.  
  
 You can use templates instead of generics to resolve this error, or you can use one of several methods to create an instance of the type.  
  
## Example  
 The following sample generates C3227.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>