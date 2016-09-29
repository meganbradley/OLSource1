---
title: "XDCMake Task"
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
  - "vc.task.xdcmake"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords: 
  - "XDCMake task (MSBuild (Visual C++))"
  - "MSBuild (Visual C++), XDCMake task"
ms.assetid: a7de9c64-903a-4a02-85f3-f37672270f25
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XDCMake Task
Wraps the XML Documentation tool (xdcmake.exe), which merges XML document comment (.xdc) files into an .xml file.  
  
 An .xdc file is created when you provide documentation comments in your Visual C++ source code and compile by using the [/doc](../VS_csharp/-doc--process-documentation-comments---c-c---.md) compiler option. For more information, see [XDCMake Reference](../VS_csharp/xdcmake-reference.md), [XML Document Generator Tool Property Pages](../VS_csharp/xml-document-generator-tool-property-pages.md), and command-line help option (**/?**) for xdcmake.exe.  
  
## Remarks  
 By default, the xdcmake.exe tool supports a few command-line options. Additional options are supported when you specify the **/old** command-line option.  
  
## Parameters  
 The following table describes the parameters of the **XDCMake** task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**AdditionalDocumentFile**|Optional **String[]** parameter.<br /><br /> Specifies one or more additional .xdc files to merge.<br /><br /> For more information, see the **Additional Document Files** description in [XML Document Generator Tool Property Pages](../VS_csharp/xml-document-generator-tool-property-pages.md). Also see the **/old** and **/Fs** command-line options for xdcmake.exe.|  
|**AdditionalOptions**|Optional **String** parameter.<br /><br /> A list of options as specified on the command line. For example, "*/option1 /option2 /option#*". Use this parameter to specify options that are not represented by any other **XDCMake** task parameter.<br /><br /> For more information, see [XDCMake Reference](../VS_csharp/xdcmake-reference.md), [XML Document Generator Tool Property Pages](../VS_csharp/xml-document-generator-tool-property-pages.md), and command-line help (**/?**) for xdcmake.exe.|  
|**DocumentLibraryDependencies**|Optional **Boolean** parameter.<br /><br /> If `true` and the current project has a dependency on a static library (.lib) project in the solution, the .xdc files for that library project are included in the .xml file output for the current project.<br /><br /> For more information, see the **Document Library Dependencies** description in [XML Document Generator Tool Property Pages](../VS_csharp/xml-document-generator-tool-property-pages.md).|  
|**OutputFile**|Optional **String** parameter.<br /><br /> Overrides the default output file name. The default name is derived from the name of the first .xdc file that is processed.<br /><br /> For more information, see the **/out:**`filename` option in [XDCMake Reference](../VS_csharp/xdcmake-reference.md). Also see the **/old** and **/Fo** command-line options for xdcmake.exe.|  
|**ProjectName**|Optional **String** parameter.<br /><br /> The name of the current project.|  
|**SlashOld**|Optional **Boolean** parameter.<br /><br /> If `true`, enables additional xdcmake.exe options.<br /><br /> For more information, see the **/old** command-line option for xdcmake.exe.|  
|**Sources**|Required `ITaskItem[]` parameter.<br /><br /> Defines an array of MSBuild source file items that can be consumed and emitted by tasks.|  
|**SuppressStartupBanner**|Optional **Boolean** parameter.<br /><br /> If `true`, prevents the display of the copyright and version number message when the task starts.<br /><br /> For more information, see the **/nologo** option in [XDCMake Reference](../VS_csharp/xdcmake-reference.md).|  
|**TrackerLogDirectory**|Optional **String** parameter.<br /><br /> Specifies the directory for the tracker log.|  
  
## See Also  
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)