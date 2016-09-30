---
title: "GenerateApplicationManifest Task"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#GenerateApplicationManifest"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, GenerateApplicationManifest task"
  - "HostInBrowser property (MSBuild)"
  - "GenerateApplicationManifest task [MSBuild]"
ms.assetid: a494102b-0cb2-4755-8e2a-d2c0f39fac1d
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GenerateApplicationManifest Task
Generates a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest or a native manifest. A native manifest describes a component by defining a unique identity for the component and identifying all assemblies and files that make up the component. A [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest extends a native manifest by indicating the entry point of the application, and specifying the application security level.  
  
## Parameters  
 The following table describes the parameters for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field of the assembly identity for the generated manifest. If this parameter is not specified, the name is inferred from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameters. If no name can be created, the task throws an error.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field of the assembly identity for the generated manifest. If this parameter is not specified, a default value of "1.0.0.0" is used.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the minimum version of the Common Language Runtime (CLR) required by the application. The default value is the CLR version in use by the build system. If the task is generating a native manifest, this parameter is ignored.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies which item contains the application configuration file. If the task is generating a native manifest, this parameter is ignored.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies an item list that defines the set of dependent assemblies for the generated manifest. Each item may be further described by item metadata to indicate additional deployment state and the type of dependence. For more information, see the "Item Metadata" section below.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the description for the application or component.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a single item that indicates the entry point for the generated manifest assembly.\<br />\<br /> For a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest, this parameter specifies the assembly that starts when the application is run.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional [String](assetId:///String?qualifyHint=False&autoUpgrade=True) parameter.\<br />\<br /> Specifies the URL of the Web page that is displayed in dialog boxes during error reports in ClickOnce installations.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a list of one or more file type that are associated with the ClickOnce deployment manifest.\<br />\<br /> File associations only valid only when .NET Framework 3.5 or later is targeted.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter.\<br />\<br /> The files to include in the manifest. Specify the full path for each file.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Optional [Boolean](assetId:///Boolean?qualifyHint=False&autoUpgrade=True) parameter.\<br />\<br /> If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the application is hosted in a browser (as are WPF Web Browser Applications).|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>31\</CodeContentPlaceHolder> parameter.\<br />\<br /> Indicates the application icon file. The application icon is expressed in the generated application manifest and is used for the Start Menu and Add/Remove Programs dialog. If this input is not specified, a default icon is used. If the task is generating a native manifest, this parameter is ignored.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Indicates an input XML document to serve as a base for the manifest generator. This allows structured data such as application security or custom manifest definitions to be reflected in the output manifest. The root element in the XML document must be an assembly node in the asmv1 namespace.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies COM components to isolate in the generated manifest. This parameter supports the ability to isolate COM components for "Registration Free COM" deployment. It works by auto-generating a manifest with standard COM registration definitions. However, the COM components must be registered on the build machine in order for this to function properly.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies which type of manifest to generate. This parameter can have the following values:\<br />\<br /> -   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>\<br />\<br /> If this parameter is not specified, the task defaults to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the maximum allowable length of a file path in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application deployment. If this value is specified, the length of each file path in the application is checked against this limit. Any items that exceed the limit will raise in a build warning. If this input is not specified or is zero, then no checking is performed. If the task is generating a native manifest, this parameter is ignored.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the minimum required operating system (OS) version required by the application. For example, the value "5.1.2600.0" indicates the operating system is Windows XP. If this parameter is not specified, the value "4.10.0.0" is used, which indicates Windows 98 Second Edition, the minimum supported OS of the .NET Framework. If the task is generating a native manifest, this input is ignored.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> output parameter.\<br />\<br /> Specifies the name of the generated output manifest file. If this parameter is not specified, the name of the output file is inferred from the identity of the generated manifest.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the target platform of the application. This parameter can have the following values:\<br />\<br /> -   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>\<br />\<br /> If this parameter is not specified, the task defaults to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the name of the application. If this parameter is not specified, the name is inferred from the identity of the generated manifest. This name is used for the shortcut name on the Start menu and is part of the name that appears in the Add or Remove Programs dialog box.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the publisher of the application. If this parameter is not specified, the name is inferred from the registered user, or the identity of the generated manifest. This name is used for the folder name on the Start menu and is part of the name that appears in the Add or Remove Programs dialog box.|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter.\<br />\<br /> If true, the application requires the .NET Framework 3.5 SP1 or a more recent version.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> parameter.\<br />\<br /> Identifies the culture of the application and specifies the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> field of the assembly identity for the generated manifest. If this parameter is not specified, it is assumed the application is culture invariant.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the target framework moniker.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the target framework profile.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the name of the .NET Framework subset to target.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the target .NET Framework of the project.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Indicates an XML document that specifies the application security. The root element in the XML document must be a trustInfo node in the asmv2 namespace. If the task is generating a native manifest, this parameter is ignored.|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Optional assetId:///Boolean?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> If true, the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> properties are written to the application manifest.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.GenerateManifestBase*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of the parameters of the Task class, see [Task Base Class](../vs140/task-base-class.md).  
  
 For information about how to use the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> task, see [GenerateApplicationManifest Task](../vs140/generateapplicationmanifest-task.md).  
  
 The inputs for dependencies and files may be further decorated with item metadata to specify additional deployment state for each item.  
  
## Item Metadata  
  
|Metadata name|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Indicates whether the dependency is published and installed with the application or a prerequisite. This metadata is valid for all dependencies, but is not used for files. The available values for this metadata are:\<br />\<br /> -   <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>\<br />\<br /> Install is the default value.|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Indicates whether the dependency is a managed or a native assembly. This metadata is valid for all dependencies, but is not used for files. The available values for this metadata are:\<br />\<br /> -   <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>\<br />-   <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is the default value, which indicates that the manifest generator will determine the assembly type automatically.|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Indicates the group for downloading additional files on-demand. The group name is defined by the application and can be any string. An empty string indicates the file is not part of a download group, which is the default. Files not in a group are part of the initial application download. Files in a group are only downloaded when explicitly requested by the application using \<xref:System.Deployment.Application*>.\<br />\<br /> This metadata is valid for all files where <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> and all dependencies where <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|Specifies how the path should be defined in the generated manifest. This attribute is valid for all files. If this attribute is not specified, the item specification is used. This attribute is valid for all files and dependencies with a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> metadata value that indicates whether or not the file is a data file. A data file is special in that it is migrated between application updates. This metadata is only valid for files. <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is the default value.|  
  
## Example  
 This example uses the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> task to generate a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest and the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> task to generate a deployment manifest for an application with a single assembly. It then uses the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> task to sign the manifests.  
  
 This illustrates the simplest possible manifest generation scenario where [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] manifests are generated for a single program. A default name and identity are inferred from the assembly for the manifest.  
  
> [!NOTE]
>  In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment.  
  
> [!NOTE]
>  For more information on the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> property used in the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> task in this example, see [SignFile Task](../vs140/signfile-task.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This example uses the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> tasks to generate [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application and deployment manifests for an application with a single assembly, specifying name and identity of manifests.  
  
 This example is similar to previous example except the name and identity of the manifests are explicitly specified. Also, this example is configured as an online application instead of an installed application.  
  
> [!NOTE]
>  In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment.  
  
> [!NOTE]
>  For more information on the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> property used in the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> task in this example, see [SignFile Task](../vs140/signfile-task.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example uses the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> tasks to generate [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application and deployment manifests for an application with multiple files and assemblies.  
  
> [!NOTE]
>  In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment.  
  
> [!NOTE]
>  For more information on the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> property used in the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> task in this example, see [SignFile Task](../vs140/signfile-task.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This example uses the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> task to generate a native manifest for application Test.exe, referencing native component Alpha.dll and an isolated COM component Bravo.dll.  
  
 This example produces the Test.exe.manifest, making the application XCOPY deployable taking advantage of Registration Free COM.  
  
> [!NOTE]
>  In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [GenerateDeploymentManifest Task](../vs140/generatedeploymentmanifest-task.md)   
 [SignFile Task](../vs140/signfile-task.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)