---
title: "Unable to emit assembly: &lt;error message&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Unable to emit assembly: &lt;error message&gt;"
f1_keywords: 
  - "vbc30145"
  - "bc30145"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30145"
ms.assetid: 2e7eb2b9-eda6-4bdb-95cc-72c7f0be7528
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unable to emit assembly: &lt;error message&gt;
The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler calls the Assembly Linker (Al.exe, also known as Alink) to generate an assembly with a manifest, with the linker reporting an error in the emission stage of creating the assembly.  
  
 **Error ID:** BC30145  
  
### To correct this error  
  
1.  Examine the quoted error message and consult the topic [Al.exe Tool Errors and Warnings](assetId:///7f125d49-0a03-47a6-9ba9-d61a679a7d4b) for further explanation and advice.  
  
2.  Try signing the assembly manually, using either the [Assembly Linker (Al.exe)](assetId:///b5382965-0053-47cf-b92f-862860275a01) or the [Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6).  
  
3.  If the error persists, gather information about the circumstances and notify Microsoft Product Support Services.  
  
### To sign the assembly manually  
  
1.  Use the [Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6) to create a public/private key pair file.  
  
     This file has a .snk extension.  
  
2.  Delete the COM reference that is generating the error from your project.  
  
3.  From the Windows **Start** menu, point to **Programs**, point to **Microsoft Visual Studio 2008**, point to **Visual Studio Tools**, and then click **Visual Studio 2008 Command Prompt**.  
  
4.  Move to the directory where you want to place your assembly wrapper.  
  
5.  Type the following code.  
  
    ```  
    tlbimp <path to COM reference file> /out:<output assembly name> /keyfile:<path to .snk file>  
    ```  
  
     An example of the code you might enter would be the following.  
  
    ```  
    tlbimp c:\windows\system32\msi.dll /out:Interop.WindowsInstaller.dll /keyfile:"c:\documents and settings\mykey.snk"  
    ```  
  
     Use double quotation marks (") if a path or file contains spaces.  
  
6.  In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], add a .NET Assembly reference to the file you just created.  
  
## See Also  
 [Assembly Linker (Al.exe)](assetId:///b5382965-0053-47cf-b92f-862860275a01)   
 [Al.exe Tool Errors and Warnings](assetId:///7f125d49-0a03-47a6-9ba9-d61a679a7d4b)   
 [Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6)   
 [How to: Create a Public/Private Key Pair](assetId:///05026813-f3bd-4d7c-9e0b-fc588eb3d114)   
 [Product Support and Accessibility](../vs140/talk-to-us.md)