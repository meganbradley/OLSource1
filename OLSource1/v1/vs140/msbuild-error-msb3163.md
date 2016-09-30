---
title: "MSBuild Error MSB3163"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MSBuild.GenerateBootstrapper.InvalidComponentsLocation"
helpviewer_keywords: 
  - "MSB3163"
ms.assetid: 35c5efbf-2fd7-478c-bb8e-3c4eabb3e4d4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3163
**MSB3163: Build input parameter 'ComponentsLocation='\<ComponentsLocation>'' is not valid. The value must be one of 'HomeSite', 'Relative', or 'Absolute'. Defaulting to 'HomeSite'.**  
  
 This error occurs when the specified value for the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property (the location from which prerequisites are installed) is invalid. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> should be one of three values: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## See Also  
 [\<PackageFiles> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)