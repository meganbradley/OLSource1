---
title: "-imports (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/imports (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/imports compiler option [Visual Basic]"
  - "imports compiler option [Visual Basic]"
  - "-imports compiler option [Visual Basic]"
ms.assetid: 9a93fb53-c080-497b-bf9b-441022dbbc39
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -imports (Visual Basic)
Imports namespaces from a specified assembly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. Comma-delimited list of namespaces to be imported.|  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option imports any namespace defined within the current set of source files or from any referenced assembly.  
  
 The members in a namespace specified with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are available to all source-code files in the compilation. Use the [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md) to use a namespace in a single source-code file.  
  
||  
|-|  
|To set /imports in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **References** tab.\<br />3.  Enter the namespace name in the box beside the **Add User Import** button.\<br />4.  Click the **Add User Import** button.|  
  
## Example  
 The following code compiles when <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is specified.  
  
 [!code[VbVbalrCompiler#21](../vs140/codesnippet/VisualBasic/-imports--visual-basic-_1.vb)]  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [References and the Imports Statement](../vs140/references-and-the-imports-statement--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)