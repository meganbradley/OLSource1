---
title: "-ASSEMBLYRESOURCE (Embed a Managed Resource)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ASSEMBLYRESOURCE (Embed a Managed Resource)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.EmbedManagedResourceFile"
  - "/ASSEMBLYRESOURCE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ASSEMBLYRESOURCE linker option"
  - "assemblies [C++]"
  - "-ASSEMBLYRESOURCE linker option"
  - "assemblies [C++], linking resource files"
  - "/ASSEMBLYRESOURCE linker option"
ms.assetid: 0ce6e1fb-921b-4b1b-a59c-d35388d789f2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ASSEMBLYRESOURCE (Embed a Managed Resource)
```  
/ASSEMBLYRESOURCE:filename[,[name][,PRIVATE]]  
```  
  
## Parameters  
 *filename*  
 The managed resource you want to embed in this assembly.  
  
 *name*  
 Optional. The logical name for the resource; the name used to load the resource. The default is the name of the file.  
  
 Optionally, you can specify if the file should be private in the assembly manifest. By default, *name* is public in the assembly.  
  
## Remarks  
 Use the /ASSEMBLYRESOURCE option to embed a resource in an assembly.  
  
 Resources are public in the assembly when created with the linker. The linker does not allow you to rename the resource in the assembly.  
  
 If *filename* is a .NET Framework resource (.resources) file created, for example, by the [Resource File Generator (Resgen.exe)](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the **System.Resources** namespace (see [System.Resources.ResourceManager](https://msdn.microsoft.com/en-us/library/system.resources.resourcemanager.aspx) for more information). For all other resources, use the **GetManifestResource**\* methods in **System.Reflection.Assembly** class to access the resource at run time.  
  
 Other linker options that affect assembly generation are:  
  
-   [/ASSEMBLYDEBUG](../vs140/-assemblydebug--add-debuggableattribute-.md)  
  
-   [/ASSEMBLYLINKRESOURCE](../vs140/-assemblylinkresource--link-to-.net-framework-resource-.md)  
  
-   [/ASSEMBLYMODULE](../vs140/-assemblymodule--add-a-msil-module-to-the-assembly-.md)  
  
-   [/DELAYSIGN](../vs140/-delaysign--partially-sign-an-assembly-.md)  
  
-   [/KEYFILE](../vs140/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)  
  
-   [/KEYCONTAINER](../vs140/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)  
  
-   [/NOASSEMBLY](../vs140/-noassembly--create-a-msil-module-.md)  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Input** property page.  
  
4.  Modify the **Embed Managed Resource File** property.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.EmbedManagedResourceFile*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)