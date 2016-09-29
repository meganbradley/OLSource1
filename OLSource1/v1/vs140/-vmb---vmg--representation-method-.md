---
title: "-vmb, -vmg (Representation Method)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/vmb, /vmg (Representation Method)"
f1_keywords: 
  - "/vmb"
  - "/vmg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vmb compiler option [C++]"
  - "-vmg compiler option [C++]"
  - "vmg compiler option [C++]"
  - "-vmb compiler option [C++]"
  - "/vmb compiler option [C++]"
  - "representation method compiler options [C++]"
  - "/vmg compiler option [C++]"
ms.assetid: ecdb391c-7dab-40b1-916b-673d10889fd4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -vmb, -vmg (Representation Method)
Select the method that the compiler uses to represent pointers to class members.  
  
 Use **/vmb** if you always define a class before you declare a pointer to a member of the class.  
  
 Use **/vmg** to declare a pointer to a member of a class before defining the class. This need can arise if you define members in two different classes that reference each other. For such mutually referencing classes, one class must be referenced before it is defined.  
  
## Syntax  
  
```  
/vmb  
/vmg  
```  
  
## Remarks  
 You can also use [pointers_to_members](../vs140/pointers_to_members.md) or [Inheritance Keywords](../vs140/inheritance-keywords.md) in your code to specify a pointer representation.  
  
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