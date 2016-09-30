---
title: "SccSetOption Function"
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
  - "SccSetOption"
helpviewer_keywords: 
  - "SccSetOption function"
ms.assetid: 4b5e6666-c24c-438a-a9df-9c52f58f8175
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccSetOption Function
This function sets options that control the behavior of the source control plug-in.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 nOption  
 [in] The option that is being set.  
  
 dwVal  
 [in] Settings for the option.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The option was successfully set.|  
|SCC_I_SHARESUBPROJOK|Returned if <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> was <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and the source control plug-in allows the IDE to set the destination folder.|  
|SCC_E_OPNOTSUPPORTED|The option was not set and should not be relied upon.|  
  
## Remarks  
 The IDE calls this function to control the behavior of the source control plug-in. The first parameter, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, indicates the value that is being set, while the second, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, indicates what to do with that value. The plug-in stores this information associated with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> so the IDE must call this function after calling the [SccInitialize Function](../vs140/sccinitialize-function.md) (but not necessarily after each call to the [SccOpenProject Function](../vs140/sccopenproject-function.md)).  
  
 Summary of the options and their values:  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Description|  
|---------------|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Enables/disables background event queuing.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Arbitrary value|Specifies a user value to be passed to the [OPTNAMECHANGEPFN](../vs140/optnamechangepfn.md) callback function.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Indicates whether the IDE currently supports canceling an operation.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Pointer to the [OPTNAMECHANGEPFN](../vs140/optnamechangepfn.md) callback function|Sets a pointer to a name-change callback function.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Indicates whether the IDE allows the checking out of its files manually (through the source control user interface) or whether they must be checked out only through the source control plug-in.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|N/A|If the source control plug-in allows the IDE to specify the local project folder, the plug-in returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
  
## SCC_OPT_EVENTQUEUE  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the IDE is disabling (or re-enabling) background processing. For instance, during a compile, the IDE might instruct the source control plug-in to stop on-idle processing of any kind. After the compile, it would re-enable background processing to keep the plug-in's event queue up to date. Corresponding to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, there are two possible values for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, namely, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## SCC_OPT_HASCANCELMODE  
 If the value for <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the IDE allows users to cancel long operations. Setting <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> (the default) indicates that the IDE has no cancel mode. The source control plug-in must offer its own Cancel button if it wants the user to be able to cancel. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> indicates that the IDE provides the ability to cancel an operation, so the SCC plug-in does not need to display its own Cancel button. If the IDE sets <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, it is prepared to respond to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> messages sent to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> callback function (see [Displaying Output by Using the LPTEXTOUTPROC Function](../vs140/lptextoutproc.md)). If the IDE does not set this variable, the plug-in should not send these two messages.  
  
## SCC_OPT_NAMECHANGEPFN  
 If nOption is set to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and both the source control plug-in and the IDE allow it, the plug-in can actually rename or move a file during a source control operation. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> will be set to a function pointer of type [OPTNAMECHANGEPFN](../vs140/optnamechangepfn.md). During a source control operation, the plug-in can call this function, passing in three parameters. These are the old name (with fully qualified path) of a file, the new name (with fully qualified path) of that file, and a pointer to information that has relevance to the IDE. The IDE sends in this last pointer by calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, with <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> pointing to the data. Support for this function is optional. A VSSCI plug-that uses this ability must initialize its function pointer and user data variables to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, and it must not call a rename function unless it has been given one. It should also be prepared to hold the value it was given or to change it in response to a new call to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. This will not happen in the middle of a source control command operation, but it may happen between commands.  
  
## SCC_OPT_SCCCHECKOUTONLY  
 If nOption is set to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, the IDE is indicating that the files in the currently open project should never be checked out manually through the source control system's user interface. Instead, the files should be checked out only through the source control plug-in under IDE control. If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, it means that the files should be treated normally by the plug-in and can be checked out through the source control UI. If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, then only the plug-in is allowed to check out files, and the source control system's UI should not be invoked. This is for situations where the IDE might have "pseudo-files" that make sense to check out only through the IDE.  
  
## SCC_OPT_SHARESUBPROJ  
 If<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, the IDE is testing whether the source control plug-in can use a specified local folder when adding files from source control. The value of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameter does not matter in this case. If the plug-in allows the IDE to specify the local destination folder where the files will be added from source control when the [SccAddFromScc Function](../vs140/sccaddfromscc-function.md) is called, then the plug-in must return <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> when the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> function is called. The IDE then uses the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> function to pass in the destination folder. The plug-in uses that destination folder to place the files added from source control. If the plug-in does not return <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> when the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> option is set, the IDE assumes that the plug-in is able to add files only in the current local folder.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccInitialize Function](../vs140/sccinitialize-function.md)   
 [SccOpenProject Function](../vs140/sccopenproject-function.md)   
 [SccAddFromScc Function](../vs140/sccaddfromscc-function.md)   
 [LPTEXTOUTPROC](../vs140/lptextoutproc.md)   
 [OPTNAMECHANGEPFN](../vs140/optnamechangepfn.md)