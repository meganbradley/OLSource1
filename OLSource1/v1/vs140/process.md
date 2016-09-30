---
title: "process"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "Process"
  - "process_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++], process"
  - "process __declspec keyword"
ms.assetid: 60eecc2f-4eef-4567-b9db-aaed34733023
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# process
Specifies that your managed application process should have a single copy of a particular global variable, static member variable, or static local variable shared across all application domains in the process. This is primarily intended to be used when compiling with **/clr:pure**, because under **/clr:pure** global and static variables are per application domain, by default. When compiling with **/clr**, global and static variables are per process by default (do not need to use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
 Only a global variable, a static member variable, or a static local variable of native type can be marked with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 When compiling with **/clr:pure**, variables marked as per process must also be declared as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This ensures that per process variables are not changed in one application domain, and giving unexpected results in another application domain. The primary intended use of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is to enable compile time initialization of a global variable, static member variable, or static local variable under **/clr:pure**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is only valid when compiling with [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or **/clr:pure** and is not valid when compiling with **/clr:safe**.  
  
 If you want each application domain to have its own copy of a global variable, use [appdomain](../vs140/appdomain.md).  
  
 See [Application Domains and Visual C++](../vs140/application-domains-and-visual-c--.md) for more information.  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)