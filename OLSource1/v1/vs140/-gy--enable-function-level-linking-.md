---
title: "-Gy (Enable Function-Level Linking)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Gy (Enable Function-Level Linking)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.EnableFunctionLevelLinking"
  - "/gy"
  - "VC.Project.VCCLWCECompilerTool.EnableFunctionLevelLinking"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enable function-level linking compiler option [C++]"
  - "COMDAT function"
  - "Gy compiler option [C++]"
  - "-Gy compiler option [C++]"
  - "/Gy compiler option [C++]"
  - "packaged functions"
ms.assetid: 0d3cf14c-ed7d-4ad3-b4b6-104e56f61046
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Gy (Enable Function-Level Linking)
Allows the compiler to package individual functions in the form of packaged functions (COMDATs).  
  
## Syntax  
  
```  
/Gy[-]  
```  
  
## Remarks  
 The linker requires that functions be packaged separately as COMDATs to exclude or order individual functions in a DLL or .exe file.  
  
 You can use the linker option [/OPT (Optimizations)](../vs140/-opt--optimizations-.md) to exclude unreferenced packaged functions from the .exe file.  
  
 You can use the linker option [/ORDER (Put Functions in Order)](../vs140/-order--put-functions-in-order-.md) to include packaged functions in a specified order in the .exe file.  
  
 Inline functions are always packaged if they are instantiated as calls (which occurs, for example, if inlining is off or you take a function address). In addition, C++ member functions defined in the class declaration are automatically packaged; other functions are not, and selecting this option is required to compile them as packaged functions.  
  
> [!NOTE]
>  The [/ZI](../vs140/-z7---zi---zi--debug-information-format-.md) option, used for Edit and Continue, automatically sets the **/Gy** option.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Code Generation** property page.  
  
4.  Modify the **Enable Function-Level Linking** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.EnableFunctionLevelLinking*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)