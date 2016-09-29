---
title: "Determining Which Editor Opens a File in a Project"
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
  - "editors [Visual Studio SDK], determining which editor opens a file"
  - "projects [Visual Studio SDK], determining which editor opens file"
  - "project types, determining which editor opens a file"
  - "persistence, determining which editor opens a file"
ms.assetid: acbcf4d8-a53a-4727-9043-696a47369479
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Determining Which Editor Opens a File in a Project
When a user opens a file in a project, the environment goes through a polling process, eventually opening the appropriate editor or designer for that file. The initial procedure employed by the environment is the same for both standard and custom editors. The environment uses a variety of criteria when polling which editor to use to open a file and the VSPackage must coordinate with the environment during this process.  
  
 For example, when a user selects the **Open** command from the **File** menu, and then chooses `filename`.rtf (or any other file with a .rtf extension), the environment calls the [IsDocumentInProject](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsProject3.IsDocumentInProject(System.String,System.Int32@,Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY[],System.UInt32@)?qualifyHint=False&autoUpgrade=True) implementation for each project, eventually cycling through all project instances in the solution. Projects return a set of flags that identify claims on a document by priority. Using the highest priority, the environment calls the appropriate [OpenItem](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsProject3.OpenItem(System.UInt32,System.Guid@,System.IntPtr,Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame@)?qualifyHint=False&autoUpgrade=True) method. For further information on the polling process, [Adding Project and Project Item Templates](../vs140/adding-project-and-project-item-templates.md).  
  
 The Miscellaneous Files project claims all files that are not claimed by other projects. This way, custom editors can open documents before standard editors open them. If a Miscellaneous Files project claims a file, the environment calls the [OpenStandardEditor](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor(System.UInt32,System.String,System.Guid@,System.String,Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy,System.UInt32,System.IntPtr,Microsoft.VisualStudio.OLE.Interop.IServiceProvider,Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame@)?qualifyHint=False&autoUpgrade=True) method to open the file with a standard editor. The environment checks its internal list of registered editors for one that handles .rtf files. This list is located in the registry at the following key:  
  
 [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\\<`version`>\Editors\\{<`editor factory guid`>}\Extensions]  
  
 The environment also checks the class identifiers in the HKEY_CLASSES_ROOT\CLSID key for any objects that have a sub-key DocObject. If the file extension is found there, an embedded version of the application, such as Microsoft Word, is created in-place in Visual Studio. These document objects must be compound files that implement the <xref:Microsoft.VisualStudio.OLE.Interop.IPersistStorage*> interface, or the object must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat*> interface.  
  
 If there is no editor factory for .rtf files in the registry, then the environment looks in the HKEY_CLASSES_ROOT \\.rtf key and opens the editor specified there. If the file extension is not found in HKEY_CLASSES_ROOT, then the environment uses the Visual Studio core text editor to open the file if it is a text file.  
  
 If the core text editor fails, which occurs if the file is not a text file, then the environment uses its binary editor for the file.  
  
 If the environment does find an editor for the .rtf extension in its registry, it loads the VSPackage that implements this editor factory. The environment calls the [SetSite](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider)?qualifyHint=False&autoUpgrade=True) method on the new VSPackage. The VSPackage calls `QueryService` for `SID_SVsRegistorEditor`, using the [RegisterEditor](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsRegisterEditors.RegisterEditor(System.Guid@,Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory,System.UInt32@)?qualifyHint=False&autoUpgrade=True) method to register the editor factory with the environment.  
  
 The environment now re-checks its internal list of registered editors to find the newly registered editor factory for .rtf files. The environment calls your implementation of the [CreateEditorInstance](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance(System.UInt32,System.String,System.String,Microsoft.VisualStudio.Shell.Interop.IVsHierarchy,System.UInt32,System.IntPtr,System.IntPtr@,System.IntPtr@,System.String@,System.Guid@,System.Int32@)?qualifyHint=False&autoUpgrade=True) method, passing in the file name and view type to create.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat*>   
 <xref:Microsoft.VisualStudio.OLE.Interop.IPersistStorage*>   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsProject3.IsDocumentInProject(System.String,System.Int32@,Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY[],System.UInt32@)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsProject3.OpenItem(System.UInt32,System.Guid@,System.IntPtr,Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame@)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor(System.UInt32,System.String,System.Guid@,System.String,Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy,System.UInt32,System.IntPtr,Microsoft.VisualStudio.OLE.Interop.IServiceProvider,Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame@)?qualifyHint=False&autoUpgrade=True