---
title: "-FD (IDE Minimal Rebuild)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/FD (IDE Minimal Rebuild)"
f1_keywords: 
  - "/FD"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/FD compiler option [C++]"
  - "-FD compiler option [C++]"
  - "FD compiler option [C++]"
ms.assetid: 7ef21b8c-a448-4bb4-9585-a2a870028e17
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -FD (IDE Minimal Rebuild)
**/FD** is not exposed to users except in the [Command Line](../vs140/command-line-property-pages.md) property page of a C++ project's **Property Pages** dialog box, if and only if [/Gm (Enable Minimal Rebuild)](../vs140/-gm--enable-minimal-rebuild-.md) is not also selected. **/FD** has no effect other than from the development environment. **/FD** is not exposed in the output of **cl /?**.  
  
 If you do not enable **/Gm** in the development environment, **/FD** will be used. **/FD** ensures that the .idb file has sufficient dependency information. **/FD** is only used by the development environment, and it should not be used from the command line or a build script.  
  
## See Also  
 [Output-File (/F) Options](../vs140/output-file---f--options.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)