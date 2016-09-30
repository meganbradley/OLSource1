---
title: "-main"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/main"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "main compiler option [Visual Basic]"
  - "/main compiler option [Visual Basic]"
  - "-main compiler option [Visual Basic]"
ms.assetid: 83fc339d-6652-415d-b205-b5133319b5b0
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -main
Specifies the class or module that contains the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> procedure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. A full qualification to the class or module that contains the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> procedure to be called when the program starts. This may be in the form **/main:module** or **/main:namespace.module**.  
  
## Remarks  
 Use this option when you create an executable file or Windows executable program. If the **/main** option is omitted, the compiler searches for a valid shared <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in all public classes and modules.  
  
 See [Main Procedure in Visual Basic](../vs140/main-procedure-in-visual-basic.md) for a discussion of the various forms of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> procedure.  
  
 When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a class that inherits from \<xref:System.Windows.Forms.Form*>, the compiler provides a default <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure that starts the application if the class has no <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure. This lets you compile code at the command line that was created in the development environment.  
  
 [!code[VbVbalrCompiler#16](../vs140/codesnippet/VisualBasic/-main_1.vb)]  
  
### To set /main in the Visual Studio integrated development environment  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**.  
  
     For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Application** tab.  
  
3.  Make sure the **Enable application framework** check box is not checked.  
  
4.  Modify the value in the **Startup object** box.  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, specifying that the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedure will be found in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [NIB: Visual Basic Version of Hello, World](assetId:///9d030b60-e148-4366-a462-69532f02294c)   
 [Main Procedure in Visual Basic](../vs140/main-procedure-in-visual-basic.md)