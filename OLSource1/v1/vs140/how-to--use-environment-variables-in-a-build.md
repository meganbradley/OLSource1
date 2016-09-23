---
title: "How to: Use Environment Variables in a Build"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - environment variables, referencing
  - projects [.NET Framework], environment variables
  - MSBuild, environment variables
ms.assetid: 7f9e4469-8865-4b59-aab3-3ff26bd36e77
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Use Environment Variables in a Build
When you build projects, it is often necessary to set build options using information that is not in the project file or the files that comprise your project. This information is typically stored in environment variables.  
  
## Referencing Environment Variables  
 All environment variables are available to the [!INCLUDE[vstecmsbuildengine](../vs140/includes/vstecmsbuildengine_md.md)] ([!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]) project file as properties.  
  
> [!NOTE]
>  If the project file contains an explicit definition of a property that has the same name as an environment variable, the property in the project file overrides the value of the environment variable.  
  
#### To use an environment variable in an MSBuild project  
  
-   Reference the environment variable the same way you would a variable declared in your project file. For example, the following code references the BIN_PATH environment variable:  
  
     `<FinalOutput>$(BIN_PATH)\MyAssembly.dll</FinalOutput>`  
  
 You can use a `Condition` attribute to provide a default value for a property if the environment variable was not set.  
  
#### To provide a default value for a property  
  
-   Use a `Condition` attribute on a property to set the value only if the property has no value. For example, the following code sets the `ToolsPath` property to c:\tools only if the `ToolsPath` environment variable is not set:  
  
     `<ToolsPath Condition="'$(TOOLSPATH)' == ''">c:\tools</ToolsPath>`  
  
    > [!NOTE]
    >  Property names are not case-sensitive so both `$(ToolsPath)` and `$(TOOLSPATH)` reference the same property or environment variable.  
  
## Example  
 The following project file uses environment variables to specify the location of directories.  
  
```  
<Project DefaultTargets="FakeBuild">  
    <PropertyGroup>  
        <FinalOutput>$(BIN_PATH)\myassembly.dll</FinalOutput>  
        <ToolsPath Condition=" '$(ToolsPath)' == '' ">  
            C:\Tools  
        </ToolsPath>  
    </PropertyGroup>  
    <Target Name="FakeBuild">  
        <Message Text="Building $(FinalOutput) using the tools at $(ToolsPath)..."/>  
    </Target>  
</Project>  
```  
  
## See Also  
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Properties](../vs140/msbuild-properties.md)   
 [How To: Build the Same Source Files with Different Options](../vs140/how-to--build-the-same-source-files-with-different-options.md)