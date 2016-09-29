---
title: "JScript Functions for C++ Wizards"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wizard JScript methods"
  - "wizard JScript methods, creating C++ wizards"
ms.assetid: f3046c56-cf67-4aaa-919e-8c066bfb6760
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# JScript Functions for C++ Wizards
|||  
|-|-|  
|[AddATLSupportToProject](../VS_csharp/addatlsupporttoproject.md)|Adds ATL support to an MFC project.|  
|[AddCoclassFromFile](../VS_csharp/addcoclassfromfile.md)|Renders and inserts into the project's .idl file a template file that contains a coclass.|  
|[AddCommonConfig](../VS_csharp/addcommonconfig.md)|Adds the default configurations to the project.|  
|[AddFilesToProject](../VS_csharp/addfilestoproject.md)|Adds all the files to the project based on the list in the file Templates.inf.|  
|[AddInterfaceFromFile](../VS_csharp/addinterfacefromfile.md)|Renders and inserts into the project's IDL file a template file that contains an interface.|  
|[CanAddATLClass](../VS_csharp/canaddatlclass.md)|Called by the wizard to verify if the project is compatible with the code wizard that is about to be run (in other words, it can accept an ATL class).<br /><br /> The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the [project control's .vsz file](../VS_csharp/.vsz-file--project-control-.md) and checks if the [Visual C++ Code Model](assetId:///dd6452c2-1054-44a1-b0eb-639a94a1216b) is available. If the code model is not available, the function reports an error and returns **false**.|  
|[CanAddClass](../VS_csharp/canaddclass.md)|The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the project control's .vsz file.<br /><br /> It verifies if the Visual C++ Code Model object is available. If the code model is not available, the function reports an error and returns **false**.|  
|[CanAddMFCClass](../VS_csharp/canaddmfcclass.md)|Called by the wizard to verify if the project is compatible with the Code Wizard that is about to be run (in other words, it can accept an MFC class).<br /><br /> The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the project control's .vsz file and checks if the Visual C++ Code Model object is available. If the code model is not available, the function reports an error and returns **false**.|  
|[CanAddNonAttributed](../VS_csharp/canaddnonattributed.md)|Indicates whether the project supports both attributed and nonattributed ATL objects.|  
|[CanUseFileName](../VS_csharp/canusefilename.md)|Checks if a file exists. If so, the wizard prompts the user to merge the code to be added to the existing file.|  
|[ConvertProjectToAttributed](../VS_csharp/convertprojecttoattributed.md)|Converts an ATL project to attributed.|  
|[CreateInfFile](../VS_csharp/createinffile.md)|Creates the Templates.inf file.|  
|[CreateProject](../VS_csharp/createproject.md)|Creates a C++ project.|  
|[CreateSafeName](../VS_csharp/createsafename.md)|Generates a C++ friendly name.|  
|[DeleteFile](../VS_csharp/deletefile.md)|Deletes the specified file.|  
|[DoesIncludeExist](../VS_csharp/doesincludeexist.md)|Indicates whether a `#include` statement exists in a file.|  
|[GetCodeForDllCanUnloadNow](../VS_csharp/getcodefordllcanunloadnow.md)|Retrieves code needed to unload the DLL.|  
|[GetCodeForDllGetClassObject](../VS_csharp/getcodefordllgetclassobject.md)|Retrieves the code for the DLL class object.|  
|[GetCodeForDllRegisterServer](../VS_csharp/getcodefordllregisterserver.md)|Retrieves the code to register a server.|  
|[GetCodeForDllUnregisterServer](../VS_csharp/getcodefordllunregisterserver.md)|Retrieves the code to unregister a server.|  
|[GetCodeForExitInstance](../VS_csharp/getcodeforexitinstance.md)|Helper function to get the text for `ExitInstance`.|  
|[GetCodeForInitInstance](../VS_csharp/getcodeforinitinstance.md)|Helper function to get the text for [InitInstance](../Topic/CWinApp::InitInstance.md).|  
|[GetExportPragmas](../VS_csharp/getexportpragmas.md)|Retrieves the pragmas for exporting functions.|  
|[GetInterfaceClasses](../VS_csharp/getinterfaceclasses.md)|Returns the `VCCodeClass` object associated with an interface.|  
|[GetInterfaceType](../VS_csharp/getinterfacetype.md)|Returns the type of interface (for example, custom, dual, dispinterface, oleautomation).|  
|[GetMaxID](../VS_csharp/getmaxid.md)|Returns the highest `dispid` from members of this interface and all of its bases.|  
|[GetMemberfunction](../VS_csharp/getmemberfunction.md)|Returns a function object based on the given name.|  
|[GetProjectFile](../VS_csharp/getprojectfile.md)|Returns the file name of per-project type of files (.rc, .idl, and so on).|  
|[GetProjectPath](../VS_csharp/getprojectpath.md)|Returns the project's directory path.|  
|[GetRuntimeErrorDesc](../VS_csharp/getruntimeerrordesc.md)|Returns a description for the type of exception.|  
|[GetUniqueFileName](../VS_csharp/getuniquefilename.md)|Returns a unique file name.|  
|[IncludeCodeElementDeclaration](../VS_csharp/includecodeelementdeclaration.md)|Adds the include statement to `strInFile`, including the header where `strCodeElemName` is implemented, if such a header found is in the project.|  
|[InsertIntoFunction](../VS_csharp/insertintofunction.md)|Helper function called in `AddATLSupportToProject` to insert code into `InitInstance`.|  
|[IsATLProject](../VS_csharp/isatlproject.md)|Indicates whether project is ATL based.|  
|[IsAttributedProject](../VS_csharp/isattributedproject.md)|Indicates whether a project is attributed.|  
|[IsMFCProject](../VS_csharp/ismfcproject.md)|Checks if a project is MFC based.|  
|[LineBeginsWith](../VS_csharp/linebeginswith.md)|Helper function called in `InsertIntoFunction` to determine if a line begins with a particular string|  
|[OffsetToLineNumber](../VS_csharp/offsettolinenumber.md)|Finds the line number for a given position in a function body.|  
|[OnWizFinish](../VS_csharp/onwizfinish.md)|Called from the wizard HTML script when the user clicks **Finish**. Calls the wizard control's **Finish** method.|  
|[RenderAddTemplate](../VS_csharp/renderaddtemplate.md)|Renders a template file and optionally adds it to the project.|  
|[SetCommonPchSettings](../VS_csharp/setcommonpchsettings.md)|Sets up the precompiled header for the project.|  
|[SetErrorInfo](../VS_csharp/seterrorinfo.md)|Provides error information.|  
|[SetFilters](../VS_csharp/setfilters.md)|Adds source, include, and resource filters for project folders.|  
|[SetMergeProxySymbol](../VS_csharp/setmergeproxysymbol.md)|Called by the wizard to add the _MERGE_PROXYSTUB symbol if needed.|  
|[SetNoPchSettings](../VS_csharp/setnopchsettings.md)|Sets up the project configuration properties when no precompiled header is used.|  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)