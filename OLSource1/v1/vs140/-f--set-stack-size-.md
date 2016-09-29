---
title: "-F (Set Stack Size)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/F (Set Stack Size)"
f1_keywords: 
  - "/f"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set stack size compiler option"
  - "F compiler option [C++]"
  - "-F compiler option [C++]"
  - "/F compiler option [C++]"
  - "stack, setting size"
ms.assetid: 17320b6f-8305-445b-9ec2-75833f4b29e0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -F (Set Stack Size)
Sets the program stack size in bytes.  
  
## Syntax  
  
```  
/F number  
```  
  
## Arguments  
 `number`  
 The stack size in bytes.  
  
## Remarks  
 Without this option the stack size defaults to 1 MB. The `number` argument can be in decimal or C-language notation. The argument can range from 1 to the maximum stack size accepted by the linker. The linker rounds up the specified value to the nearest 4 bytes. The space between **/F** and `number`is optional.  
  
 You may need to increase the stack size if your program gets stack-overflow messages.  
  
 You can also set the stack size by:  
  
-   Using the **/STACK** linker option. For more information, see [/STACK](../vs140/-stack.md).  
  
-   Using EDITBIN on the .exe file. For more information, see [EDITBIN Reference](../vs140/editbin-reference.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)