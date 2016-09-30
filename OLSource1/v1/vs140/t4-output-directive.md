---
title: "T4 Output Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 03a14993-47ad-4f2e-8032-57db28d5842a
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# T4 Output Directive
In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] text templates, the `output` directive is used to define the file name extension and encoding of the transformed file.  
  
 For example, if your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project includes a template file named **MyTemplate.tt** which contains the following directive:  
  
 `<#@output extension=".cs"#>`  
  
 then [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] will generate a file named **MyTemplate.cs**  
  
 The `output` directive is not required in a run-time (preprocessed) text template. Instead, your application obtains the generated string by calling `TextTransform()`. For more information, see [Preprocessed Text Templates](../vs140/run-time-text-generation-with-t4-text-templates.md).  
  
## Using the Output Directive  
  
```  
<#@ output extension=".fileNameExtension" [encoding="encoding"] #>  
```  
  
 There should be no more than one `output` directive in each text template.  
  
## extension attribute  
 Specifies the file name extension of the generated text output file.  
  
 The default value is **.cs**  
  
 Examples:  
 `<#@ output extension=".txt" #>`  
  
 `<#@ output extension=".htm" #>`  
  
 `<#@ output extension=".cs" #>`  
  
 `<#@ output extension=".vb" #>`  
  
 Acceptable Values:  
 Any valid file name extension.  
  
## encoding attribute  
 Specifies the encoding to use when the output file is generated. For example:  
  
 `<#@ output encoding="utf-8"#>`  
  
 The default value is the encoding used by the text template file.  
  
 Acceptable Values:  
 `us-ascii`  
  
 `utf-16BE`  
  
 `utf-16`  
  
 `utf-8`  
  
 `utf-7`  
  
 `utf-32`  
  
 `0` (System default)  
  
 In general, you can use the WebName string or the CodePage number of any of the encodings returned by \<xref:System.Text.Encoding.GetEncodings*?displayProperty=fullName>.