---
title: "-MD, -MT, -LD (Use Run-Time Library)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/MD, /MT, /LD (Use Run-Time Library)"
f1_keywords: 
  - "/ld"
  - "/mt"
  - "VC.Project.VCCLWCECompilerTool.RuntimeLibrary"
  - "VC.Project.VCCLCompilerTool.RuntimeLibrary"
  - "/md"
  - "/ml"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/MT compiler option [C++]"
  - "-MD compiler option [C++]"
  - "threading [C++], multithread compiler option"
  - "MSVCRTD.lib"
  - "MSVCRT.lib"
  - "LIBCMT.lib"
  - "MD compiler option [C++]"
  - "/MD compiler option [C++]"
  - "MT compiler option [C++]"
  - "LD compiler option [C++]"
  - "MDd compiler option [C++]"
  - "-MDd compiler option [C++]"
  - "LIBCD.lib"
  - "-MTd compiler option [C++]"
  - "MTd compiler option [C++]"
  - "/MTd compiler option [C++]"
  - "-LD compiler option [C++]"
  - "/MDd compiler option [C++]"
  - "multithread compiler option"
  - "_STATIC_CPPLIB symbol"
  - "LIBC.lib"
  - "/LD compiler option [C++]"
  - "DLLs [C++], compiler options"
  - "LIBCMTD.lib"
  - "-MT compiler option [C++]"
ms.assetid: cf7ed652-dc3a-49b3-aab9-ad60e5395579
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -MD, -MT, -LD (Use Run-Time Library)
Indicates whether a multithreaded module is a DLL and specifies retail or debug versions of the run-time library.  
  
## Syntax  
  
```  
/MD[d]  
/MT[d]  
/LD[d]  
```  
  
## Remarks  
  
|Option|Description|  
|------------|-----------------|  
|**/MD**|Causes the application to use the multithread-specific and DLL-specific version of the run-time library. Defines `_MT` and `_DLL` and causes the compiler to place the library name MSVCRT.lib into the .obj file.<br /><br /> Applications compiled with this option are statically linked to MSVCRT.lib. This library provides a layer of code that enables the linker to resolve external references. The actual working code is contained in MSVCR*versionnumber*.DLL, which must be available at run time to applications linked with MSVCRT.lib.|  
|**/MDd**|Defines `_DEBUG`, `_MT`, and `_DLL` and causes the application to use the debug multithread-specific and DLL-specific version of the run-time library. It also causes the compiler to place the library name MSVCRTD.lib into the .obj file.|  
|**/MT**|Causes the application to use the multithread, static version of the run-time library. Defines `_MT` and causes the compiler to place the library name LIBCMT.lib into the .obj file so that the linker will use LIBCMT.lib to resolve external symbols.|  
|**/MTd**|Defines `_DEBUG` and `_MT`. This option also causes the compiler to place the library name LIBCMTD.lib into the .obj file so that the linker will use LIBCMTD.lib to resolve external symbols.|  
|**/LD**|Creates a DLL.<br /><br /> Passes the **/DLL** option to the linker. The linker looks for, but does not require, a `DllMain` function. If you do not write a `DllMain` function, the linker inserts a `DllMain` function that returns TRUE.<br /><br /> Links the DLL startup code.<br /><br /> Creates an import library (.lib), if an export (.exp) file is not specified on the command line. You link the import library to applications that call your DLL.<br /><br /> Interprets [/Fe (Name EXE File)](../vs140/-fe--name-exe-file-.md) as naming a DLL rather than an .exe file. By default, the program name becomes *basename*.dll instead of *basename*.exe.<br /><br /> Implies **/MT** unless you explicitly specify **/MD**.|  
|**/LDd**|Creates a debug DLL. Defines `_MT` and `_DEBUG`.|  
  
 For more information about C run-time libraries and which libraries are used when you compile with [/clr](../vs140/-clr--common-language-runtime-compilation-.md), see [C Run-Time Libraries](../vs140/crt-library-features.md).  
  
 All modules passed to a given invocation of the linker must have been compiled with the same run-time library compiler option (**/MD**, **/MT**, **/LD**).  
  
 For more information about how to use the debug versions of the run-time libraries, see [C Run-Time Library Reference](../vs140/c-run-time-library-reference.md).  
  
 Knowledge Base article Q140584 also discusses how to choose the appropriate C run-time library.  
  
 For more about DLLs, see [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Expand the **C/C++** folder.  
  
3.  Select the **Code Generation** property page.  
  
4.  Modify the **Runtime Library** property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.RuntimeLibrary*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)