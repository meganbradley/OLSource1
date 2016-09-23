---
title: "-Fi (Preprocess Output File Name)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /Fi (Preprocess Output File Name)
f1_keywords: 
  - /Fi
dev_langs: 
  - C++
helpviewer_keywords: 
  - Fi compiler option (C++)
  - -Fi compiler option (C++)
  - /Fi compiler option (C++)
  - preprocessing output files, file name
ms.assetid: 6d0ba983-a8b7-41ec-84f5-b4688ef8efee
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -Fi (Preprocess Output File Name)
Specifies the name of the output file to which the [/P (Preprocess to a File)](../vs140/-p--preprocess-to-a-file-.md) compiler option writes preprocessed output.  
  
## Syntax  
  
```  
/Fipathname  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`pathname`|The name and path of the output file produced by the **/P** compiler option.|  
  
## Remarks  
 Use the **/Fi** compiler option in combination with the **/P** compiler option.  
  
 If you specify only a path for the `pathname` parameter, the base name of the source file is used as the base name of the preprocessed output file. The `pathname` parameter does not require a particular file name extension. However, an extension of ".i" is used if you do not specify a file name extension.  
  
## Example  
 The following command line preprocesses PROGRAM.cpp, preserves comments, adds [#line](../vs140/sharpline-directive--c-c---.md) directives, and writes the result to the MYPROCESS.i file.  
  
```  
CL /P /FiMYPROCESS.I PROGRAM.CPP  
```  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [/P (Preprocess to a File)](../vs140/-p--preprocess-to-a-file-.md)   
 [Specifying the Pathname](../vs140/specifying-the-pathname.md)