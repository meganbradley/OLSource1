---
title: "Registering a Legacy Language Service1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Registering a Legacy Language Service"
helpviewer_keywords: 
  - "language services [managed package framework], registering"
ms.assetid: d33b08af-09e0-4c79-87b2-5536b27fbacf
caps.latest.revision: 26
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering a Legacy Language Service1
In the managed package framework (MPF), the language service is proffered by a VSPackage (see [VSPackages](../vs140/vspackages.md)) and is registered with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] by adding registry keys and entries. This registration process is done in partly during installation and partly at runtime.  
  
## Register the Language Service by Using Attributes  
 The following attributes are used to register a language service.  
  
-   \<xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageExtensionAttribute*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageEditorOptionPageAttribute*>  
  
 These attributes are explained below  
  
### ProvideServiceAttribute  
 This attribute registers your language service as a service.  
  
### Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### ProvideLanguageServiceAttribute  
 This attribute registers your language service specifically as a language service. It allows you to set options that specify the features that your language service offers. The example shows a subset of the options a language service can provide. For the full set of language service options, see \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute*>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### ProvideLanguageExtensionAttribute  
 This attribute associates your language service with a file extension. Whenever a file with that extension is loaded, in any project, your language service is started and used to display the contents of the file.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### ProvideLanguageCodeExpansionAttribute  
 This attribute registers a location from which code expansion or snippet templates are obtained. This information is used by the **Code Snippets Browser** and by the editor when a code snippet is inserted into the source file.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### ProvideLanguageEditorOptionPageAttribute  
 This attribute registers a property page to be displayed in the **Options** dialog box under the **Text Editor** category. Use one of these attributes for each page to be displayed for your language service. If you need to organize your pages in a tree structure, use additional attributes to define each node of the tree.  
  
### Example  
 This example shows two property pages, **Options** and **Indenting**, and one node that contains the second property page.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Proffer the Language Service at Runtime  
 When your language package is loaded, you must tell [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] that your language service is ready. You do this by proffering the service. This is done in the \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method. In addition, you need to start a timer that calls your language service during idle periods so background parsing can be accomplished. This idle timer is also used to update document properties if you have implemented any through the \<xref:Microsoft.VisualStudio.Package.DocumentProperties*> class. In order to support a timer, your package must implement the \<xref:Microsoft.VisualStudio.OLE.Interop.IOleComponent*> interface (only the \<xref:Microsoft.VisualStudio.OLE.Interop.IOleComponent.FDoIdle*> method needs to be fully implemented; the remaining methods can return default values).  
  
### Example  
 This example shows a typical approach to proffering a service and supplying an idle timer.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>