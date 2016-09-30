---
title: "-win32manifest (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/win32manifest (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/win32manifest compiler option [Visual Basic]"
  - "win32manifest compiler option [Visual Basic]"
  - "-win32manifest compiler option [Visual Basic]"
ms.assetid: 9e3191b4-90db-41c8-966a-28036fd20005
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -win32manifest (Visual Basic)
Identifies a user-defined Win32 application manifest file to be embedded into a project's portable executable (PE) file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The path of the custom manifest file.|  
  
## Remarks  
 By default, the Visual Basic compiler embeds an application manifest that specifies a requested execution level of asInvoker. It creates the manifest in the same folder in which the executable file is built, typically the bin\Debug or bin\Release folder when you use Visual Studio. If you want to supply a custom manifest, for example to specify a requested execution level of highestAvailable or requireAdministrator, use this option to specify the name of the file.  
  
> [!NOTE]
>  This option and the [/win32resource](../vs140/-win32resource.md) option are mutually exclusive. If you try to use both options in the same command line, you will get a build error.  
  
 An application that has no application manifest that specifies a requested execution level will be subject to file/registry virtualization under the User Account Control feature in Windows Vista. For more information about virtualization, see [ClickOnce Deployment on Windows Vista](../vs140/clickonce-deployment-on-windows-vista.md).  
  
 Your application will be subject to virtualization if either of the following conditions is true:  
  
1.  You use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option and you do not provide a manifest in a later build step or as part of a Windows Resource (.res) file by using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option.  
  
2.  You provide a custom manifest that does not specify a requested execution level.  
  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] creates a default .manifest file and stores it in the debug and release directories alongside the executable file. You can view or edit the default app.manifest file by clicking **View UAC Settings** on the **Application** tab in the Project Designer. For more information, see [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md).  
  
 You can provide the application manifest as a custom post-build step or as part of a Win32 resource file by using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> option. Use that same option if you want your application to be subject to file or registry virtualization on Windows Vista. This will prevent the compiler from creating and embedding a default manifest in the PE file.  
  
## Example  
 The following example shows the default manifest that the Visual Basic compiler inserts into a PE.  
  
> [!NOTE]
>  The compiler inserts a standard application name MyApplication.app into the manifest XML. This is a workaround to enable applications to run on Windows Server 2003 Service Pack 3.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/nowin32manifest (Visual Basic)](../vs140/-nowin32manifest--visual-basic-.md)