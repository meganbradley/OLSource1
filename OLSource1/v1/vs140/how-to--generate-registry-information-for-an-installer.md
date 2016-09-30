---
title: "How to: Generate Registry Information for an Installer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "registration, VSPackages"
  - "VSPackages, registering"
  - "VSPackages, registration manifests"
ms.assetid: b1b41012-a777-4ccf-81a6-3b41f0e96583
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Generate Registry Information for an Installer
The RegPkg.exe utility can be used to generate a registration manifest for a managed VSPackage. The manifest can be incorporated into a Windows Installer setup package. RegPkg also can generate a file that can be included in a setup source file based on the [Windows Installer XML Toolset](http://go.microsoft.com/fwlink/?LinkId=62238).  
  
> [!IMPORTANT]
>  RegPkg generates path names that are specific to your development system, so every time you use RegPkg, you must edit the output to use appropriate Windows Installer formatted properties. For example, the InprocServer32 value should be **[SystemFolder]mscoree.dll** and paths should use **[#filekey]** and **[$componentkey]**. Adjusting the output in this way supports computers with Windows installed on a different drive or in a different directory, localized directory names, and paths that users can choose. For more information, see [Formatted](http://go.microsoft.com/fwlink/?LinkId=71120) in the Windows Installer SDK. If you follow RegPkg conventions for your development system paths—for example, file IDs of the form File_*filename*—you need make fewer changes.  
  
### To create a registration manifest  
  
-   Run RegPkg with the **/regfile** switch. Provide any other switches, the name of the output file, and the path of the VSPackage.  
  
     For example, at the command prompt, you would type something like the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To view a registration manifest  
  
-   Open the registration manifest in any text editor.  
  
     The following example is the registration manifest that RegPkg creates for the IronPython language service:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### To create a Windows Installer XML Toolset include file  
  
-   Run RegPkg with the **/wixfile** switch. Provide any other switches, the name of the output file, and the path of the VSPackage.  
  
     For example, at the command prompt, you would type something like the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### To view a Windows Installer XML Toolset include file  
  
-   Open the Windows Installer XML Toolset include file in any text editor.  
  
     The following example is the include file that RegPkg creates for the IronPython language service:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Registering VSPackages](assetId:///31e6050f-1457-4849-944a-a3c36b76f3dd)   
 [VSPackage Overview](../vs140/vspackages.md)