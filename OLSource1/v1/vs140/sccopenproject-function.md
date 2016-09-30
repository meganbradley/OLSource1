---
title: "SccOpenProject Function"
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
  - "SccOpenProject"
helpviewer_keywords: 
  - "SccOpenProject function"
ms.assetid: d609510b-660a-46d7-b93d-2406df20434d
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccOpenProject Function
This function opens an existing source control project or creates a new one.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 hWnd  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 lpUser  
 [in, out] The name of the user (not to exceed SCC_USER_SIZE, including the NULL terminator).  
  
 lpProjName  
 [in] The string identifying the name of the project.  
  
 lpLocalProjPath  
 [in] The path to the working folder for the project.  
  
 lpAuxProjPath  
 [in, out]An optional auxiliary string identifying the project (not to exceed SCC_AUXPATH_SIZE, including the NULL terminator).  
  
 lpComment  
 [in] Comment to a new project that is being created.  
  
 lpTextOutProc  
 [in] An optional callback function to display text output from the source control plug-in.  
  
 dwFlags  
 [in] Signals whether a new project needs to be created if the project is unknown to the source control plug-in. Value can be a combination of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Success in opening the project.|  
|SCC_E_INITIALIZEFAILED|Project could not be initialized.|  
|SCC_E_INVALIDUSER|The user could not log in to the source control system.|  
|SCC_E_COULDNOTCREATEPROJECT|The project did not exist prior to the call;  the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag was set, but the project could not be created.|  
|SCC_E_PROJSYNTAXERR|Invalid project syntax.|  
|SCC_E_UNKNOWNPROJECT|The project is unknown to the source control plug-in, and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flag was not set.|  
|SCC_E_INVALIDFILEPATH|Invalid or unusable file path.|  
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|  
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|  
|SCC_E_NONSPECFICERROR|A nonspecific failure; the source control system was not initialized.|  
  
## Remarks  
 The IDE may pass in a user name (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), or it may simply pass in a pointer to an empty string. If there is a user name, the source control plug-in should use it as a default. However, if no name was passed, or if the login failed with the given name, the plug-in should prompt the user to log in and will return the valid name in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when it receives a valid login<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Because the plug-in may change the user name string, the IDE will always allocate a buffer of size (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>+1 or SCC_USER_SIZE, which includes space for the null terminator).  
  
> [!NOTE]
>  The first action the IDE may be required to perform may be a call to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function or the [SccGetProjPath Function](../vs140/sccgetprojpath-function.md). For this reason, both of them have an identical <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are read from the solution file, or they are returned from a call to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function. These parameters contain the strings that the source control plug-in associates with the project and are meaningful only to the plug-in. If no such strings are in the solution file and the user has not been prompted to browse (which would return a string through the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function), the IDE passes empty strings for both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and expects these values to be updated by the plug-in when this function returns.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a pointer to a callback function provided by the IDE to the source control plug-in for the purpose of displaying command result output. This callback function is described in detail in [Displaying Output by Using the LPTEXTOUTPROC Function](../vs140/lptextoutproc.md).  
  
> [!NOTE]
>  If the source control plug-in intends to take advantage of this, it must have set the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> flag in the [SccInitialize Function](../vs140/sccinitialize-function.md). If that flag was not set, or if the IDE does not support this feature, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> will be <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter controls the outcome in the event that the project being opened does not currently exist. It consists of two bitflags, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. If the project being opened already exists, the function simply opens the project and returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If the project does not exist and if the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> flag is on, the source control plug-in can create the project in the source control system, open it, and return <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If the project does not exist, and if the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> flag is off, the plug-in should then check for the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> flag. If that flag is not on, the plug-in may prompt the user for a project name. If that flag is on, the plug-in should simply return <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Calling Order  
 In the normal course of events, the [SccInitialize Function](../vs140/sccinitialize-function.md) would be called first to open a source control session. A session may consist of a call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, followed by other Source Control Plug-in API function calls, and will terminate with a call to the [SccCloseProject Function](../vs140/scccloseproject-function.md). Such sessions may be repeated several times before the [SccUninitialize Function](../vs140/sccuninitialize-function.md) is called.  
  
 If the source control plug-in sets the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> bit in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, then the above session sequence may be repeated many times in parallel. Different <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> structures track the different sessions, in which each <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is associated with one open project at a time. Based on the<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> parameter, the plug-in can determine which project is referenced in any particular call. If the capability bit <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is not set, nonreentrant source control plug-ins are limited in their ability to work with multiple projects.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> bit was introduced in version 1.1 of the Source Control Plug-in API. It is not set or is ignored in version 1.0, and all version 1.0 source control plug-ins are assumed to be nonreentrant.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccCloseProject Function](../vs140/scccloseproject-function.md)   
 [SccGetProjPath Function](../vs140/sccgetprojpath-function.md)   
 [SccInitialize Function](../vs140/sccinitialize-function.md)   
 [SccUninitialize Function](../vs140/sccuninitialize-function.md)   
 [Restrictions on String Lengths](../vs140/restrictions-on-string-lengths.md)   
 [LPTEXTOUTPROC](../vs140/lptextoutproc.md)