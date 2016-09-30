---
title: "GetWinFXPath Task"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "getting the directory of the current .NET Framework runtime [WPF MSBuild]"
  - "GetWinFXPath task [WPF MSBuild], parameters"
  - "GetWinFXPath task [WPF MSBuild]"
  - "obtaining the path to the current .NET Framework runtime [WPF MSBuild]"
ms.assetid: b1dfb467-f3d3-47f3-83ef-af7b0e33a772
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetWinFXPath Task
The \<xref:Microsoft.Build.Tasks.Windows.GetWinFXPath*> task returns the directory of the current [!INCLUDE[TLA#tla_winfx](../vs140/includes/tlasharptla_winfx_md.md)] runtime.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional **String** output parameter.\<br />\<br /> Specifies the real path to the [!INCLUDE[TLA2#tla_winfx](../vs140/includes/tla2sharptla_winfx_md.md)] runtime.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required **String** parameter.\<br />\<br /> Specifies the path to the native [!INCLUDE[TLA2#tla_titlewinfx](../vs140/includes/tla2sharptla_titlewinfx_md.md)] runtime.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required **String** parameter.\<br />\<br /> Specifies the path to the [!INCLUDE[TLA#tla_winfx](../vs140/includes/tlasharptla_winfx_md.md)] assemblies in the 32-bit **Windows on Windows** module on 64-bit systems.|  
  
## Remarks  
 If the \<xref:Microsoft.Build.Tasks.Windows.GetWinFXPath*> task is executing on a 64-bit processor, the **WinFXPath** parameter is set to the path that is stored in the **WinFXWowPath** parameter; otherwise, the **WinFXPath** parameter is set to the path that is stored in the **WinFXNativePath** parameter.  
  
## Example  
 The following example shows how to use the **GetWinFXPath** task to detect the native path to the [!INCLUDE[TLA2#tla_titlewinfx](../vs140/includes/tla2sharptla_titlewinfx_md.md)] runtime.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [WPF MSBuild Reference](../vs140/wpf-msbuild-reference.md)   
 [WPF MSBuild Task Reference](../vs140/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](assetId:///a58696fd-bdad-4b55-9759-136dfdf8b91c)