---
title: "Batch-Mode Rules"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inference rules in NMAKE"
  - "NMAKE program, inference rules"
  - "batch-mode inference rules in NMAKE"
ms.assetid: 0650b547-ef19-4455-9bba-fa567dcf88f2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Batch-Mode Rules
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Batch-mode inference rules provide only one invocation of the inference rule when N commands go through this inference rule. Without batch-mode inference rules, it would require N commands to be invoked. N is the number of dependents that trigger the inference rule.  
  
 Makefiles that contain batch-mode inference rules must use NMAKE version 1.62 or higher. To check the NMAKE version, run the _NMAKE_VER macro available with NMAKE version 1.62 or higher. This macro returns a string representing the Visual C++ product version.  
  
 The only syntactical difference from the standard inference rule is that the batch-mode inference rule is terminated with a double colon (::).  
  
> [!NOTE]
>  The tool being invoked must be able to handle multiple files. The batch-mode inference rule must use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as the macro to access dependent files.  
  
 The batch-mode inference rules can speed up the build process. It is faster to supply files to the compiler in batch, because the compiler driver is invoked only once. For example, the C and C++ compiler performs better when handling a set of files because it can remain memory resident during the process.  
  
 The following example shows how to use batch-mode inference rules:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 NMAKE produces the following output without batch-mode inference rules:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 NMAKE produces the following result with the batch-mode inference rules:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Inference Rules](../vs140/inference-rules.md)