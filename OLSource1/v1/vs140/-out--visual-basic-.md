---
title: "-out (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/out (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/out compiler option [Visual Basic]"
  - "-out compiler option [Visual Basic]"
  - "out compiler option [Visual Basic]"
ms.assetid: 9f148c15-0909-4cb8-a2db-777f8a8b45ae
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -out (Visual Basic)
Specifies the name of the output file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. The name of the output file the compiler creates. If the file name contains a space, enclose the name in quotation marks (" ").|  
  
## Remarks  
 Specify the full name and extension of the file to create. If you do not, the .exe file takes its name from the source-code file containing the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure, and the .dll file takes its name from the first source-code file.  
  
 If you specify a file name without an .exe or .dll extension, the compiler automatically adds the extension for you, depending on the value specified for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> compiler option.  
  
||  
|-|  
|To set /out in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **Application** tab.\<br />3.  Modify the value in the **Assembly Name** box.|  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and creates output file <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)