---
title: "IDE Constants"
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
  - IDE, errors
  - logical views
  - errors [Visual Studio], IDE
  - UI context constants
  - constants, Visual Studio IDE
  - IDE, constants
  - physical views
ms.assetid: 5030e70a-241d-474a-ba8c-e3b1cf947ff0
caps.latest.revision: 27
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDE Constants
The <xref:Microsoft.VisualStudio.VSConstants?qualifyHint=False> class provides constants that are specific to the integrated development environment (IDE) and that were previously defined only in header files.  
  
## Logical and Physical Views  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Code?qualifyHint=False>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97?qualifyHint=False> `cmdidOpenWith` handlers should pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor?qualifyHint=False> method to get the **Open With** dialog box, in this case on possible Code views.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Debugging?qualifyHint=False>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97?qualifyHint=False> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor?qualifyHint=False> method to get the **Open With** dialog box, in this case populated with possible <xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Debugging?qualifyHint=False> debugging views which map to the same view as <xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Code?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Designer?qualifyHint=False>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97?qualifyHint=False> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor?qualifyHint=False> method to get the **Open With** dialog box, in this case to **View Form** designer views.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Primary?qualifyHint=False>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97?qualifyHint=False> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor?qualifyHint=False> method to get the **Open With** dialog box, in this case the default/primary view of the editor factory.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_TextView?qualifyHint=False>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97?qualifyHint=False> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor?qualifyHint=False> method to get the **Open With** dialog box, in this for a document or data text editor view.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_UserChooseView?qualifyHint=False>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97?qualifyHint=False> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor?qualifyHint=False> method which prompts the user to choose which user-defined view to use.|  
  
## Editor Factory Flags  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_CLONEFILE?qualifyHint=False>|An obsolete flag combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance?qualifyHint=False> method.|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_OPENASNEW?qualifyHint=False>|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance?qualifyHint=False>, method, this indicates the editor factory should perform necessary fixes.|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_OPENFILE?qualifyHint=False>|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance?qualifyHint=False> method, this flag is mutually exclusive of <xref:Microsoft.VisualStudio.VSConstants.CEF_CLONEFILE?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_SILENT?qualifyHint=False>|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance?qualifyHint=False> method, this indicates the editor factory should create the editor without displaying a user interface (UI).|  
  
## Visual Studio Errors  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_BUSY?qualifyHint=False>|A constant returned by interfaces to asynchronous behavior when the object in question in already busy|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] for "Incompatible document data".|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PACKAGENOTLOADED?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates "Package not loaded."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTALREADYEXISTS?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates that the "Project already exists."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTMIGRATIONFAILED?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates "Project configuration failed."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTNOTLOADED?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates "Project not loaded."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SOLUTIONALREADYOPEN?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates "Solution already open."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SOLUTIONNOTOPEN?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates "Solution not open."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SPECIFYING_OUTPUT_UNSUPPORTED?qualifyHint=False>|Returned by build interfaces that have parameters for specifying an array from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutput?qualifyHint=False> interface, but the implementation can only apply the method to all outputs.|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_UNSUPPORTEDFORMAT?qualifyHint=False>|The <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance?qualifyHint=False> method returns this value if the document has a format that cannot be opened in the editor.|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_WIZARDBACKBUTTONPRESS?qualifyHint=False>|An HRESULT value that indicates that the user hit the back button in a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] wizard.|  
  
## Visual Studio Constants  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_S_PROJECTFORWARDED?qualifyHint=False>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and that indicates "Project forwarded."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_S_TBXMARKER?qualifyHint=False>|A constant that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] for a "Toolbox marker."|  
|<xref:Microsoft.VisualStudio.VSConstants.VSM_ENTERMODAL?qualifyHint=False>|A constant that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage?qualifyHint=False> method which indicates the beginning of modality.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSM_EXITMODAL?qualifyHint=False>|A constant that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage?qualifyHint=False> method that indicates the end of modality.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSM_TOOLBARMETRICSCHANGE?qualifyHint=False>|A constant that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage?qualifyHint=False> method indicating that the command bar metrics have changed.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSCOOKIE_NIL?qualifyHint=False>|A constant that is specific to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] that indicates that a cookie has not been set.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSITEMID_NIL?qualifyHint=False>|A [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] item identifier that represents the absence of a project item. This value is used when there is no current selection.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSITEMID_ROOT?qualifyHint=False>|A [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] item identifier that represents the root of a project hierarchy and is used to identify the entire hierarchy, as opposed to a single item.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSITEMID_SELECTION?qualifyHint=False>|A [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] item identifier that represents the currently selected item or items, which can include the root of the hierarchy.|  
  
## IVsSelectionEvents  
 Describes what component of the IDE has just been selected, in an <xref:Microsoft.VisualStudio.Shell.Interop.IVsSelectionEvents.OnElementValueChanged?qualifyHint=False> call, for example.  
  
|Constant|Value|  
|--------------|-----------|  
|<xref:Microsoft.VisualStudio.VSConstants.DocumentFrame?qualifyHint=False>|0x2|  
|<xref:Microsoft.VisualStudio.VSConstants.PropertyBrowserSID?qualifyHint=False>|0x4|  
|<xref:Microsoft.VisualStudio.VSConstants.StartupProject?qualifyHint=False>|0x3|  
|<xref:Microsoft.VisualStudio.VSConstants.UndoManager?qualifyHint=False>|0x0|  
|<xref:Microsoft.VisualStudio.VSConstants.UserContext?qualifyHint=False>|0x5|  
|<xref:Microsoft.VisualStudio.VSConstants.WindowFrame?qualifyHint=False>|0x1|  
  
## VSSELELEMID  
 Constants used to indicate a new selection state.  
  
|Constant|Value|  
|--------------|-----------|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_DocumentFrame?qualifyHint=False>|2|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_LastWindowFrame?qualifyHint=False>|7|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_PropertyBrowserSID?qualifyHint=False>|4|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_ResultList?qualifyHint=False>|6|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_StartupProject?qualifyHint=False>|3|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_UndoManager?qualifyHint=False>|0|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_UserContext?qualifyHint=False>|5|  
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID.SEID_WindowFrame?qualifyHint=False>|1|  
  
## Component Selector Dialog Constants  
  
|Constant|Value|  
|--------------|-----------|  
|<xref:Microsoft.VisualStudio.VSConstants.CPDN_SELCHANGED?qualifyHint=False>|WM_USER + 1280|  
|<xref:Microsoft.VisualStudio.VSConstants.CPDN_SELDBLCLICK?qualifyHint=False>|WM_USER + 1281|  
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_CLEARSELECTION?qualifyHint=False>|WM_USER + 1290|  
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_GETSELECTION?qualifyHint=False>|WM_USER + 1287|  
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_INITIALIZELIST?qualifyHint=False>|WM_USER + 1285|  
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_INITIALIZETAB?qualifyHint=False>|WM_USER + 1288|  
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_QUERYCANSELECT?qualifyHint=False>|WM_USER + 1286|  
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_SETMULTISELECT?qualifyHint=False>|WM_USER + 1289|  
  
## See Also  
 [Environment-Defined Commands for Extending Project Systems](../vs140/ide-defined-commands-for-extending-project-systems.md)