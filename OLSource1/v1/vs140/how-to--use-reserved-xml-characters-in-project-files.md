---
title: "How to: Use Reserved XML Characters in Project Files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSBuild, using reserved XML characters"
  - "MSBuild, reserved XML characters"
ms.assetid: 1ae37275-96bf-4e6e-897b-6b048e5bbe93
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Reserved XML Characters in Project Files
When you author project files, you might need to use reserved XML characters, for example, in property values or in task parameter values. However, some reserved characters must be replaced by a named entity so that the project file can be parsed.  
  
## Using Reserved Characters  
 The following table describes the reserved XML characters that must be replaced by the corresponding named entity so that the project file can be parsed.  
  
|Reserved character|Named entity|  
|------------------------|------------------|  
|\<|&lt;|  
|>|&gt;|  
|&|&amp;|  
|"|&quot;|  
|'|&apos;|  
  
#### To use double quotes in a project file  
  
-   Replace the double quotes with the corresponding named entity, &quot;. For example, to place double quotes around the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> item list, type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 In the following code example, double quotes are used to highlight the file name in the message that is output by the project file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild](../vs140/msbuild.md)