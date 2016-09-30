---
title: "SGen Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#SGen"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "SGen task [MSBuild]"
  - "MSBuild, SGen task"
ms.assetid: 22c5ade4-4159-4667-b891-0c1aa06f4df5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SGen Task
Creates an XML serialization assembly for types in the specified assembly. This task wraps the XML Serializer Generator Tool (Sgen.exe). For more information, see [XML Serializer Generator Tool (Sgen.exe)](assetId:///cc1d1f1c-fb26-4be9-885a-3fe84c81cec6).  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> The assembly to generate serialization code for.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> The path to the assembly to generate serialization code for.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, specifies that you want a fully signed assembly. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, specifies that you only want to place the public key in the assembly.\<br />\<br /> This parameter has no effect unless used with either the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a container that holds a key pair. This will sign the assembly by inserting a public key into the assembly manifest. The task will then sign the final assembly with the private key.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a key pair or a public key to use to sign an assembly. The compiler inserts the public key in the assembly manifest and then signs the final assembly with the private key.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or Sets the Compiler Platform used to generate the output assembly. This parameter can have a value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Default is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the assemblies that are referenced by the types requiring XML serialization.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the path to the SDK tools, such as resgen.exe.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>26\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the generated serialization assembly.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the name of the generated serialization assembly.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the SGen task should generate a serialization assembly.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, indicating that there is no time out period.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the location from where the task will load the underlying executable file (sgen.exe). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)].|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets a list of specific Types to generate serialization code for. SGen will generate serialization code only for those types.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, the SGen task generates serialization code only for the XML Web service proxy types.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.ToolTaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.ToolTask*> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../vs140/tooltaskextension-base-class.md).  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)