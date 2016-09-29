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
  
```  
/linkresource:filename[,identifier[,public|private]]  
' -or-  
/linkres:filename[,identifier[,public|private]]  
```  
  
## Arguments  
 `filename`  
 Required. The resource file to link to the assembly. If the file name contains a space, enclose the name in quotation marks (" ").  
  
 `identifier`  
 Optional. The logical name for the resource. The name that is used to load the resource. The default is the name of the file. Optionally, you can specify whether the file is public or private in the assembly manifest, for example: `/linkres:filename.res,myname.res,public`. By default, `filename` is public in the assembly.  
  
## Remarks  
 The `/linkresource` option does not embed the resource file in the output file; use the `/resource` option to do this.  
  
 The `/linkresource` option requires one of the `/target` options other than `/target:module`.  
  
 If `filename` is a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file created, for example, by the [Resource File Generator (Resgen.exe)](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the <xref:System.Resources*> namespace. (For more information, see <xref:System.Resources.ResourceManager*>.) To access all other resources at run time, use the methods that begin with `GetManifestResource` in the <xref:System.Reflection.Assembly*> class.  
  
 The file name can be any file format. For example, you may want to make a native DLL part of the assembly, so that it can be installed into the global assembly cache and accessed from managed code in the assembly.  
  
 The short form of `/linkresource` is `/linkres`.  
  
> [!NOTE]
>  The `/linkresource` option is not available from the Visual Studio development environment; it is available only when you compile from the command line.  
  
## Example  
 The following code compiles `In.vb` and links to resource file `Rf.resource`.  
  
```  
vbc /linkresource:rf.resource in.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [/resource (Visual Basic)](../vs140/-resource--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)