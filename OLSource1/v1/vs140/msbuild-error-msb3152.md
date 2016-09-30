---
title: "MSBuild Error MSB3152"
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
  - "MSBuild.GenerateBootstrapper.PackageFileNotFound"
helpviewer_keywords: 
  - "MSB3152"
ms.assetid: 5a3859d4-4107-4e46-bb42-04de92b551de
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3152
**MSB3152: The install location for prerequisites has not been set to 'component vendor's web site' and the file '\<file>' in item '\<package>' can not be located on disk. See Help for more information.**  
  
 This error occurs when a file that is required for the prerequisite installer is missing. The installer files go into a special folder that Visual Studio has reserved for redistributable packages. The folder varies by the version of Visual Studio that you are developing with. For more about the specific folder location, see [Adding Custom Prerequisites](../vs140/creating-bootstrapper-packages.md).  
  
### To correct this error  
  
-   Determine whether the file exists on disk.  
  
-   Use HomeSite to try to resolve the package issue.  
  
-   Set <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the project file.  
  
-   Do not use the broken bootstrapper package.  
  
## See Also  
 [Adding Custom Prerequisites](../vs140/creating-bootstrapper-packages.md)