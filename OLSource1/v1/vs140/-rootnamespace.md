---
title: "-rootnamespace"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/rootnamespace"
f1_keywords: 
  - "/rootnamespace"
  - "rootnamespace"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/rootnamespace compiler option [Visual Basic]"
  - "-rootnamespace compiler option [Visual Basic]"
  - "rootnamespace compiler option [Visual Basic]"
ms.assetid: e9245edf-6bef-420d-a7c7-324117752783
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -rootnamespace
Specifies a namespace for all type declarations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The name of the namespace in which to enclose all type declarations for the current project.|  
  
## Remarks  
 If you use the Visual Studio executable file (Devenv.exe) to compile a project created in the Visual Studio integrated development environment, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify the value of the \<xref:VSLangProj80.VBProjectProperties3.RootNamespace*> property. See [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md) for more information.  
  
 Use the common language runtime MSIL Disassembler (I<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to view the namespace names in your output file.  
  
||  
|-|  
|To set /rootnamespace in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **Application** tab.\<br />3.  Modify the value in the **Root Namespace** box.|  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and encloses all type declarations in the namespace <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [MSIL Disassembler (Ildasm.exe)](assetId:///db27f6b2-f1ec-499e-be3a-7eecf95ca42b)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)