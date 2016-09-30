---
title: "Optional Comparison of Local Project Folder to Source Control Store"
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
  - "source control plug-ins, comparing versions"
  - "source control plug-ins, local project folders"
ms.assetid: 65217e8b-15a6-4446-92b0-4cff1c6220f5
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Optional Comparison of Local Project Folder to Source Control Store
In Source control Plug-in API 1.2 the comparison between the local project folder and source control is accomplished by using the functions [SccDirQueryInfo Function](../vs140/sccdirqueryinfo-function.md) and [SccDirDiff Function](../vs140/sccdirdiff-function.md).  
  
 Within **Solution Explorer**, if a folder is selected instead of an individual file, the **Compare versions** shortcut menu invokes the new [SccDirQueryInfo Function](../vs140/sccdirqueryinfo-function.md) and [SccDirDiff Function](../vs140/sccdirdiff-function.md) in the source control plug-in.  
  
## New Capability Flags  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
## New Functions  
 [SccDirDiff Function](../vs140/sccdirdiff-function.md)  
  
 [SccDirQueryInfo Function](../vs140/sccdirqueryinfo-function.md)  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function is called before <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to determine if the working directory is source-controlled. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function displays the differences between the current local directory and the corresponding source control folder. This command asks the source control plug-in to display the list of changes to the directory. A source control plug-in provides its own UI to display the differences.  
  
> [!NOTE]
>  This function uses the same command flags as [SccDiff Function](../vs140/sccdiff-function.md). As a source control plug-in provider, you may choose to not support the "quick diff" operation for directories.  
  
## See Also  
 [What's New in the Source Control Plug-in API Version 1.2](../vs140/what-s-new-in-the-source-control-plug-in-api-version-1.2.md)