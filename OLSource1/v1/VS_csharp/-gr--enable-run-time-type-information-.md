---
title: "-GR (Enable Run-Time Type Information)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/GR (Enable Run-Time Type Information)"
f1_keywords: 
  - "/gr"
  - "VC.Project.VCCLWCECompilerTool.RuntimeTypeInfo"
  - "VC.Project.VCCLCompilerTool.RuntimeTypeInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Gr compiler option [C++]"
  - "Gr compiler option [C++]"
  - "RTTI compiler option"
  - "/Gr compiler option [C++]"
  - "enable run-time type information compiler option [C++]"
ms.assetid: d1f9f850-dcec-49fd-96ef-e72d01148906
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -GR (Enable Run-Time Type Information)
Adds code to check object types at run time.  
  
## Syntax  
  
```  
/GR[-]  
```  
  
## Remarks  
 When **/GR** is on, the compiler defines the `_CPPRTTI` preprocessor macro. By default, **/GR** is on. **/GR-** disables run-time type information.  
  
 Use **/GR** if the compiler cannot statically resolve an object type in your code. You usually need the **/GR** option when your code uses [dynamic_cast Operator](../VS_csharp/dynamic_cast-operator.md) or [typeid](../VS_csharp/typeid-operator.md). However, **/GR** increases the size of the .rdata sections of your image. If your code does not use **dynamic_cast** or **typeid**, **/GR-** may produce a smaller image.  
  
 For more information about run-time type checking, see [Run-Time Type Information](../VS_csharp/run-time-type-information.md) in the *C++ Language Reference*.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Language** property page.  
  
4.  Modify the **Enable Run-Time Type Info** property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.RuntimeTypeInfo*>.  
  
## See Also  
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)