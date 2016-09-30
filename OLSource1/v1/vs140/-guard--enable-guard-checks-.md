---
title: "-GUARD (Enable Guard Checks)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/GUARD (Enable Guard Checks)"
dev_langs: 
  - "C++"
ms.assetid: 72758e23-70ac-4616-94d7-d767477406d1
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -GUARD (Enable Guard Checks)
Specifies support for Control Flow Guard checks in the executable image.  
  
## Syntax  
  
```  
/GUARD:{CF|NO}  
```  
  
## Remarks  
 When /GUARD:CF is specified, the linker modifies the header of a .dll or .exe to indicate support for Control Flow Guard (CFG) runtime checks. The linker also adds the required control flow target address data to the header. By default, /GUARD:CF is disabled. It can be explicitly disabled by using /GUARD:NO. To be effective, /GUARD:CF also requires the [/DYNAMICBASE](../vs140/-dynamicbase--use-address-space-layout-randomization-.md) linker option, which is on by default.  
  
 When source code is compiled by using the [/guard:cf](../vs140/-guard--enable-control-flow-guard-.md) option, the compiler analyzes the control flow by examining all indirect calls for possible target addresses. The compiler inserts code to verify the target address of an indirect call instruction is in the list of known target addresses at runtime. Operating systems that support CFG stop a program that fails a CFG runtime check. This makes it more difficult for an attacker to execute malicious code by using data corruption to change a call target.  
  
 The /GUARD:CF option must be specified to both the compiler and linker to create CFG-enabled executable images. Code compiled but not linked by using /GUARD:CF incurs the cost of runtime checks, but does not enable CFG protection. When the /GUARD:CF option is specified to the `cl` command to compile and link in one step, the compiler passes the flag to the linker. When the **Control Flow Guard** property is set in Visual Studio, the /GUARD:CF option is passed to both the compiler and linker. When object files or libraries have been compiled separately, the option must be explicitly specified in the `link` command.  
  
### To set this linker option in Visual Studio  
  
1.  Open the project **Property Pages** dialog box. For more information, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Expand **Configuration Properties**, **Linker**, **Command Line**.  
  
3.  In **Additional Options**, enter `/GUARD:CF`.  
  
## See Also  
 [/guard:cf (Enable Control Flow Guard)](../vs140/-guard--enable-control-flow-guard-.md)   
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)