---
title: "Generating Files with the TextTransform Utility"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, TextTransform utility"
  - "TextTransform.exe"
ms.assetid: 06a48235-fe02-403e-a1cf-2ae70b4db62f
caps.latest.revision: 45
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generating Files with the TextTransform Utility
TextTransform.exe is a command-line tool that you can use to transform a text template. When you call TextTransform.exe, you specify the name of a text template file as an argument. TextTransform.exe calls the text transformation engine and processes the text template. TextTransform.exe is usually called from scripts. However, it is not usually required, because you can perform text transformation either in Visual Studio or in the build process.  
  
> [!NOTE]
>  If you want to perform text transformation as part of a build process, consider using the MSBuild text transformation task. For more information, see [Code Generation in a Build Process](../vs140/code-generation-in-a-build-process.md). In a machine on which [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] is installed, you can also write an application or [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extension that can transform text templates. For more information, see [Processing Text Templates using a Custom Host](../vs140/processing-text-templates-by-using-a-custom-host.md).  
  
 TextTransform.exe is located in the following directory:  
  
 **\Program Files\Common Files\Microsoft Shared\TextTemplating\11.0**  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|**Argument**|**Description**|  
|------------------|---------------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Identifies the name of the template file that you want to transform.|  
  
|**Option**|**Description**|  
|----------------|---------------------|  
|**-out** \<filename>|The file to which the output of the transform is written.|  
|**-r** \<assembly>|An assembly used for compiling and running the text template.|  
|**-u** \<namespace>|A namespace that is used for compiling the template.|  
|**-I** \<includedirectory>|A directory that contains the text templates included in the specified text template.|  
|**-P** \<referencepath>|A directory to search for assemblies specified within the text template or for using the **-r** option.\<br />\<br /> For example, to include assemblies used for the Visual Studio API, use\<br />\<br /> <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**-dp** \<processorName>!\<className>!\<assemblyName&#124;codeBase>|The name, full type name, and assembly of a directive processor that can be used to process custom directives within the text template.|  
|**-a** [processorName]![directiveName]!\<parameterName>!\<parameterValue>|Specify a parameter value for a directive processor. If you specify just the parameter name and value, the parameter will be available to all directive processors. If you specify a directive processor, the parameter is available only to the specified processor. If you specify a directive name, the parameter is available only when the specified directive is being processed.\<br />\<br /> To access the parameter values from a directive processor or text template, use \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost.ResolveParameterValue*>. In a text template, include <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the template directive and invoke the message on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For example:\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.\<br />\<br /> Always type the '!' marks, even if you omit the optional processor and directive names. For example:\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|**-h**|Provides help.|  
  
## Related topics  
  
|Task|Topic|  
|----------|-----------|  
|Generate files in a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution.|[Generating Text in a Visual Studio Solution](../vs140/design-time-code-generation-by-using-t4-text-templates.md)|  
|Write directive processors to transform your own data sources.|[Customizing Text Transformation](../vs140/customizing-t4-text-transformation.md)|  
|Write a text templating host that allows you to invoke text templates from your own application.|[Creating Custom Text Template Hosts](../vs140/processing-text-templates-by-using-a-custom-host.md)|