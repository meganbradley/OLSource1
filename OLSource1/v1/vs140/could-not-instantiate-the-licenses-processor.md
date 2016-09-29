---
title: "Could not instantiate the licenses processor"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.tasklisterror.no_licx_generator"
ms.assetid: 9e95d590-f41f-4cfa-bc73-fadeacfdb879
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Could not instantiate the licenses processor
The tool used to transform .licx files into binary resources could not be instantiated.  
  
 As part of compilation, the project system will transform a text .licx file into a binary resource that provides support for .NET control licensing. The binary resource will then be embedded in the project output.  
  
 The build process will fail if this error occurs.  
  
 The .licx file is automatically generated or updated by the Windows Forms Designer whenever a licensed control is added to the form. There is one .licx file per project; it is always in the root folder and is always named Licenses.licx.  
  
 **To correct this error**  
  
-   Reinstall [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## See Also  
 [Licensing Components and Controls](assetId:///8e66c1ed-a445-4b26-8185-990b6e2bbd57)