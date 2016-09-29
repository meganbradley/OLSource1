---
title: "Building an Attributed Program"
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
  - "tlb files"
  - "MIDL"
  - "MIDL, linker output"
  - "IDL files"
  - "tlb files, building attributed programs"
  - ".tlb files, building attributed programs"
  - "IDL files, building"
  - "attributes [C++], building type libraries and .idl files"
  - ".tlb files"
  - ".idl files, building"
  - "type libraries, linker options for building"
ms.assetid: 04997b5f-bf2c-46ec-b868-c4adebbef5f4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Building an Attributed Program
After you put Visual C++ attributes into your source code, you may want the Visual C++ compiler to produce a type library and .idl file for you. The following linker options help you build .tlb and .idl files:  
  
-   [/IDLOUT](../VS_csharp/-idlout--name-midl-output-files-.md)  
  
-   [/IGNOREIDL](../VS_csharp/-ignoreidl--don-t-process-attributes-into-midl-.md)  
  
-   [/MIDL](../VS_csharp/-midl--specify-midl-command-line-options-.md)  
  
-   [/TLBOUT](../VS_csharp/-tlbout--name-.tlb-file-.md)  
  
 Some projects contain multiple independent .idl files. These are used to produce two or more .tlb files and optionally bind them into the resource block. This scenario is not currently supported in Visual C++.  
  
 In addition, the Visual C++ linker will output all IDL-related attribute information to a single MIDL file. There will be no way to generate two type libraries from a single project.  
  
## See Also  
 [Concepts](../VS_csharp/attributed-programming-concepts.md)