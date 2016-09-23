---
title: "Project Model Core Components"
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
  - project models, objects and interfaces
  - project models, services
ms.assetid: b2f572d3-b26d-4846-92d1-84055fac141a
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Project Model Core Components
The following tables expand on the project model. The tables present brief descriptions of the interfaces and services identified in the model, and the interfaces and services associated with specific objects. Additionally, the tables detail other interfaces that are optional in project creation and maintenance depending on the requirements of your specific project type.  
  
 For more information, see [Supporting Symbol-Browsing Tools](../vs140/supporting-symbol-browsing-tools.md).  
  
### Package object  
  
|Interface|Comments|  
|---------------|--------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage?qualifyHint=False>|Initializes a VSPackage in the IDE and makes its services available to the IDE.|  
  
### Project Factory object  
  
|Interface|Comments|  
|---------------|--------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory?qualifyHint=False>|Manages creating new projects and opening existing projects.|  
  
### Project objects  
  
|Interfaces|Comments|  
|----------------|--------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3?qualifyHint=False>|Manages the addition and removal of project items, opens editors, and maintains mapping between each document moniker and the `VSITEMID`. Inherits from `IVsProject` and `IVsProject2`.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy?qualifyHint=False>|Manages navigation and display properties and provides events.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy?qualifyHint=False>|Enables command execution similar to that of `IOleCommandTarget` for commands such as Cut and Rename that apply only when the focus is in Solution Explorer.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget?qualifyHint=False>|Serves as the primary command target interface for a project hierarchy. It is the standard interface for querying objects for their command status or state and running commands. Available when you are not focused in the Project window.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat?qualifyHint=False>|Coordinates the persistence of the project state. Typically, the project state is stored as a project file but can be adapted to storage systems that are not file-based.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2?qualifyHint=False>|Enables the project to manage all aspects of persistence for its project items, either as files on disk or objects in other storage systems. The `IVsPeristHierarchyItem2` interface is used for items that do not implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2?qualifyHint=False> interface.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2?qualifyHint=False>|Coordinates interactions with source code control.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFlavorCfgProvider?qualifyHint=False>|Enables projects to manage configuration information.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2?qualifyHint=False>|Manages project configuration objects, such as Debug/Release configurations. Build, deploy, and debug operations are coordinated through project configuration objects.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDeleteHandler?qualifyHint=False>|Implemented by hierarchies to control the delete (destructive) or remove (non-destructive) options for hierarchy items. Call Query Interface on the `IVsHierarchyDeleteHandler` interface from the `IVsHierarchy` interface.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsGetCfgProvider?qualifyHint=False>|Provides the implementation option of having the object that supports the `IVsCfgProvider2` interface on a different COM identity than the project object that implements the `IVsHierarchy` interface.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectStartupServices?qualifyHint=False>|Optional interface implemented to make your project extensible by other developers. The `IVsProjectStartupServices` interface enables a third-party VSPackage to register a GUID that you persist into your project file so that every time your project loads, you load the third-party service GUID into your project file and call `QueryService` for that GUID.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierWinClipboardHelperEvents?qualifyHint=False>|Implemented by source hierarchies in a `UIHierarchy` window to coordinate clipboard operations such as cut, copy, and paste. Use the `AdviseClipboardHelperEvents` interface to register clipboard events.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDropDataSource2?qualifyHint=False>|Provides information about a dragged item relative to its data source during a drag-and-drop operation in a UI hierarchy window. Called from the `IVsHierarchy` interface.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDropDataTarget?qualifyHint=False>|Provides information about a dragged item relative to its drop target during a drag-and-drop operation in a UI hierarchy window. Called from the `IVsHierarchy` interface.|  
  
### Configuration object  
  
|Interfaces|Comments|  
|----------------|--------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsCfg?qualifyHint=False>|Provides information about a configuration.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectCfg2?qualifyHint=False>|Enables projects to manage configuration information.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsDebuggableProjectCfg?qualifyHint=False>|Enables a project to be run under the control of the debugger.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg?qualifyHint=False>|Implemented by deployment projects that perform deployment operations for other projects.|  
  
### Configuration Builder object  
  
|Interfaces|Comments|  
|----------------|--------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildableProjectCfg?qualifyHint=False>|Manages a project configuration's build operation.|  
  
### Additional Project objects  
  
|Interfaces|Comments|  
|----------------|--------------|  
|`IDispatch`<br /><br /> <xref:Microsoft.VisualStudio.OLE.Interop.ISpecifyPropertyPages?qualifyHint=False>|Displays item properties in the **Properties** window.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutput2?qualifyHint=False><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumOutputs?qualifyHint=False>|Displays outputs for deployment.|  
  
 The following table presents brief descriptions of the services identified in the project model.  
  
### Services  
  
|Service|Comments|  
|-------------|--------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRegisterProjectTypes?qualifyHint=False>|Used by VSPackages that implement project types to register that their project factory exists with the IDE. Your VSPackage must call `QueryService` for this service and register its project factory when `IVsPackage::SetSite` method is called. If the `SetSite` method is not called, your project is not instantiated.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution?qualifyHint=False>|Provides access to the IDE's internal, built-in notion of the current solution, such as the ability to enumerate projects, create new projects, take notice of project changes, and so on.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager?qualifyHint=False>|Called by projects that wish to participate in source control.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable?qualifyHint=False>|Maintains a table of open documents to determine whether one or more of your project items are already opened.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShellOpenDocument?qualifyHint=False>|Contains the interfaces and methods called to actually open a project item using the standard editor or a specific editor.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackProjectDocuments?qualifyHint=False>|Required to be called by all projects when they add, remove or rename their items.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsFileChangeEx?qualifyHint=False>|Manages changes to a file or directory and notifies clients when selected files have been changed on disk.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave?qualifyHint=False>|Required to be called by all projects and editors before they dirty items or save them.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolutionBuildManager?qualifyHint=False>|Manages the order of build and deployment operations for project configurations.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShellDebugger?qualifyHint=False>|Provides access to low-level debugger services used for most debugging controls.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShellMonitorSelection?qualifyHint=False>|Enables VSPackages access to information about current selections and enables communication with the **Properties** window.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell?qualifyHint=False>|Provides basic UI-related IDE functionality, such as the ability to create and enumerate tool windows or document windows or to report an error to the user.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar?qualifyHint=False>|Provides access to the IDE's status bar.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibility3?qualifyHint=False>|Used to implement the automation model. In your project model, you will return a properties object that lets you creates an instance of that object.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIHierWinClipboardHelper?qualifyHint=False>|Used to implement clipboard events on the project object in the hierarchy. `SVsUIHierWinClipboardHelper` lets you correctly handle cut, copy, and paste operations.|  
  
## See Also  
 <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget?qualifyHint=False>   
 [Checklist: Creating New Project Types](../vs140/checklist--creating-new-project-types.md)   
 [Not in Build: Using HierUtil7 Project Classes to Implement a Project Type (C++)](assetId:///a5c16a09-94a2-46ef-87b5-35b815e2f346)   
 [Supporting Symbol-Browsing Tools](../vs140/supporting-symbol-browsing-tools.md)   
 [Elements of a Project Model](../vs140/elements-of-a-project-model.md)