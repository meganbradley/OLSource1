---
title: "-MANIFESTINPUT (Specify Manifest Input)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/MANIFESTINPUT (Specify Manifest Input)"
dev_langs: 
  - "C++"
ms.assetid: a0b0c21e-1f9b-4d8c-bb3f-178f57fa7f1b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -MANIFESTINPUT (Specify Manifest Input)
Specifies a manifest input file to include in the manifest that's embedded in the image.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The manifest file to include in the embedded manifest.  
  
## Remarks  
 The **/MANIFESTINPUT** option specifies the path of an input file to use to create the embedded manifest in an executable image. If you have multiple manifest input files, use the switch multiple times—once for each input file. The manifest input files are merged to create the embedded manifest. This option requires the **/MANIFEST:EMBED** option.  
  
 This option can’t be set directly in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. Instead, use the **Additional Manifest Files** property of the project to specify additional manifest files to include. For more information, see [Input and Output, Manifest Tool, Configuration Properties, \<Projectname> Property Pages Dialog Box](../vs140/input-and-output--manifest-tool--configuration-properties---projectname--property-pages-dialog-box.md).  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)