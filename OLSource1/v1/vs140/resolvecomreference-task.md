---
title: "ResolveComReference Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#ResolveComReference"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, ResolveCOMReference task"
  - "ResolveCOMReference task [MSBuild]"
ms.assetid: c9bf5fcf-6453-40ea-b50f-a212adc3e9b5
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ResolveComReference Task
Takes a list of one or more type library names or .tlb files and resolves those type libraries to locations on disk.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, places the public key in the assembly. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, fully signs the assembly.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Array of pairs of environment variables, separated by equal signs. These variables are passed to the spawned tlbimp.exe and aximp.exe in addition to, or selectively overriding, the regular environment block..|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, runs tlbimp.exe and aximp.exe from the appropriate target framework out-of-proc to generate the necessary wrapper assemblies. This parameter enables multi-targeting.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the typelib version will be included in the wrapper name. The default is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a container that holds a public/private\<br />\<br /> key pair.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies an item that contains a public/private\<br />\<br /> key pair.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>parameter.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>21\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the resolved assembly references.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>23\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the fully qualified files on disk that correspond to the physical locations of the type libraries that were provided as input to this task.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>25\</CodeContentPlaceHolder>parameter.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional [String](assetId:///String?qualifyHint=False&autoUpgrade=True) parameter.\<br />\<br /> If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, this parameter must be set to the SDK tools path for the framework version being targeted.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the cache file for COM component timestamps. If not present, every run will regenerate all the wrappers.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the project target framework version.\<br />\<br /> The default is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. which means there is no filtering for a reference based on the target framework.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Optional assetId:///String?qualifyHint=False&autoUpgrade=True parameter.\<br />\<br /> Specifies the preferred target processor architecture. Passed to the tlbimp.exe /machine flag after translation.\<br />\<br /> The parameter value should be a member of \<xref:Microsoft.Build.Utilities.ProcessorArchitecture*>.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the type library file path to COM references. Items included in this parameter may contain item metadata. For more information, see the section "TypeLibFiles Item Metadata" below.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the type library names to resolve. Items included in this parameter must contain some item metadata. For more information, see the section "TypeLibNames Item Metadata" below.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter.\<br />\<br /> The location on disk where the generated interop assembly is placed. If this item metadata is not specified, the task uses the absolute path of the directory where the project file is located.|  
  
## Remarks  
  
## TypeLibNames Item Metadata  
 The following table describes the item metadata available for items passed to the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter.  
  
|Metadata|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Required item metadata.\<br />\<br /> The GUID for the type library. If this item metadata is not specified , the task fails.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Required item metadata.\<br />\<br /> The major version of the type library. If this item metadata is not specified , the task fails.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Required item metadata.\<br />\<br /> The minor version of the type library. If this item metadata is not specified, the task fails.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Optional item metadata.\<br />\<br /> The Locale Identifier (or LCID) for the type library. This is specified as a 32-bit value that identifies the human language preferred by a user, region, or application. If this item metadata is not specified, the task uses a default locale identifier of "0".|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Optional item metadata.\<br />\<br /> Specifies the wrapper tool that is used to generate the assembly wrapper for this type library. If this item metadata is not specified, the task uses a default wrapper tool of "tlbimp". The available, case insensitive choices of typelibs are:\<br />\<br /> -   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>: Use this wrapper tool when you want to use an already generated primary interop assembly for the COM component. When you use this wrapper tool, do not specify a wrapper output directory because that will cause the task to fail.\<br />-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>: Use this wrapper tool when you want to generate an interop assembly for the COM component.\<br />-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>:Use this wrapper tool when you want to generate an interop assembly for an ActiveX Control.|  
  
## TypeLibFiles Item Metadata  
 The following table describes the item metadata available for items passed to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter.  
  
|Metadata|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Optional item metadata.\<br />\<br /> Specifies the wrapper tool that is used to generate the assembly wrapper for this type library. If this item metadata is not specified, the task uses a default wrapper tool of "tlbimp". The available, case insensitive choices of typelibs are:\<br />\<br /> -   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>: Use this wrapper tool when you want to use an already generated primary interop assembly for the COM component. When you use this wrapper tool, do not specify a wrapper output directory because that will cause the task to fail.\<br />-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>: Use this wrapper tool when you want to generate an interop assembly for the COM component.\<br />-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>: Use this wrapper tool when you want to generate an interop assembly for an ActiveX Control.|  
  
> [!NOTE]
>  The more information that you provide to uniquely identify a type library, the greater the possibility that the task will resolve to the correct file on disk.  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [Task Base Class](../vs140/task-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)