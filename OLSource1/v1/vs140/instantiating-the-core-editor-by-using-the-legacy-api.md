---
title: "Instantiating the Core Editor By Using the Legacy API"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - editors [Visual Studio SDK], legacy - instantiating editor
ms.assetid: dda23b18-96ef-43c6-b0dc-06d15cbe5cbb
caps.latest.revision: 33
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Instantiating the Core Editor By Using the Legacy API
The editor is responsible for text editing functions such as insertion, deletion, copy, and paste. It combines these functions with those provided by language services, such as text coloring, indentation, and IntelliSense statement completion.  
  
 You can instantiate an instance of the core editor in one of three ways:  
  
-   Explicitly create an instance of the core editor in a window.  
  
-   Provide an editor factory which returns an instance of the core editor  
  
-   Open a file from the project hierarchy.  
  
 The following sections discuss how to use the legacy API to instantiate the editor.  
  
## Explicitly Opening a Core Editor Instance  
 When explicitly obtaining an instance of the core editor:  
  
-   Obtain a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer?qualifyHint=False> to hold the document data object being edited.  
  
-   Create a line oriented representation of the document data object by creating an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines?qualifyHint=False> interface from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer?qualifyHint=False> interface.  
  
-   Set <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines?qualifyHint=False> as the document data object for an instance of the default implementation of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow?qualifyHint=False> interface, using the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow.SetBuffer?qualifyHint=False> method.  
  
     Host the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow?qualifyHint=False> instance in a <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame?qualifyHint=False> interface by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.CreateToolWindow?qualifyHint=False> method.  
  
 At this point, displaying the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame?qualifyHint=False> interface provides a window that contains an instance of the core editor.  
  
 However, this is not a very useful instance, because it does not have shortcut keys, or access to advanced features. To obtain access to shortcut keys and advanced features:  
  
-   Use the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer.SetLanguageServiceID?qualifyHint=False> method to associate a language service and the document data object that the editor uses.  
  
-   Either create your own shortcut keys, or use the system default by setting the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame?qualifyHint=False> objects display properties. To do this, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.SetGuidProperty?qualifyHint=False> method with the <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_InheritKeyBindings?qualifyHint=False> property.  
  
     To obtain and use non-standard shortcut keys, generate them using the .vsct file. For more information, see [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md).  
  
## How to Use an Editor factory to Obtain the Core Editor  
 When implementing a core editor with an editor factory using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance?qualifyHint=False> method, follow all the steps outlined in the previous section to explicitly host an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow?qualifyHint=False> using an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer?qualifyHint=False> document data object, in an <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame?qualifyHint=False> object.  
  
 To display the text, obtain a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False> interface from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow?qualifyHint=False> object and call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance?qualifyHint=False> method.  
  
 To provide a language service to the editor, call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer.SetLanguageServiceID?qualifyHint=False> method within the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance?qualifyHint=False> method.  
  
 To obtain default shortcut keys, unlike the previous section, you use the command context returned by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance?qualifyHint=False> method when obtaining the core editor from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance?qualifyHint=False> method.  
  
 If the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance?qualifyHint=False> method returns the same command GUID as the text editor, the instance of the core editor automatically obtains the default shortcut keys.  
  
 For general information, see [Invoking the Core Editor](../vs140/walkthrough--creating-a-core-editor-and-registering-an-editor-file-type.md).  
  
## See Also  
 [Inside the Core Editor](../vs140/inside-the-core-editor.md)   
 [Opening and Saving Project Items](../vs140/opening-and-saving-project-items.md)   
 [Invoking the Core Editor](../vs140/walkthrough--creating-a-core-editor-and-registering-an-editor-file-type.md)