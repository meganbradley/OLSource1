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
|[AddATLSupportToProject](../vs140/addatlsupporttoproject.md)|Adds ATL support to an MFC project.|  
|[AddCoclassFromFile](../vs140/addcoclassfromfile.md)|Renders and inserts into the project's .idl file a template file that contains a coclass.|  
|[AddCommonConfig](../vs140/addcommonconfig.md)|Adds the default configurations to the project.|  
|[AddFilesToProject](../vs140/addfilestoproject.md)|Adds all the files to the project based on the list in the file Templates.inf.|  
|[AddInterfaceFromFile](../vs140/addinterfacefromfile.md)|Renders and inserts into the project's IDL file a template file that contains an interface.|  
|[CanAddATLClass](../vs140/canaddatlclass.md)|Called by the wizard to verify if the project is compatible with the code wizard that is about to be run (in other words, it can accept an ATL class).\<br />\<br /> The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the [project control's .vsz file](../vs140/.vsz-file--project-control-.md) and checks if the [Visual C++ Code Model](assetId:///dd6452c2-1054-44a1-b0eb-639a94a1216b) is available. If the code model is not available, the function reports an error and returns **false**.|  
|[CanAddClass](../vs140/canaddclass.md)|The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the project control's .vsz file.\<br />\<br /> It verifies if the Visual C++ Code Model object is available. If the code model is not available, the function reports an error and returns **false**.|  
|[CanAddMFCClass](../vs140/canaddmfcclass.md)|Called by the wizard to verify if the project is compatible with the Code Wizard that is about to be run (in other words, it can accept an MFC class).\<br />\<br /> The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the project control's .vsz file and checks if the Visual C++ Code Model object is available. If the code model is not available, the function reports an error and returns **false**.|  
|[CanAddNonAttributed](../vs140/canaddnonattributed.md)|Indicates whether the project supports both attributed and nonattributed ATL objects.|  
|[CanUseFileName](../vs140/canusefilename.md)|Checks if a file exists. If so, the wizard prompts the user to merge the code to be added to the existing file.|  
|[ConvertProjectToAttributed](../vs140/convertprojecttoattributed.md)|Converts an ATL project to attributed.|  
|[CreateInfFile](../vs140/createinffile.md)|Creates the Templates.inf file.|  
|[CreateProject](../vs140/createproject.md)|Creates a C++ project.|  
|[CreateSafeName](../vs140/createsafename.md)|Generates a C++ friendly name.|  
|[DeleteFile](../vs140/deletefile.md)|Deletes the specified file.|  
|[DoesIncludeExist](../vs140/doesincludeexist.md)|Indicates whether a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement exists in a file.|  
|[GetCodeForDllCanUnloadNow](../vs140/getcodefordllcanunloadnow.md)|Retrieves code needed to unload the DLL.|  
|[GetCodeForDllGetClassObject](../vs140/getcodefordllgetclassobject.md)|Retrieves the code for the DLL class object.|  
|[GetCodeForDllRegisterServer](../vs140/getcodefordllregisterserver.md)|Retrieves the code to register a server.|  
|[GetCodeForDllUnregisterServer](../vs140/getcodefordllunregisterserver.md)|Retrieves the code to unregister a server.|  
|[GetCodeForExitInstance](../vs140/getcodeforexitinstance.md)|Helper function to get the text for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.|  
|[GetCodeForInitInstance](../vs140/getcodeforinitinstance.md)|Helper function to get the text for [InitInstance](../vs140/cwinapp--initinstance.md).|  
|[GetExportPragmas](../vs140/getexportpragmas.md)|Retrieves the pragmas for exporting functions.|  
|[GetInterfaceClasses](../vs140/getinterfaceclasses.md)|Returns the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object associated with an interface.|  
|[GetInterfaceType](../vs140/getinterfacetype.md)|Returns the type of interface (for example, custom, dual, dispinterface, oleautomation).|  
|[GetMaxID](../vs140/getmaxid.md)|Returns the highest <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> from members of this interface and all of its bases.|  
|[GetMemberfunction](../vs140/getmemberfunction.md)|Returns a function object based on the given name.|  
|[GetProjectFile](../vs140/getprojectfile.md)|Returns the file name of per-project type of files (.rc, .idl, and so on).|  
|[GetProjectPath](../vs140/getprojectpath.md)|Returns the project's directory path.|  
|[GetRuntimeErrorDesc](../vs140/getruntimeerrordesc.md)|Returns a description for the type of exception.|  
|[GetUniqueFileName](../vs140/getuniquefilename.md)|Returns a unique file name.|  
|[IncludeCodeElementDeclaration](../vs140/includecodeelementdeclaration.md)|Adds the include statement to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, including the header where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is implemented, if such a header found is in the project.|  
|[InsertIntoFunction](../vs140/insertintofunction.md)|Helper function called in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to insert code into <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[IsATLProject](../vs140/isatlproject.md)|Indicates whether project is ATL based.|  
|[IsAttributedProject](../vs140/isattributedproject.md)|Indicates whether a project is attributed.|  
|[IsMFCProject](../vs140/ismfcproject.md)|Checks if a project is MFC based.|  
|[LineBeginsWith](../vs140/linebeginswith.md)|Helper function called in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to determine if a line begins with a particular string|  
|[OffsetToLineNumber](../vs140/offsettolinenumber.md)|Finds the line number for a given position in a function body.|  
|[OnWizFinish](../vs140/onwizfinish.md)|Called from the wizard HTML script when the user clicks **Finish**. Calls the wizard control's **Finish** method.|  
|[RenderAddTemplate](../vs140/renderaddtemplate.md)|Renders a template file and optionally adds it to the project.|  
|[SetCommonPchSettings](../vs140/setcommonpchsettings.md)|Sets up the precompiled header for the project.|  
|[SetErrorInfo](../vs140/seterrorinfo.md)|Provides error information.|  
|[SetFilters](../vs140/setfilters.md)|Adds source, include, and resource filters for project folders.|  
|[SetMergeProxySymbol](../vs140/setmergeproxysymbol.md)|Called by the wizard to add the _MERGE_PROXYSTUB symbol if needed.|  
|[SetNoPchSettings](../vs140/setnopchsettings.md)|Sets up the project configuration properties when no precompiled header is used.|  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)