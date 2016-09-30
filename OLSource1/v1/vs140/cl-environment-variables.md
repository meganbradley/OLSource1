---
title: "CL Environment Variables"
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
  - "cl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INCLUDE environment variable"
  - "cl.exe compiler, environment variables"
  - "LIBPATH environment variable"
  - "environment variables, CL compiler"
ms.assetid: 2606585b-a681-42ee-986e-1c9a2da32108
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CL Environment Variables
The CL tool uses the following environment variables:  
  
-   CL and _CL\_, if defined. The CL tool prepends the options and arguments defined in the CL environment variable to the command line arguments, and appends the options and arguments defined in _CL\_, before processing.  
  
-   INCLUDE, which must point to the \include subdirectory of your Visual C++ installation.  
  
-   LIBPATH, which specifies directories to search for metadata files referenced with [#using](../vs140/sharpusing-directive--c---.md). See <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for more information on LIBPATH.  
  
 You can set the CL or _CL\_ environment variable using the following syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For details on the arguments to the CL and _CL\_ environment variables, see [Compiler Command-Line Syntax](../vs140/compiler-command-line-syntax.md).  
  
 You can use these environment variables to define the files and options you use most often and use the command line to define specific files and options for specific purposes. The CL and _CL\_ environment variables are limited to 1024 characters (the command-line input limit).  
  
 You cannot use the /D option to define a symbol that uses an equal sign (=). You can substitute the number sign (#) for an equal sign. In this way, you can use the CL or _CL_environment variables to define preprocessor constants with explicit values—for example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to define <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 For related information, see [Set Environment Variables](../vs140/setting-the-path-and-environment-variables-for-command-line-builds.md).  
  
## Examples  
 The following is an example of settting the CL environment variable:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When this environment variable is set, if you enter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> at the command line, this is the effective command:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example causes a plain CL command to compile the source files FILE1.c and FILE2.c, and then link the object files FILE1.obj, FILE2.obj, and FILE3.obj:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This has the same effect as the following command line:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Compiler Options](../vs140/compiler-options.md)