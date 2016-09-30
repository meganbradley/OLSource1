---
title: "POPLISTFUNC"
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
  - "POPDIRLISTFUNC"
helpviewer_keywords: 
  - "POPLISTFUNC callback function"
ms.assetid: b2199fd5-d707-4628-92dd-e2a01e2f507a
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# POPLISTFUNC
This callback is supplied to the [SccPopulateList Function](../vs140/sccpopulatelist-function.md) by the IDE and is used by the source control plug-in to update a list of files or directories (also supplied to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function).  
  
 When a user chooses the **Get** command in the IDE, the IDE displays a list box of all files that the user can get. Unfortunately, the IDE does not know the exact list of all the files that the user might get; only the plug-in has this list. If other users have added files to the source code control project, these files should appear in the list, but the IDE does not know about them. The IDE builds a list of the files that it thinks the user can get. Before it displays this list to the user, it calls the [SccPopulateList Function](../vs140/sccpopulatelist-function.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> giving the source control plug-in a chance to add and delete files from the list.  
  
## Signature  
 The source control plug-in modifies the list by calling an IDE-implemented function with the following prototype:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parameters  
 pvCallerData  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter passed by the caller (the IDE) to the [SccPopulateList Function](../vs140/sccpopulatelist-function.md). The source control plug-in should assume nothing about the contents of this parameter.  
  
 fAddRemove  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a file that should be added to the file list. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a file that should be deleted from the file list.  
  
 nStatus  
 Status of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (a combination of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bits; see [File Status Code Enumerator](../vs140/file-status-code-enumerator.md) for details).  
  
 lpFileName  
 Full directory path of the file name to add or delete from the list.  
  
## Return Value  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The plug-in can continue calling this function.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|There has been a problem on the IDE side (such as an out of memory situation). The plug-in should stop operation.|  
  
## Remarks  
 For each file that the source control plug-in wants to add to or delete from the file list, it calls this function, passing in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> flag indicates a new file to add to the list or an old file to delete. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter gives the status of the file. When the SCC plug-in has finished adding and deleting files, it returns from the [SccPopulateList Function](../vs140/sccpopulatelist-function.md) call.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> capability bit is required for Visual Studio.  
  
## See Also  
 [Callback Functions Implemented by the IDE](../vs140/callback-functions-implemented-by-the-ide.md)   
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)   
 [SccPopulateList Function](../vs140/sccpopulatelist-function.md)   
 [File Status Code Enumerator](../vs140/file-status-code-enumerator.md)