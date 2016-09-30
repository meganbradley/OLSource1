---
title: "GenerateResource Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#GenerateResource"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, GenerateResource task"
  - "GenerateResource task [MSBuild]"
ms.assetid: c0aff32f-f2cc-46f6-9c3e-a5c9f8f912b1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GenerateResource Task
Converts between .txt and .resx (XML-based resource format) files and common language runtime binary .resources files that can be embedded in a runtime binary executable or compiled into satellite assemblies. This task is typically used to convert .txt or .resx files to .resource files. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> task is functionally similar to [resgen.exe](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4).  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.\<br />\<br /> Contains additional inputs to the dependency checking done by this task. For example, the project and targets files typically should be inputs, so that if they are updated, all resources are regenerated.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies an array of name-value pairs of environment variables that should be passed to the spawned resgen.exe, in addition to (or selectively overriding) the regular environment block.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies an array of items that specify paths from which tracked inputs will be ignored during Up to date checking.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, runs tlbimp.exe and aximp.exe from the appropriate target framework out-of-proc to generate the necessary wrapper assemblies. This parameter allows multi-targeting of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>15\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the names of all files written to disk. This includes the cache file, if any. This parameter is useful for implementations of Clean.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets a switch that specifies whether tracked incremental build will be used. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, incremental build is turned on; otherwise, a rebuild will be forced.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the name of the generated files, such as .resources files. If you do not specify a name, the name of the matching input file is used and the .resources file that is created is placed in the directory that contains the input file.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>22\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the name of the generated files, such as .resources files. If you do not specify a name, the name of the matching input file is used and the .resources file that is created is placed in the directory that contains the input file.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, creates a strongly typed resource class as a public class.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter.\<br />\<br /> References to load types in .resx files from. Resx file data elements may have a .NET type. When the .resx file is read, this must be resolved. Typically, it is resolved successfully by using standard type loading rules. If you provide assemblies in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, they take precedence.\<br />\<br /> This parameter is not required for strongly typed resources.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the path to the SDK tools, such as resgen.exe.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the items to convert. Items passed to this parameter must have one of the following file extensions:\<br />\<br /> -   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>: Specifies the extension for a text file to convert. Text files can only contain string resources.\<br />-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>: Specifies the extension for an XML-based resource file to convert.\<br />-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>: Specifies the same format as .txt. This different extension is useful if you want to clearly distinguish source files that contain resources from other source files in your build process.\<br />-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>: Specifies the extension for a resource file to convert.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the path to an optional cache file that is used to speed up dependency checking of links in .resx input files.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the class name for the strongly typed resource class. If this parameter is not specified, the base name of the resource file is used.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the filename for the source file. If this parameter is not specified, the name of the class is used as the base filename, with the extension dependent on the language. For example: <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the language to use when generating the class source for the strongly typed resource. This parameter must match exactly one of the languages used by the CodeDomProvider. For example: <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.\<br />\<br /> By passing a value to this parameter, you instruct the task to generate strongly typed resources.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the resource namespace or manifest prefix to use in the generated class source for the strongly typed resource.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the namespace to use for the generated class source for the strongly typed resource. If this parameter is not specified, any strongly typed resources are in the global namespace.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>51\</CodeContentPlaceHolder> read-only parameter.\<br />\<br /> Gets an array of items that represent the read tracking logs.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>53\</CodeContentPlaceHolder> read-only parameter.\<br />\<br /> Gets an array of items that represent the write tracking logs.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Optional [String](assetId:///String?qualifyHint=False&autoUpgrade=True) parameter.\<br />\<br /> Used to determine whether or not Tracker.exe needs to be used to spawn ResGen.exe.\<br />\<br /> Should be parsable to a member of the \<xref:Microsoft.Build.Utilities.ExecutableType*> enumeration. If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, uses a heuristic to determine a default architecture. Should be parsable to a member of the Microsoft.Build.Utilities.ExecutableType enumeration.|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the path to the appropriate .NET Framework location that contains FileTracker.dll.\<br />\<br /> If set, the user takes responsibility for making sure that the bitness of the FileTracker.dll that they pass matches the bitness of the ResGen.exe that they intend to use. If not set, the task decides the appropriate location based on the current .NET Framework version.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the intermediate directory into which the tracking logs from running this task will be placed.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the path to the appropriate Windows SDK location that contains Tracker.exe.\<br />\<br /> If set, the user takes responsibility for making sure that the bitness of the Tracker.exe that they pass matches the bitness of the ResGen.exe that they intend to use. If not set, the task decides the appropriate location based on the current Windows SDK.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Optional [Boolean](assetId:///Boolean?qualifyHint=False&autoUpgrade=True) parameter.\<br />\<br /> If true, the directory of the input file is used for resolving relative file paths.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, specifies that the input file's directory is to be used for resolving relative file paths.|  
  
## Remarks  
 Because .resx files may contain links to other resource files, it is not sufficient to simply compare .resx and .resource file timestamps to see if the outputs are up-to-date. Instead, the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> task follows the links in the .resx files and checks the timestamps of the linked files as well. This means that you should not generally use <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> attributes on the target containing the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> task, as this may cause it to be skipped when it should actually run.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
 When using MSBuild 4.0 to target .NET 3.5 projects, the build may fail on x86 resources. To work around this problem, you can build the target as an AnyCPU assembly.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> task to generate .resources files from the files specified by the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> item collection.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> task uses the \<LogicalName> metadata of an \<EmbeddedResource> item to name the resource that is embedded in an assembly.  
  
 Assuming that the assembly is named myAssembly, the following code generates an embedded resource named someQualifier.someResource.resources:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Without the \<LogicalName> metadata, the resource would be named myAssembly.myResource.resources.  This example applies only to the Visual Basic and Visual C# build process.  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)