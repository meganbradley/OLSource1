---
title: "SccGetCommandOptions Function"
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
  - "SccGetCommandOptions"
helpviewer_keywords: 
  - "SccGetCommandOptions function"
ms.assetid: bbe4aa4e-b4b0-403e-b7a0-5dd6eb24e5a9
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccGetCommandOptions Function
This function prompts the user for advanced options for a given command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 hWnd  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 iCommand  
 [in] The command for which advanced options are requested (see [Command Code Enumerator](../vs140/command-code-enumerator.md) for possible values).  
  
 ppvOptions  
 [in] The option structure (can also be <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>).  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Success.|  
|SCC_I_ADV_SUPPORT|The source control plug-in supports advanced options for the command.|  
|SCC_I_OPERATIONCANCELED|The user cancelled the source control plug-in's **Options** dialog box.|  
|SCC_E_OPTNOTSUPPORTED|The source control plug-in does not support this operation.|  
|SCC_E_ISCHECKEDOUT|Cannot perform this operation on a file that is currently checked out.|  
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|  
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|  
  
## Remarks  
 The IDE calls this function for the first time with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>=<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to determine if the source control plug-in supports the advanced options feature for the specified command. If the plug-in does support the feature for that command, the IDE calls this function again when the user requests advanced options (usually implemented as an **Advanced** button in a dialog box) and supplies a non-NULL pointer for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that points to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer. The plug-in stores any advanced options specified by the user in a private structure and returns a pointer to that structure in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This structure is then passed to all other Source Control Plug-in API functions that need to know about it, including subsequent calls to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function.  
  
 An example may help clarify this situation.  
  
 A user chooses the **Get** command and the IDE displays a **Get** dialog box. The IDE calls the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This is interpreted by the source control plug-in as the question, "Do you have any advanced options for this command?" If the plug-in returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the IDE displays an **Advanced** button in its **Get** dialog box.  
  
 The first time the user clicks the **Advanced** button, the IDE again calls the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function, this time with a non-<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that points to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pointer. The plug-in displays its own **Get Options** dialog box, prompts the user for information, puts that information into its own structure, and returns a pointer to that structure in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 If the user clicks **Advanced** again in the same dialog box, the IDE calls the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function again without changing <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, so that the structure is passed back to the plug-in. This enables the plug-in to reinitialize its dialog box to the values that the user had previously set. The plug-in modifies the structure in place before returning.  
  
 Finally, when the user clicks **OK** in the IDE's **Get** dialog box, the IDE calls the [SccGet Function](../vs140/sccget-function.md), passing the structure returned in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that contains the advanced options.  
  
> [!NOTE]
>  The command <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is used when the IDE displays an **Options** dialog box that lets the user set preferences that control how the integration works. If the source control plug-in wants to supply its own preferences dialog box, it can display it from an **Advanced** button in the IDE's preferences dialog box. The plug-in is solely responsible for getting and persisting this information; the IDE does not use it or modify it.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [Command Code Enumerator](../vs140/command-code-enumerator.md)