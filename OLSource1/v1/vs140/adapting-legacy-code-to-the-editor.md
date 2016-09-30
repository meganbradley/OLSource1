---
title: "Adapting Legacy Code to the Editor"
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
  - "editors [Visual Studio SDK], legacy - adapters"
ms.assetid: a208d38e-9bea-41c9-9fe2-38bd86a359cb
caps.latest.revision: 29
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adapting Legacy Code to the Editor
The Visual Studio editor has many features that you can access from existing code components. The following instructions show how to adapt a non-MEF component, for example, a VSPackage, to consume editor functionality. The instructions also show how to use adapters to get the services of the editor in both managed and unmanaged code.  
  
## Editor Adapters  
 Editor adapters, or shims, are wrappers for editor objects that also expose the classes and interfaces in the \<xref:Microsoft.VisualStudio.TextManager.Interop*> API. You can use the adapters to move between non-editor services for example, Visual Studio shell commands, and editor services. (This is how the editor is currently hosted in Visual Studio.) Adapters also enable legacy editor and language service extensions to work correctly in Visual Studio.  
  
## Using Editor Adapters  
 The \<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService*> provides methods that switch between the new editor interfaces and the legacy interfaces, and also methods that create adapters.  
  
 If you are using this service in a MEF component part, you can import the service as follows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you want to use this service in a non-MEF component, follow the instructions in the "Using Visual Studio Editor Services in a Non-MEF Component" section later in this topic.  
  
## Switching Between the New Editor API and the Legacy API  
 Use the following methods to switch between an editor object and a legacy interface.  
  
|Method|Conversion|  
|------------|----------------|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetBufferAdapter*>|Converts an \<xref:Microsoft.VisualStudio.Text.ITextBuffer*> to an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetDataBuffer*>|Converts an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*> to an \<xref:Microsoft.VisualStudio.Text.ITextBuffer*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetDocumentBuffer*>|Converts an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*> to an \<xref:Microsoft.VisualStudio.Text.ITextBuffer*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetViewAdapter*>|Converts an \<xref:Microsoft.VisualStudio.Text.Editor.ITextView*> to an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetWpfTextView*>|Converts an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*> to an \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextView*>.|  
  
## Creating Adapters  
 Use the following methods to create adapters for legacy interfaces.  
  
|Method|Conversion|  
|------------|----------------|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsCodeWindowAdapter*>|Creates an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextBufferAdapter*>|Creates an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*> for a specified \<xref:Microsoft.VisualStudio.Utilities.IContentType*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextBufferAdapter*>|Creates an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextBufferCoordinatorAdapter*>|Creates an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextViewAdapter*>|Creates an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*> for an \<xref:Microsoft.VisualStudio.Text.Editor.ITextViewRoleSet*>.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextViewAdapter*>|Creates an \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*>.|  
  
## Creating Adapters in Unmanaged Code  
 All adapter classes are registered to be local co-creatable, and can be instantiated by using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function.  
  
 All adapters are created by using the GUIDs that are defined in the vsshlids.h file in the ..\VisualStudioIntegration\Common\Inc\ folder of the Visual Studio SDK installation. To create an instance of VsTextBufferAdapter, use the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Creating Adapters in Managed Code  
 In managed code, you can co-create the adapters in the same way as that described for unmanaged code. You can also use a MEF service that lets you create and interact with adapters. This manner of getting an adapter enables more fine-grained control than you have when you co-create it.  
  
#### To create an adapter for IVsTextView  
  
1.  Add a reference to Microsoft.VisualStudio.Editor.dll. Make sure that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
2.  Instantiate the \<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService*>, as follows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Call the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Using the Visual Studio Editor Directly from Unmanaged Code  
 The Microsoft.VisualStudio.Platform.VSEditor namespace and the Microsoft.VisualStudio.Platform.VSEditor.Interop namespace expose COM-callable interfaces as IVx* interfaces. For example, the Microsoft.VisualStudio.Platform.VSEditor.Interop.IVxTextBuffer interface is the COM version of the \<xref:Microsoft.VisualStudio.Text.ITextBuffer*> interface. From the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, you can get access to the buffer snapshots, modify the buffer, listen for text-change events on the buffer, and create tracking points and spans. The following steps show how to access an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> from a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
#### To get an IVxTextBuffer  
  
1.  The definitions for the IVx* interfaces are in the VSEditor.h file in the ..\VisualStudioIntegration\Common\Inc\ folder of the Visual Studio SDK installation.  
  
2.  The following code instantiates a text buffer by using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method. In the following code, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a pointer to an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Using Visual Studio Editor Services in a Non-MEF Component  
 If you have an existing managed code component that does not use MEF and you want to use the services of the Visual Studio editor, you must add a reference to the assembly that contains the ComponentModelHost VSPackage and get its SComponentModel service.  
  
#### To consume Visual Studio editor components from a non-MEF component  
  
1.  Add a reference to the Microsoft.VisualStudio.ComponentModelHost.dll assembly in the ..\Common7\IDE\ folder of the Visual Studio installation. Make sure that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
2.  Add a private <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member to the class in which you want to use Visual Studio editor services, as follows.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Instantiate the component model in the initialization method for your component.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
4.  After this, you can get any one of the Visual Studio editor services by calling the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method for the service you want.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>