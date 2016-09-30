---
title: "How to: Create and Use Assemblies Using the Command Line (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 229ff9fb-1bd1-403b-946b-526104864c60
caps.latest.revision: 10
---
# How to: Create and Use Assemblies Using the Command Line (Visual Basic)
An assembly, or a dynamic linking library (DLL), is linked to your program at run time. To demonstrate building and using a DLL, consider the following scenario:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>: The library file that contains the methods to be called at run time. In this example, the DLL contains two methods, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>: The source file that contains the method <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. It returns the sum of its parameters. The class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that contains the method <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a member of the namespace <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>: The source code that contains the method <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. It returns the product of its parameters. The class <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that contains the method <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is also a member of the namespace <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>: The file that contains the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method. It uses the methods in the DLL file to calculate the sum and the product of the run-time arguments.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This file contains the algorithm that uses the DLL methods, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. It starts with parsing the arguments entered from the command line, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Then it calculates the sum by using the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method on the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class, and the product by using the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method on the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class.  
  
 Notice that the  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement at the beginning of the file enables you to use the unqualified class names to reference the DLL methods at compile time, as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Otherwise, you have to use the fully qualified names, as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Execution  
 To run the program, enter the name of the EXE file, followed by two numbers, as follows:  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Compiling the Code  
 To build the file <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, compile the two files <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> by using the following command line.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The [/target (Visual Basic)](../vs140/-target--visual-basic-.md) compiler option tells the compiler to output a DLL instead of an EXE file. The [/out (Visual Basic)](../vs140/-out--visual-basic-.md) compiler option followed by a file name is used to specify the DLL file name. Otherwise, the compiler uses the first file (<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>) as the name of the DLL.  
  
 To build the executable file, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, use the following command line:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The **/out** compiler option tells the compiler to output an EXE file and specifies the name of the output file (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>). This compiler option is optional. The [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md) compiler option specifies the DLL file or files that this program uses.  
  
 For more information about building from the command line, see  and [Building from the Command Line (Visual Basic)](../vs140/building-from-the-command-line--visual-basic-.md).  
  
## See Also  
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)   
 [Assemblies and the Global Assembly Cache (Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--visual-basic-.md)   
 [Creating a Class to Hold DLL Functions](assetId:///e08e4c34-0223-45f7-aa55-a3d8dd979b0f)