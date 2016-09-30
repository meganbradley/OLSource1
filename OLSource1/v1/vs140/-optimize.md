---
title: "-optimize"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/optimize"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "optimize compiler option [Visual Basic]"
  - "/optimize compiler option [Visual Basic]"
  - "optimization, enabling"
  - "-optimize compiler option [Visual Basic]"
ms.assetid: fcba4a97-3622-4b87-a891-0f77deab4998
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -optimize
Enables or disables compiler optimizations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option disables compiler optimizations. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> option enables optimizations. By default, optimizations are disabled.|  
  
## Remarks  
 Compiler optimizations make your output file smaller, faster, and more efficient. However, because optimizations result in code rearrangement in the output file, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can make debugging difficult.  
  
 All modules generated with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for an assembly must use the same <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> settings as the assembly. For more information, see [/target (Visual Basic)](../vs140/-target--visual-basic-.md).  
  
 You can combine the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> options.  
  
||  
|-|  
|To set /optimize in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**.\<br />     For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **Compile** tab.\<br />3.  Click the **Advanced** button.\<br />4.  Modify the **Enable optimizations** check box.|  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and enables compiler optimizations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/debug (Visual Basic)](../vs140/-debug--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)