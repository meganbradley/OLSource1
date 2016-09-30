---
title: "-warnaserror (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/warnaserror (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "warnaserror compiler option [Visual Basic]"
  - "/warnaserror compiler option [Visual Basic]"
  - "-warnaserror compiler option [Visual Basic]"
ms.assetid: 49819f1d-a1bd-4201-affe-5afe6d9712e1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -warnaserror (Visual Basic)
Causes the compiler to treat the first occurrence of a warning as an error.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|+ &#124; -|Optional. By default, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is in effect; warnings do not prevent the compiler from producing an output file. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option, which is the same as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, causes warnings to be treated as errors.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional. Comma-delimited list of the warning ID numbers to which the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> option applies. If no warning ID is specified, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option applies to all warnings.|  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> option treats all warnings as errors. Any messages that would ordinarily be reported as warnings are instead reported as errors. The compiler reports subsequent occurrences of the same warning as warnings.  
  
 By default, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is in effect, which causes the warnings to be informational only. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> option, which is the same as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, causes warnings to be treated as errors.  
  
 If you want only a few specific warnings to be treated as errors, you may specify a comma-separated list of warning numbers to treat as errors.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> option does not control how warnings are displayed. Use the [/nowarn](../vs140/-nowarn.md) option to disable warnings.  
  
||  
|-|  
|To set /warnaserror to treat all warnings as errors in the Visual Studio IDE|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **Compile** tab.\<br />3.  Make sure the **Disable all warnings** check box is unchecked.\<br />4.  Check the **Treat all warnings as errors** check box.|  
  
||  
|-|  
|To set /warnaserror to treat specific warnings as errors in the Visual Studio IDE|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**.\<br />2.  Click the **Compile** tab.\<br />3.  Make sure the **Disable all warnings** check box is unchecked.\<br />4.  Make sure the **Treat all warnings as errors** check box is unchecked.\<br />5.  Select **Error** from the **Notification** column adjacent to the warning that should be treated as an error.|  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and directs the compiler to display an error for the first occurrence of every warning it finds.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code compiles <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and treats only the warning for unused local variables (42024) as an error.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md)