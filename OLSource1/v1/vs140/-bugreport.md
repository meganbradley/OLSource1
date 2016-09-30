---
title: "-bugreport"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/bugreport"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-bugreport compiler option [Visual Basic]"
  - "bugreport compiler option [Visual Basic]"
  - "/bugreport compiler option [Visual Basic]"
ms.assetid: e4325406-8dbd-4b48-b311-9ee0799e48bb
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -bugreport
Creates a file that you can use when you file a bug report.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. The name of the file that will contain your bug report. Enclose the file name in quotation marks (" ") if the name contains a space.|  
  
## Remarks  
 The following information is added to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
-   A copy of all source-code files in the compilation.  
  
-   A list of the compiler options used in the compilation.  
  
-   Version information about your compiler, common language runtime, and operating system.  
  
-   Compiler output, if any.  
  
-   A description of the problem, for which you are prompted.  
  
-   A description of how you think the problem should be fixed, for which you are prompted.  
  
 Because a copy of all source-code files is included in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you may want to reproduce the (suspected) code defect in the shortest possible program.  
  
> [!IMPORTANT]
>  The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> option produces a file that contains potentially sensitive information. This includes current time, compiler version, [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] version, OS version, user name, the command-line arguments with which the compiler was run, all source code, and the binary form of any referenced assembly. This option can be accessed by specifying command-line options in the Web.config file for a server-side compilation of an [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] application. To prevent this, modify the Machine.config file to disallow users from compiling on the server.  
  
 If this option is used with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and your application encounters an internal compiler error, the information in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is sent to Microsoft Corporation. That information will help Microsoft engineers identify the cause of the error and may help improve the next release of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. By default, no information is sent to Microsoft. However, when you compile an application by using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is enabled by default, the application collects its error reports. Then, when the computer's administrator logs in, the error reporting system displays a pop-up window that enables the administrator to forward to Microsoft any error reports that occurred since the logon.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when you compile from the command line.  
  
## Example  
 The following example compiles <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and puts all bug-reporting information in the file <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/debug (Visual Basic)](../vs140/-debug--visual-basic-.md)   
 [/errorreport](../vs140/-errorreport.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [trustLevel Element for securityPolicy (ASP.NET Settings Schema)](assetId:///729ab04c-03da-4ee5-86b1-be9d08a09369)