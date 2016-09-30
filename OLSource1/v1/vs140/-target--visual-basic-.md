---
title: "-target (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/target (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "target compiler options [Visual Basic]"
  - "-target compiler options [Visual Basic]"
  - "/target compiler options [Visual Basic]"
ms.assetid: e0954147-548b-461f-9c4b-a8f88845616c
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -target (Visual Basic)
Specifies the format of compiler output.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The following table summarizes the effect of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option.  
  
|**Option**|**Behavior**|  
|----------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Causes the compiler to create an executable console application.\<br />\<br /> This is the default option when no <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option is specified. The executable file is created with an .exe extension.\<br />\<br /> Unless otherwise specified with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> option, the output file name takes the name of the input file that contains the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> procedure.\<br />\<br /> Only one <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> procedure is required in the source-code files that are compiled into an .exe file. Use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> compiler option to specify which class contains the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Causes the compiler to create a dynamic-link library (DLL).\<br />\<br /> The dynamic-link library file is created with a .dll extension.\<br />\<br /> Unless otherwise specified with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> option, the output file name takes the name of the first input file.\<br />\<br /> When building a DLL, a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedure is not required.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Causes the compiler to generate a module that can be added to an assembly.\<br />\<br /> The output file is created with an extension of .netmodule.\<br />\<br /> The .NET common language runtime cannot load a file that does not have an assembly. However, you can incorporate such a file into the assembly manifest of an assembly by using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.\<br />\<br /> When code in one module references internal types in another module, both modules must be incorporated into an assembly manifest by using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.\<br />\<br /> The [/addmodule](../vs140/-addmodule.md) option imports metadata from a module.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Causes the compiler to create an executable Windows-based application.\<br />\<br /> The executable file is created with an .exe extension. A Windows-based application is one that provides a user interface from either the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] class library or with the Win32 APIs.\<br />\<br /> Unless otherwise specified with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> option, the output file name takes the name of the input file that contains the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> procedure.\<br />\<br /> Only one <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure is required in the source-code files that are compiled into an .exe file. In cases where your code has more than one class that has a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> procedure, use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> compiler option to specify which class contains the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> procedure|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Causes the compiler to create an executable Windows-based application that must be run in an app container. This setting is designed to be used for [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] applications.\<br />\<br /> The **appcontainerexe** setting sets a bit in the Characteristics field of the [Portable Executable](http://go.microsoft.com/fwlink/p/?LinkId=236960) file. This bit indicates that the app must be run in an app container. When this bit is set, an error occurs if the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method tries to launch the application outside of an app container. Aside from this bit setting, **/target:appcontainerexe** is equivalent to **/target:winexe**.\<br />\<br /> The executable file is created with an .exe extension.\<br />\<br /> Unless you specify otherwise by using the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> option, the output file name takes the name of the input file that contains the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedure.\<br />\<br /> Only one <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> procedure is required in the source-code files that are compiled into an .exe file. If your code contains more than one class that has a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> procedure, use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> compiler option to specify which class contains the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> procedure|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Causes the compiler to create an intermediate file that you can convert to a Windows Runtime binary (.winmd) file. The .winmd file can be consumed by JavaScript and C++ programs, in addition to managed language programs.\<br />\<br /> The intermediate file is created with a .winmdobj extension.\<br />\<br /> Unless you specify otherwise by using the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> option, the output file name takes the name of the first input file. A <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> procedure isn’t required.\<br />\<br /> The .winmdobj file is designed to be used as input for the \<xref:Microsoft.Build.Tasks.WinMDExp*> export tool to produce a Windows metadata (WinMD) file. The WinMD file has a .winmd extension and contains both the code from the original library and the WinMD definitions that JavaScript, C++, and  the Windows Runtime use.|  
  
 Unless you specify <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> causes a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assembly manifest to be added to an output file.  
  
 Each instance of Vbc.exe produces, at most, one output file. If you specify a compiler option such as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> more than one time, the last one the compiler processes is put into effect. Information about all files in a compilation is added to the manifest. All output files except those created with <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> contain assembly metadata in the manifest. Use [MSIL Disassembler (Ildasm.exe)](assetId:///db27f6b2-f1ec-499e-be3a-7eecf95ca42b) to view the metadata in an output file.  
  
 The short form of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### To set /target in the Visual Studio IDE  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Application** tab.  
  
3.  Modify the value in the **Application Type** box.  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, creating <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/main](../vs140/-main.md)   
 [/out (Visual Basic)](../vs140/-out--visual-basic-.md)   
 [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md)   
 [/addmodule](../vs140/-addmodule.md)   
 [/moduleassemblyname](../vs140/-moduleassemblyname.md)   
 [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)