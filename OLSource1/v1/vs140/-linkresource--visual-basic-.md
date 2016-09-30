---
title: "-linkresource (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/linkresource (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/linkresource compiler option [Visual Basic]"
  - "-linkresource compiler option [Visual Basic]"
  - "linkresource compiler option [Visual Basic]"
  - "/linkres compiler option [Visual Basic]"
  - "linkres compiler option [Visual Basic]"
  - "-linkres compiler option [Visual Basic]"
ms.assetid: cf4dcad8-17b7-404c-9184-29358aa05b15
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -linkresource (Visual Basic)
Creates a link to a managed resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The resource file to link to the assembly. If the file name contains a space, enclose the name in quotation marks (" ").  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The logical name for the resource. The name that is used to load the resource. The default is the name of the file. Optionally, you can specify whether the file is public or private in the assembly manifest, for example: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. By default, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is public in the assembly.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option does not embed the resource file in the output file; use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> option to do this.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option requires one of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> options other than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file created, for example, by the [Resource File Generator (Resgen.exe)](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the \<xref:System.Resources*> namespace. (For more information, see \<xref:System.Resources.ResourceManager*>.) To access all other resources at run time, use the methods that begin with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the \<xref:System.Reflection.Assembly*> class.  
  
 The file name can be any file format. For example, you may want to make a native DLL part of the assembly, so that it can be installed into the global assembly cache and accessed from managed code in the assembly.  
  
 The short form of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> option is not available from the Visual Studio development environment; it is available only when you compile from the command line.  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and links to resource file <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [/resource (Visual Basic)](../vs140/-resource--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)