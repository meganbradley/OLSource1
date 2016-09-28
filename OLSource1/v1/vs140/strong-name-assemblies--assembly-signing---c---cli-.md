---
title: "Strong Name Assemblies (Assembly Signing) (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Strong Name Assemblies (Assembly Signing) (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assemblies [C++]"
  - "signing assemblies"
  - ".NET Framework [C++], assembly signing"
  - "assemblies [C++], signing"
  - "linker [C++], assembly signing"
  - "strong-named assemblies [C++]"
ms.assetid: c337cd3f-e5dd-4c6f-a1ad-437e85dba1cc
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Strong Name Assemblies (Assembly Signing) (C++-CLI)
This topic discusses how you can sign your assembly, often referred to as giving your assembly a strong name.  
  
## Remarks  
 When using Visual C++, use linker options to sign your assembly to avoid issues related to the CLR attributes for assembly signing:  
  
-   <xref:System.Reflection.AssemblyDelaySignAttribute*>  
  
-   <xref:System.Reflection.AssemblyKeyFileAttribute*>  
  
-   <xref:System.Reflection.AssemblyKeyNameAttribute*>  
  
 Reasons for not using the attributes include the fact that the key name is visible in assembly metadata, which can be a security risk if the file name includes confidential information. Also, the build process used by the Visual C++ development environment will invalidate the key with which the assembly is signed if you use CLR attributes to give an assembly a strong name, and then run a post-processing tool like mt.exe on the assembly.  
  
 If you build at the command line, use linker options to sign your assembly, and then run a post-processing tool (like mt.exe), you will need to re-sign the assembly with sn.exe. Alternatively, you can build and delay sign the assembly and after running post-processing tools, complete the signing.  
  
 If you use the signing attributes when building in the development environment, you can successfully sign the assembly by explicitly calling sn.exe ([Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6)) in a post-build event. For more information, see [Specifying Build Events](../vs140/specifying-build-events.md). Build times may be less if you use attributes and a post-build event, compared to using a linker options.  
  
 The following linker options support assembly signing:  
  
-   [/DELAYSIGN (Partially Sign an Assembly)](../vs140/-delaysign--partially-sign-an-assembly-.md)  
  
-   [/KEYFILE (Specify Key or Key Pair to Sign an Assembly)](../vs140/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)  
  
-   [/KEYCONTAINER (Specify a Key Container to Sign an Assembly)](../vs140/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)  
  
 For more information on strong assemblies, see [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9).  
  
## See Also  
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)