---
title: "How to: Register Editor File Types"
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
  - "editors [Visual Studio SDK], legacy - register file types"
ms.assetid: 54846779-8290-48de-90ab-81011559d9a5
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Register Editor File Types
The easiest way to register editor file types is by using the registration attributes provided as a part of the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] managed package framework (MPF) classes. If you are implementing your package in native [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], you can also write a registry script that registers your editor and the associated extensions.  
  
## Registration Using MPF Classes  
  
#### To register editor file types using MPF classes  
  
1.  Provide the \<xref:Microsoft.VisualStudio.Shell.ProvideEditorExtensionAttribute*> class with the appropriate parameters for your editor in the class of your VSPackage.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Where ".Sample" is the extension that is registered for this editor, and "32" is its priority level.  
  
     The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the GUID for miscellaneous file types, defined in \<xref:Microsoft.VisualStudio.VSConstants.CLSID_MiscellaneousFilesProject*>. The miscellaneous file type is provided, so that the resulting file is not going to be a part of the build process.  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> represents the folder that contains the template files that are included with the managed basic editor sample.  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is defined in the Resources.h file of the BasicEditorUI project, and identifies the editor as "My Editor".  
  
2.  Override the \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method.  
  
     In your implementation of the \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method, call the \<xref:Microsoft.VisualStudio.Shell.Package.RegisterEditorFactory*> method and pass the instance of your editor factory as demonstrated below.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     This step registers both the editor factory and the editor file extensions.  
  
3.  Unregister the editor factories.  
  
     Editor factories are automatically unregistered when the VSPackage is disposed. If the editor factory object implements the \<xref:System.IDisposable*> interface, its <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method is called after the factory has been unregistered with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## Registration Using a Registry Script  
 Registering editor factories and file types in native [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] is done using a registry script to write to the windows registry, as illustrated by the following.  
  
#### To register editor file types using a registry script  
  
1.  In your registry script, define the editor factory and the editor factory GUID string as shown in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section of the following registry script. Also, define the extension and the priority of the editor extension:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The editor file extension in this example is identified as ".rtf" and its priority is "50". The GUID strings are defined in Resource.h file of the BscEdit sample project.  
  
2.  Register the VSPackage.  
  
3.  Register the editor factory.  
  
     The editor factory is registered in the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterEditors.RegisterEditor*> implementation.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     The GUID strings are defined in Resource.h file of the BscEdit project.