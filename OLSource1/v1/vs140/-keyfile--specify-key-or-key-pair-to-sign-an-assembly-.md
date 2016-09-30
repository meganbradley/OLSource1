---
title: "-KEYFILE (Specify Key or Key Pair to Sign an Assembly)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/KEYFILE (Specify Key or Key Pair to Sign an Assembly)"
f1_keywords: 
  - "/keyfile"
  - "VC.Project.VCLinkerTool.KeyFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/KEYFILE linker option"
  - "-KEYFILE linker option"
  - "KEYFILE linker option"
ms.assetid: 9b71f8c0-541c-4fe5-a0c7-9364f42ecb06
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -KEYFILE (Specify Key or Key Pair to Sign an Assembly)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where:  
  
 *filename*  
 File that contains the key. Place the string in double quotation marks (" ") if it contains a space.  
  
## Remarks  
 The linker inserts the public key into the assembly manifest and then signs the final assembly with the private key. To generate a key file, type [sn -k](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6) <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> at the command line. A signed assembly is said to have a strong name.  
  
 If you compile with [/LN](../vs140/-ln--create-msil-module-.md), the name of the key file is held in the module and incorporated into the assembly that is created when you compile an assembly that includes an explicit reference to the module, via [#using](../vs140/sharpusing-directive--c---.md), or when linking with [/ASSEMBLYMODULE](../vs140/-assemblymodule--add-a-msil-module-to-the-assembly-.md).  
  
 You can also pass your encryption information to the linker with [/KEYCONTAINER](../vs140/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md). Use [/DELAYSIGN](../vs140/-delaysign--partially-sign-an-assembly-.md) if you want a partially signed assembly. See [Strong Name Assemblies (Assembly Signing)](../vs140/strong-name-assemblies--assembly-signing---c---cli-.md) for more information on signing an assembly.  
  
 In case both **/KEYFILE** and **/KEYCONTAINER** are specified (either by command line option or by custom attribute), the linker will first try the key container. If that succeeds, then the assembly is signed with the information in the key container. If the linker does not find the key container, it will try the file specified with /KEYFILE. If that succeeds, the assembly is signed with the information in the key file and the key information will be installed in the key container (similar to sn -i) so that on the next compilation, the key container will be valid.  
  
 Note that a key file might contain only the public key.  
  
 See [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9) for more information on signing an assembly.  
  
 Other linker options that affect assembly generation are:  
  
-   [/ASSEMBLYDEBUG](../vs140/-assemblydebug--add-debuggableattribute-.md)  
  
-   [/ASSEMBLYLINKRESOURCE](../vs140/-assemblylinkresource--link-to-.net-framework-resource-.md)  
  
-   [/ASSEMBLYMODULE](../vs140/-assemblymodule--add-a-msil-module-to-the-assembly-.md)  
  
-   [/ASSEMBLYRESOURCE](../vs140/-assemblyresource--embed-a-managed-resource-.md)  
  
-   [/NOASSEMBLY](../vs140/-noassembly--create-a-msil-module-.md)  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the option into the **Additional Options** box.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.AdditionalOptions*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)