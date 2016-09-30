---
title: "-resource (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/resource (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/resource compiler option [Visual Basic]"
  - "-resource compiler option [Visual Basic]"
  - "/res compiler option [Visual Basic]"
  - "res compiler option [Visual Basic]"
  - "-res compiler option [Visual Basic]"
  - "resource compiler option [Visual Basic]"
ms.assetid: eee2f227-91f2-4f2b-a9d6-1c51c5320858
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -resource (Visual Basic)
Embeds a managed resource in an assembly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. The name of the resource file to embed in the output file. By default, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is public in the assembly. Enclose the file name in quotation marks (" ") if it contains a space.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional. The logical name for the resource; the name used to load it. The default is the name of the file. Optionally, you can specify whether the resource is public or private in the assembly manifest, as with the following: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
  
## Remarks  
 Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to link a resource to an assembly without placing the resource file in the output file.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file created, for example, by the [Resource File Generator (Resgen.exe)](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the \<xref:System.Resources*> namespace (see \<xref:System.Resources.ResourceManager*> for more information). To access all other resources at run time, use one of the following methods: \<xref:System.Reflection.Assembly.GetManifestResourceInfo*>, \<xref:System.Reflection.Assembly.GetManifestResourceNames*>, or \<xref:System.Reflection.Assembly.GetManifestResourceStream*>.  
  
 The short form of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For information about how to set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the Visual Studio IDE, see [Managing Application Resources](../vs140/managing-application-resources--.net-.md).  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and attaches resource file <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/win32resource](../vs140/-win32resource.md)   
 [/linkresource (Visual Basic)](../vs140/-linkresource--visual-basic-.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)