---
title: "Manifest Generation at the Command Line"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "manifests [C++]"
  - "manifest tool (mt.exe)"
ms.assetid: fc2ff255-82b1-4c44-af76-8405c5850292
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Manifest Generation at the Command Line
When building C/C++ applications from the command line using nmake or similar tools, the manifest is generated after the linker has processed all object files and built the final binary. The linker collects assembly information stored in the object files and combines this information into a final manifest file. By default the linker will generate a file named \<binary_name>.\<extension>.manifest to describe the final binary. The linker does not embed a manifest file inside the binary and can only generate a manifest as an external file. There are several ways to embed a manifest inside the final binary, such as using the [Manifest Tool (mt.exe)](http://msdn.microsoft.com/library/aa375649) or compiling the manifest into a resource file. It is important to keep in mind that specific rules have to be followed when embedding a manifest inside the final binary to enable such features as incremental linking, signing, and edit and continue. These and other options are discussed in [Embedding a Manifest Inside a C/C++ Application](../vs140/how-to--embed-a-manifest-inside-a-c-c---application.md) when building on the command line.  
  
## See Also  
 [Manifests](http://msdn.microsoft.com/library/aa375365)   
 [/INCREMENTAL (Link Incrementally)](../vs140/-incremental--link-incrementally-.md)   
 [Strong Name Assemblies (Assembly Signing)](../vs140/strong-name-assemblies--assembly-signing---c---cli-.md)   
 [Edit and Continue](../vs140/edit-and-continue.md)   
 [Understanding Manifest Generation for C/C++ Programs](../vs140/understanding-manifest-generation-for-c-c---programs.md)