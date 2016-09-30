---
title: "SccPopulateList Function"
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
  - "SccPopulateList"
helpviewer_keywords: 
  - "SccPopulateList function"
ms.assetid: 7416e781-c571-4a7f-8af3-a089ce8be662
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccPopulateList Function
This function updates a list of files for a particular source control command and supplies source control status on all given files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 nCommand  
 [in] The source control command that will be applied to all files in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> array (see [Command Code Enumerator](../vs140/command-code-enumerator.md) for a list of possible commands).  
  
 nFiles  
 [in] Number of files in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array.  
  
 lpFileNames  
 [in] An array of file names known to the IDE.  
  
 pfnPopulate  
 [in] The IDE callback function to call to add and remove files (see [POPLISTFUNC](../vs140/poplistfunc.md) for details).  
  
 pvCallerData  
 [in] Value that is to be passed unchanged to the callback function.  
  
 lpStatus  
 [in, out] An array for the source control plug-in to return the status flags for each file.  
  
 fOptions  
 [in] Command flags (see the "PopulateList flag" section of [Bitflags Used by Specific Commands](../vs140/bitflags-used-by-specific-commands.md) for details).  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Success.|  
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|  
  
## Remarks  
 This function examines the list of files for its current status. It uses the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> callback function to notify the caller when a file does not match the criteria for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For example, if the command is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and a file in the list is not checked out, then the callback is used to inform the caller. Occasionally, the source control plug-in may find other files that could be part of the command and add them. This allows, for example, a Visual Basic user to check out a .bmp file that is used by his or her project but does not appear in the Visual Basic project file. A user chooses the **Get** command in the IDE. The IDE will display a list of all files that it thinks the user can get, but before the list is shown, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function is called to make sure the list to be displayed is up to date.  
  
## Example  
 The IDE builds a list of files that it thinks the user can get. Before it displays this list, it calls the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function, giving the source control plug-in the opportunity to add and delete files from the list. The plug-in modifies the list by calling the given callback function (see [Building File Lists Using POPLISTFUNC Function](../vs140/poplistfunc.md) for more details).  
  
 The plug-in continues to call the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function, which adds and deletes files, until it is finished and then returns from the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function. The IDE can then display its list. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> array represents all files in the original list passed in by the IDE. The plug-in fills in the status of all these files in addition to making use of the callback function.  
  
> [!NOTE]
>  A source control plug-in always has the option to simply return immediately from this function, leaving the list as it is. If a plug-in implements this function, it can indicate this by setting the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> capability bitflag in the first call to the [SccInitialize Function](../vs140/sccinitialize-function.md). By default, the plug-in should always assume that all items being passed in are files. However, if the IDE sets the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> flag in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter, all the items being passed in are to be considered directories. The plug-in should add all the files that belong in the directories. The IDE will never pass in a mixture of files and directories.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccInitialize Function](../vs140/sccinitialize-function.md)   
 [POPLISTFUNC](../vs140/poplistfunc.md)   
 [Bitflags Used by Specific Commands](../vs140/bitflags-used-by-specific-commands.md)   
 [Command Code Enumerator](../vs140/command-code-enumerator.md)