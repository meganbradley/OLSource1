---
title: "SccAddFromScc Function"
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
  - "SccAddFromScc"
helpviewer_keywords: 
  - "SccAddFromScc function"
ms.assetid: 902e764d-200e-46e1-8c42-4da7b037f9a0
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccAddFromScc Function
This function allows the user to browse for files that are already in the source control system and subsequently make those files part of the current project. For example, this function can get a common header file into the current project without copying the file. The return array of files, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, contains the list of files that the user wants to add to the IDE project.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 hWnd  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 lpnFiles  
 [in, out] A buffer for the number of files that are being added in. (This is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the memory pointed to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is to be released. See Remarks for details.)  
  
 lplpFileNames  
 [in, out] An array of pointers to all the file names without directory paths. This array is allocated and freed by the source control plug-in. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = 1 and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the first name in the array pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> contains the destination folder.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The files were successfully located and added to the project.|  
|SCC_I_OPERATIONCANCELED|Operation was canceled with no effect.|  
|SCC_I_RELOADFILE|A file or project needs to be reloaded.|  
  
## Remarks  
 The IDE calls this function. If the source control plug-in supports specifying a local destination folder, the IDE passes <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = 1 and passes the local folder name into <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 When the call to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function returns, the plug-in has assigned values to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, allocating the memory for the file name array as necessary (note that this allocation replaces the pointer in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). The source control plug-in is responsible for placing all files into the user's directory or in the specified designation folder. The IDE then adds the files to the IDE project.  
  
 Finally, the IDE calls this function a second time, passing in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. This is interpreted as a special signal by the source control plug-in to release the memory allocated for the file-name array in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> pointer. The source control plug-in places a pointer to an array of pointers to file names, thus passing the list in the standard way for this API.  
  
> [!NOTE]
>  Initial versions of the VSSCI API did not provide a way to indicate the target project for the added files. To accommodate this, the semantics of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter have been enhanced to make it an in/out parameter rather than an output parameter. If only a single file is specified, that is, the value pointed to by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> = 1, then the first element of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> contains the target folder. To use these new semantics, the IDE calls the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>parameter set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If a source control plug-in does not support the semantics, it returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Doing so disables the use of the **Add from Source Control** feature. If a plug-in supports the **Add from Source Control** feature (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>), then it must support the new semantics and return <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccSetOption Function](../vs140/sccsetoption-function.md)