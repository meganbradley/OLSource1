---
title: "-IGNOREIDL (Don&#39;t Process Attributes into MIDL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/IGNOREIDL (Don&#39;t Process Attributes into MIDL)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.IgnoreEmbeddedIDL"
  - "/ignoreidl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IGNOREIDL linker option"
  - "-IGNOREIDL linker option"
  - "/IGNOREIDL linker option"
ms.assetid: 29514098-6a1c-4317-af2f-1dc268972780
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -IGNOREIDL (Don&#39;t Process Attributes into MIDL)
```  
/IGNOREIDL  
```  
  
## Remarks  
 The /IGNOREIDL option specifies that any [IDL attributes](../VS_csharp/idl-attributes.md) in source code should not be processed into an .idl file.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../VS_csharp/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Embedded IDL** property page.  
  
4.  Modify the **Ignore Embedded IDL** property.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.IgnoreEmbeddedIDL*>.  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)   
 [/IDLOUT (Name MIDL Output Files)](../VS_csharp/-idlout--name-midl-output-files-.md)   
 [/TLBOUT (Name .TLB File)](../VS_csharp/-tlbout--name-.tlb-file-.md)   
 [/MIDL (Specify MIDL Command Line Options)](../VS_csharp/-midl--specify-midl-command-line-options-.md)   
 [Building an Attributed Program](../VS_csharp/building-an-attributed-program.md)