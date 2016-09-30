---
title: "Loading VSPackages"
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
  - "VSPackages, autoloading"
  - "VSPackages, loading"
ms.assetid: f4c3dcea-5051-4065-898f-601269649d92
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Loading VSPackages
VSPackages are loaded into Visual Studio only when their functionality is required. For example, a VSPackage is loaded when Visual Studio uses a project factory or a service that the VSPackage implements. This feature is called delayed loading, which is used whenever possible to improve performance.  
  
> [!NOTE]
>  Visual Studio can determine certain VSPackage information, such as the commands that a VSPackage offers, without loading the VSPackage.  
  
 VSPackages can be set to autoload in a particular user interface (UI) context, for example, when a solution is open. The \<xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute*> attribute sets this context.  
  
### Autoloading a VSPackage in a specific context  
  
-   Add the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute to the VSPackage attributes:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     See the enumerated fields of \<xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80*> for a list of the UI contexts and their GUID values.  
  
-   Set a breakpoint in the \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method.  
  
-   Build the VSPackage and start debugging.  
  
-   Load a solution or create one.  
  
     The VSPackage loads and stops at the breakpoint.  
  
## Forcing a VSPackage to load  
 Under some circumstances a VSPackage may have to force another VSPackage to be loaded. For example, a lightweight VSPackage might load a larger VSPackage in a context that is not available as a CMDUIContext.  
  
 You can use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsShell.LoadPackage*> method to force a VSPackage to load.  
  
-   Insert this code into the \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method of the VSPackage that forces another VSPackage to load:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     When the VSPackage is initialized, it will force <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to load.  
  
     Force loading should not be used for VSPackage communication. Use [Services](../vs140/using-and-providing-services.md) instead.  
  
## Using a custom attribute to register a VSPackage  
 In certain cases you may need to create a new registration attribute for your extension. You can use registration attributes to add new registry keys or to add new values to existing keys. The new attribute must derive from \<xref:Microsoft.VisualStudio.Shell.RegistrationAttribute*>, and it must override the \<xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.Register*> and \<xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.Unregister*> methods.  
  
## Creating a Registry Key  
 In the following code, the custom attribute creates a **Custom** subkey under the key for the VSPackage that is being registered.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Creating a New Value Under an Existing Registry Key  
 You can add custom values to an existing key. The following code shows how to add a new value to a VSPackage registration key.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [VSPackages](../vs140/vspackages.md)