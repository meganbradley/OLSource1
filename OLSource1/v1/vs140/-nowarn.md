---
title: "-nowarn"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/nowarn"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "nowarn compiler option [Visual Basic]"
  - "/nowarn compiler option [Visual Basic]"
  - "-nowarn compiler option [Visual Basic]"
ms.assetid: 7ebf2106-0652-4fdc-bf60-70fc86465d83
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -nowarn
Suppresses the compiler's ability to generate warnings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional. Comma-delimited list of the warning ID numbers that the compiler should suppress. If the warning IDs are not specified, all warnings are suppressed.|  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option causes the compiler to not generate warnings. To suppress an individual warning, supply the warning ID to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> option following the colon. Separate multiple warning numbers with commas.  
  
 You need to specify only the numeric part of the warning identifier. For example, if you want to suppress BC42024, the warning for unused local variables, specify <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For more information on the warning ID numbers, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
||  
|-|  
|To set /nowarn in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **Compile** tab.\<br />3.  Select the **Disable all warnings** check box to disable all warnings.\<br />     - or -\<br />     To disable a particular warning, click **None** from the drop-down list adjacent to the warning.|  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and does not display any warnings.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code compiles <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and does not display the warnings for unused local variables (42024).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md)