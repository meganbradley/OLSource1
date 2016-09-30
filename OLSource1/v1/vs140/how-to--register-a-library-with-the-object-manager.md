---
title: "How to: Register a Library with the Object Manager"
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
  - "libraries, registering with object manager"
  - "IVsLibrary2 interface, registering library with object manager"
  - "IVsSimpleLibrary2 interface, registering library with object manager"
  - "IVsObjectManager2 interface, registering library with object manager"
  - "libraries, symbol-browsing tools"
ms.assetid: f124dd05-cb0f-44ad-bb2a-7c0b34ef4038
caps.latest.revision: 30
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Register a Library with the Object Manager
Symbols-browsing tools, such as **Class View**, **Object Browser**, **Call Browser** and **Find Symbol Results**, enable you to view symbols in your project or in external components. The symbols include namespaces, classes, interfaces, methods, and other language elements. The libraries track these symbols and expose them to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] object manager that populates the tools with the data.  
  
 The object manager keeps track of all available libraries. Each library must register with the object manager before providing symbols for the symbol-browsing tools.  
  
 Typically, you register a library when a VSPackage loads. However, it can be done at another time as needed. You unregister the library when the VSPackage shuts down.  
  
 To register a library, use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterLibrary*> method. In the case of managed code library, use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterSimpleLibrary*> method.  
  
 To unregister a library, use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.UnregisterLibrary*> method.  
  
 To obtain a reference to the object manager, \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2*>, pass the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsObjectManager*> service ID to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Registering and unregistering a Library with the Object Manager  
  
#### To register a library with the object manager  
  
1.  Create a library.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Obtain a reference to an object of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2*> type and call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterSimpleLibrary*> method.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### To unregister a library with the object manager  
  
1.  Obtain a reference to an object of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2*> type and call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.UnregisterLibrary*> method.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Language Services](../vs140/legacy-language-service-extensibility.md)   
 [Supporting Symbol-Browsing Tools](../vs140/supporting-symbol-browsing-tools.md)   
 [How-to: Expose Lists of Symbols Provided by the Library to the Object Manager](../vs140/how-to--expose-lists-of-symbols-provided-by-the-library-to-the-object-manager.md)