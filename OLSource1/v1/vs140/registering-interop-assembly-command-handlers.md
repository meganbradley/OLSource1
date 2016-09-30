---
title: "Registering Interop Assembly Command Handlers"
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
  - "interop assemblies, command handlers"
  - "command handling with interop assemblies, registering"
ms.assetid: 303cd399-e29d-4ea1-8abe-5e0b59c12a0c
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering Interop Assembly Command Handlers
A VSPackage must register with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] so that the integrated development environment (IDE) routes its commands properly.  
  
 The registry can be updated either by manual editing or by using a Registrar (.rgs) file. For more information, see [Creating Registrar Scripts](../vs140/creating-registrar-scripts.md).  
  
 The Managed Package Framework (MPF) provides this functionality through the \<xref:Microsoft.VisualStudio.Shell.ProvideMenuResourceAttribute*> class.  
  
 [Command Table Format Reference](assetId:///09e9c6ef-9863-48de-9483-d45b7b7c798f) resources are located in unmanaged satellite UI dlls.  
  
## Command Handler Registration of a VSPackage  
 A VSPackage acting as a handler for user interface (UI)-based commands requires a registry entry named after the VSPackage <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This registry entry specifies the location of the VSPackage's UI resource file and the menu resource within that file. The registry entry itself is located under HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\\*\<Version>*\Menus, where *\<Version>* is the version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], for example 9.0.  
  
> [!NOTE]
>  The root path of HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>* can be overridden with an alternate root when the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] shell is initialized. For more information about the root path, see [Installing VSPackages With Windows Installer](../vs140/installing-vspackages-with-windows-installer.md).  
  
### The CTMENU Resource Registry Entry  
 The structure of the registry entry is:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 \<*GUID*> is the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the VSPackage in the form {XXXXXX-XXXX-XXXX-XXXX-XXXXXXXXX}.  
  
 *\<Resource Information>* consists of three elements separated by commas. These elements are, in order:  
  
 \<*Path to Resource DLL*>, \<*Menu Resource ID*>, \<*Menu Version*>  
  
 The following table describes the fields of \<*Resource Information*>.  
  
|Element|Description|  
|-------------|-----------------|  
|\<*Path to Resource DLL*>|This is the full path to the resource DLL that contains the menu resource or this is left blank, indicating that the VSPackage's resource DLL is to be used (as specified in the Packages subkey where the VSPackage itself is registered).\<br />\<br /> It is customary to leave this field blank.|  
|\<*Menu Resource ID*>|This is the resource ID of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> resource that contains all of the UI elements for the VSPackage as compiled from a [.vsct](../vs140/visual-studio-command-table--.vsct--files.md) file.|  
|\<*Menu Version*>|This is a number used as a version for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> resource. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] uses this value to determine if it needs to remerge the contents of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> resource with its cache of all <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> resources. A remerge is triggered by executing the devenv setup command.\<br />\<br /> This value should initially be set to 1 and incremented after every change in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> resource and before the remerge occurs.|  
  
### Example  
 Here is an example of a couple of resource entries:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Handling Commands Using Interop Assemblies](../vs140/commands-and-menus-that-use-interop-assemblies.md)