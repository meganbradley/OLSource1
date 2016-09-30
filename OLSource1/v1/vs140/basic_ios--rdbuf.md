---
title: "basic_ios::rdbuf"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "basic_ios::rdbuf"
  - "std.basic_ios.rdbuf"
  - "std::basic_ios::rdbuf"
  - "ios/std::basic_ios::rdbuf"
  - "basic_ios.rdbuf"
  - "rdbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdbuf method"
ms.assetid: 960139bd-cf89-418e-887c-8463e5799416
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::rdbuf
Routes stream to specified buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A stream.  
  
## Remarks  
 The first member function returns the stored stream buffer pointer.  
  
 The second member function stores <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the stored stream buffer pointer and returns the previously stored value.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **test2**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)