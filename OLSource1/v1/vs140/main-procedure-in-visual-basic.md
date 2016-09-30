---
title: "Main Procedure in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Main"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Main procedure"
  - "Main method [Visual Basic]"
  - "main function"
ms.assetid: f0db283e-f283-4464-b521-b90858cc1b44
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Main Procedure in Visual Basic
Every Visual Basic application must contain a procedure called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This procedure serves as the starting point and overall control for your application. The .NET Framework calls your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure when it has loaded your application and is ready to pass control to it. Unless you are creating a Windows Forms application, you must write the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> procedure for applications that run on their own.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> contains the code that runs first. In <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you can determine which form is to be loaded first when the program starts, find out if a copy of your application is already running on the system, establish a set of variables for your application, or open a database that the application requires.  
  
## Requirements for the Main Procedure  
 A file that runs on its own (usually with extension .exe) must contain a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure. A library (for example with extension .dll) does not run on its own and does not require a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> procedure. The requirements for the different types of projects you can create are as follows:  
  
-   Console applications run on their own, and you must supply at least one <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> procedure. .  
  
-   Windows Forms applications run on their own. However, the Visual Basic compiler automatically generates a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedure in such an application, and you do not need to write one.  
  
-   Class libraries do not require a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> procedure. These include Windows Control Libraries and Web Control Libraries. Web applications are deployed as class libraries.  
  
## Declaring the Main Procedure  
 There are four ways to declare the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> procedure. It can take arguments or not, and it can return a value or not.  
  
> [!NOTE]
>  If you declare <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in a class, you must use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword. In a module, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not need to be <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
-   The simplest way is to declare a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure that does not take arguments or return a value.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> can also return an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value, which the operating system uses as the exit code for your program. Other programs can test this code by examining the Windows ERRORLEVEL value. To return an exit code, you must declare <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> as a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> procedure instead of a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> procedure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> can also take a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> array as an argument. Each string in the array contains one of the command-line arguments used to invoke your program. You can take different actions depending on their values.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   You can declare <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to examine the command-line arguments but not return an exit code, as follows.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:Microsoft.VisualBasic.Interaction.MsgBox*>   
 \<xref:System.Array.Length*>   
 \<xref:Microsoft.VisualBasic.Information.UBound*>   
 [Structure of a Visual Basic Program](../vs140/structure-of-a-visual-basic-program.md)   
 [NIB: Visual Basic Version of Hello, World](assetId:///9d030b60-e148-4366-a462-69532f02294c)   
 [/main](../vs140/-main.md)   
 [Shared (Visual Basic)](../vs140/shared--visual-basic-.md)   
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)   
 [Integer Data Type (Visual Basic)](../vs140/integer-data-type--visual-basic-.md)   
 [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)