---
title: "-vmm, -vms, -vmv (General Purpose Representation)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/vmm, /vms, /vmv (General Purpose Representation)"
f1_keywords: 
  - "/vms"
  - "/vmm"
  - "/vmv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Virtual Inheritance compiler option"
  - "general purpose representation compiler options"
  - "vms compiler option [C++]"
  - "vmm compiler option [C++]"
  - "/vmm compiler option [C++]"
  - "-vmm compiler option [C++]"
  - "-vms compiler option [C++]"
  - "/vms compiler option [C++]"
  - "vmv compiler option [C++]"
  - "/vmv compiler option [C++]"
  - "Single Inheritance compiler option"
  - "-vmv compiler option [C++]"
ms.assetid: 0fcd7ae0-3031-4c62-a2a8-e154c8685dae
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -vmm, -vms, -vmv (General Purpose Representation)
Used when [/vmb, /vmg (Representation Method)](../vs140/-vmb---vmg--representation-method-.md) is selected as the [representation method](../vs140/-vmb---vmg--representation-method-.md). These options indicate the inheritance model of the not-yet-encountered class definition.  
  
## Syntax  
  
```  
/vmm  
/vms  
/vmv  
```  
  
## Remarks  
 The options are described in the following table.  
  
|Option|Description|  
|------------|-----------------|  
|**/vmm**|Specifies the most general representation of a pointer to a member of a class to be one that uses multiple inheritance.\<br />\<br /> The corresponding [inheritance keyword](../vs140/inheritance-keywords.md) and argument to [#pragma pointers_to_members](../vs140/pointers_to_members.md) is **multiple_inheritance**.\<br />\<br /> This representation is larger than that required for single inheritance.\<br />\<br /> If the inheritance model of a class definition for which a pointer to a member is declared is virtual, the compiler generates an error.|  
|**/vms**|Specifies the most general representation of a pointer to a member of a class to be one that uses either no inheritance or single inheritance.\<br />\<br /> The corresponding [inheritance keyword](../vs140/inheritance-keywords.md) and argument to [#pragma pointers_to_members](../vs140/pointers_to_members.md) is **single_inheritance**.\<br />\<br /> This is the smallest possible representation of a pointer to a member of a class.\<br />\<br /> If the inheritance model of a class definition for which a pointer to a member is declared is multiple or virtual, the compiler generates an error.|  
|**/vmv**|Specifies the most general representation of a pointer to a member of a class to be one that uses virtual inheritance. It never causes an error and is the default.\<br />\<br /> The corresponding [inheritance keyword](../vs140/inheritance-keywords.md) and argument to [#pragma pointers_to_members](../vs140/pointers_to_members.md) is **virtual_inheritance**.\<br />\<br /> This option requires a larger pointer and additional code to interpret the pointer than the other options.|  
  
 When you specify one of these inheritance-model options, that model is used for all pointers to class members, regardless of their inheritance type or whether the pointer is declared before or after the class. Therefore, if you always use single-inheritance classes, you can reduce code size by compiling with **/vms**; however, if you want to use the most general case (at the expense of the largest data representation), compile with **/vmv**.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/vmb, /vmg (Representation Method)](../vs140/-vmb---vmg--representation-method-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)