---
title: "MSBuild Task Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, tasks"
ms.assetid: b3144b27-a426-4259-b8ae-5f7991b202b6
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Task Reference
Tasks provide the code that runs during the build process. The tasks in the following list are included with [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)]. When [!INCLUDE[vcprvc](../VS_csharp/includes/vcprvc_md.md)] is installed, additional tasks are available that are used to build [!INCLUDE[vcprvc](../VS_csharp/includes/vcprvc_md.md)] projects. For more information, see [MSBuild Tasks Specific to Visual C++](../VS_csharp/msbuild-tasks-specific-to-visual-c--.md).  
  
 In addition to the parameters listed in the topics in this section, each task also has the following parameters:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.<br /><br /> A `Boolean` expression that the [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] engine uses to determine whether this task will be executed. For information about the conditions that are supported by [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)], see [MSBuild Conditions](../VS_csharp/msbuild-conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../VS_csharp/target-element--msbuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings.<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore Errors in Tasks](../VS_csharp/how-to--ignore-errors-in-tasks.md).|  
  
## In This Section  
 [Task Base Class](../VS_csharp/task-base-class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Utilities.Task*> class.  
  
 [TaskExtension Base Class](../VS_csharp/taskextension-base-class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.TaskExtension*> class.  
  
 [ToolTaskExtension Base Class](../VS_csharp/tooltaskextension-base-class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.ToolTaskExtension*> class.  
  
 [AL (Assembly Linker) Task](../VS_csharp/al--assembly-linker--task.md)  
 Creates an assembly with a manifest from one or more files that are either modules or resource files.  
  
 [AspNetCompiler Task](../VS_csharp/aspnetcompiler-task.md)  
 Wraps aspnet_compiler.exe, a utility to precompile ASP.NET applications.  
  
 [AssignCulture Task](../VS_csharp/assignculture-task.md)  
 Assigns culture identifiers to items.  
  
 [AssignProjectConfiguration Task](../VS_csharp/assignprojectconfiguration-task.md)  
 Accepts a list of configuration strings and assigns them to specified projects.  
  
 [AssignTargetPath Task](../VS_csharp/assigntargetpath-task.md)  
 Accepts a list of files and adds `<TargetPath>` attributes if they are not already specified.  
  
 [CallTarget Task](../VS_csharp/calltarget-task.md)  
 Invokes a target in the project file.  
  
 [CombinePath Task](../VS_csharp/combinepath-task.md)  
 Combines the specified paths into a single path.  
  
 [ConvertToAbsolutePath Task](../VS_csharp/converttoabsolutepath-task.md)  
 Converts a relative path or reference into an absolute path.  
  
 [Copy Task](../VS_csharp/copy-task.md)  
 Copies files to a new location.  
  
 [CreateCSharpManifestResourceName Task](../VS_csharp/createcsharpmanifestresourcename-task.md)  
 Creates a [!INCLUDE[csprcs](../VS_csharp/includes/csprcs_md.md)]-style manifest name from a given .resx file name or other resource.  
  
 [CreateItem Task](../VS_csharp/createitem-task.md)  
 Populates item collections from the input items, allowing items to be copied from one list to another.  
  
 [CreateProperty Task](../VS_csharp/createproperty-task.md)  
 Populates properties from the input values, allowing values to be copied from one property or string to another.  
  
 [CreateVisualBasicManifestResourceName Task](../VS_csharp/createvisualbasicmanifestresourcename-task.md)  
 Creates a [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)]-style manifest name from a given .resx file name or other resource.  
  
 [Csc Task](../VS_csharp/csc-task.md)  
 Invokes the Visual C# compiler to produce executables, dynamic-link libraries, or code modules.  
  
 [Delete Task](../VS_csharp/delete-task.md)  
 Deletes the specified files.  
  
 [Error Element (MSBuild)](../VS_csharp/error-task.md)  
 Stops a build and logs an error based on an evaluated conditional statement.  
  
 [Exec Task](../VS_csharp/exec-task.md)  
 Runs the specified program or command with the specified arguments.  
  
 [FindAppConfigFile Task](../VS_csharp/findappconfigfile-task.md)  
 Finds the app.config file, if any, in the provided lists.  
  
 [FindInList Task](../VS_csharp/findinlist-task.md)  
 Finds an item in a specified list that has the matching itemspec.  
  
 [FindUnderPath Task](../VS_csharp/findunderpath-task.md)  
 Determines which items in the specified item collection exist in the specified folder and all of its subfolders.  
  
 [FormatUrl Task](../VS_csharp/formaturl-task.md)  
 Converts a URL to a correct URL format.  
  
 [FormatVersion Task](../VS_csharp/formatversion-task.md)  
 Appends the revision number to the version number.  
  
 [GenerateApplicationManifest Task](../VS_csharp/generateapplicationmanifest-task.md)  
 Generates a [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] application manifest or a native manifest.  
  
 [GenerateBootstrapper Task](../VS_csharp/generatebootstrapper-task.md)  
 Provides an automated way to detect, download, and install an application and its prerequisites.  
  
 [GenerateDeploymentManifest Task](../VS_csharp/generatedeploymentmanifest-task.md)  
 Generates a [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] deployment manifest.  
  
 [GenerateResource Task](../VS_csharp/generateresource-task.md)  
 Converts .txt and .resx files to common language runtime binary .resources files.  
  
 [GenerateTrustInfo Task](../VS_csharp/generatetrustinfo-task.md)  
 Generates the application trust from the base manifest, and from the `TargetZone` and `ExcludedPermissions` parameters.  
  
 [GetAssemblyIdentity Task](../VS_csharp/getassemblyidentity-task.md)  
 Retrieves the assembly identities from the specified files and outputs the identity information.  
  
 [GetFrameworkPath Task](../VS_csharp/getframeworkpath-task.md)  
 Retrieves the path to the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] assemblies.  
  
 [GetFrameworkSdkPath Task](../VS_csharp/getframeworksdkpath-task.md)  
 Retrieves the path to the [!INCLUDE[winsdklong](../VS_csharp/includes/winsdklong_md.md)].  
  
 [GetReferenceAssemblyPaths Task](../VS_csharp/getreferenceassemblypaths-task.md)  
 Returns the reference assembly paths of the various frameworks.  
  
 [LC Task](../VS_csharp/lc-task.md)  
 Generates a .license file from a .licx file.  
  
 [MakeDir Task](../VS_csharp/makedir-task.md)  
 Creates directories and, if necessary, any parent directories.  
  
 [Message Element (MSBuild)](../VS_csharp/message-task.md)  
 Logs a message during a build.  
  
 [Move Task](../VS_csharp/move-task.md)  
 Moves files to a new location.  
  
 [MSBuild Task](../VS_csharp/msbuild-task.md)  
 Builds [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] projects from another [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] project.  
  
 [ReadLinesFromFile Task](../VS_csharp/readlinesfromfile-task.md)  
 Reads a list of items from a text file.  
  
 [RegisterAssembly Task](../VS_csharp/registerassembly-task.md)  
 Reads the metadata within the specified assembly and adds the necessary entries to the registry.  
  
 [RemoveDir Task](../VS_csharp/removedir-task.md)  
 Removes the specified directories and all of its files and subdirectories.  
  
 [RemoveDuplicates Task](../VS_csharp/removeduplicates-task.md)  
 Removes duplicate items from the specified item collection.  
  
 [RequiresFramework35SP1Assembly Task](../VS_csharp/requiresframework35sp1assembly-task.md)  
 Determines whether the application requires the .NET Framework 3.5 SP1.  
  
 ResGen Task  
 Obsolete. Use the [GenerateResource Task](../VS_csharp/generateresource-task.md) task to convert .txt and .resx files to and from common language runtime binary .resources files.  
  
 [ResolveAssemblyReference Task](../VS_csharp/resolveassemblyreference-task.md)  
 Determines all assemblies that depend on the specified assemblies.  
  
 [ResolveCOMReference Task](../VS_csharp/resolvecomreference-task.md)  
 Takes a list of one or more type library names or .tlb files and resolves those type libraries to locations on disk.  
  
 [ResolveKeySource Task](../VS_csharp/resolvekeysource-task.md)  
 Determines the strong name key source  
  
 [ResolveManifestFiles Task](../VS_csharp/resolvemanifestfiles-task.md)  
 Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
 [ResolveNativeReference Task](../VS_csharp/resolvenativereference-task.md)  
 Resolves native references.  
  
 [ResolveNonMSBuildProjectOutput Task](../VS_csharp/resolvenonmsbuildprojectoutput-task.md)  
 Determines the output files for non-MSBuild project references.  
  
 [SGen Task](../VS_csharp/sgen-task.md)  
 Creates an XML serialization assembly for types in the specified assembly.  
  
 [SignFile Task](../VS_csharp/signfile-task.md)  
 Signs the specified file using the specified certificate.  
  
 [Touch Task](../VS_csharp/touch-task.md)  
 Sets the access and modification times of files.  
  
 [UnregisterAssembly Task](../VS_csharp/unregisterassembly-task.md)  
 Unregisters the specified assemblies for COM interop purposes.  
  
 [UpdateManifest Task](../VS_csharp/updatemanifest-task.md)  
 Updates selected properties in a manifest and resigns.  
  
 [Vbc Task](../VS_csharp/vbc-task.md)  
 Invokes the Visual Basic compiler to produce executables, dynamic-link libraries, or code modules..  
  
 [Warning Element (MSBuild)](../VS_csharp/warning-task.md)  
 Logs a warning during a build based on an evaluated conditional statement.  
  
 [WriteCodeFragment Task](../VS_csharp/writecodefragment-task.md)  
 Generates a temporary code file by using the specified generated code fragment. Does not delete the file.  
  
 [WriteLinesToFile Task](../VS_csharp/writelinestofile-task.md)  
 Writes the specified items to the specified text file.  
  
 [XmlPeek Task](../VS_csharp/xmlpeek-task.md)  
 Returns values as specified by XPath query from an XML file.  
  
 [XmlPoke Task](../VS_csharp/xmlpoke-task.md)  
 Sets values as specified by an XPath query into an XML file.  
  
 [XslTransformation Task](../VS_csharp/xsltransformation-task.md)  
 Transforms an XML input by using an *Extensible Stylesheet Language Transformation* (XSLT) or compiled XSLT and outputs to an output device or a file.  
  
## See Also  
 [MSBuild Reference](../VS_csharp/msbuild-reference.md)   
 [How To: Write a Task](../VS_csharp/task-writing.md)   
 [MSBuild Tasks](../VS_csharp/msbuild-tasks.md)