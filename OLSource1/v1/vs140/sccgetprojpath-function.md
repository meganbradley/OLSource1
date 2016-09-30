---
title: "SccGetProjPath Function"
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
  - "SccGetProjPath"
helpviewer_keywords: 
  - "SccGetProjPath function"
ms.assetid: 1079847e-d45f-4cb8-9d92-1e01ce5d08f6
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccGetProjPath Function
This function prompts the user for a project path, which is a string that is meaningful only to the source control plug-in. It is called when the user is:  
  
-   Creating a new project  
  
-   Adding an existing project to version control  
  
-   Attempting to find an existing version control project  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 hWnd  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 lpUser  
 [in, out] The user name (not to exceed SCC_USER_SIZE, including the NULL terminator)  
  
 lpProjName  
 [in, out] The name of the IDE project, project workspace, or makefile (not to exceed SCC_PRJPATH_SIZE, including the NULL terminator).  
  
 lpLocalPath  
 [in, out] The project's working path. If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the source control plug-in can modify this string (not to exceed _MAX_PATH, including the null-terminator).  
  
 lpAuxProjPath  
 [in, out] A buffer for the returned project path (not to exceed SCC_PRJPATH_SIZE, including the NULL terminator).  
  
 bAllowChangePath  
 [in] If this is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the source control plug-in can prompt for and modify the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> string.  
  
 pbNew  
 [in, out] Value coming in indicates whether to create a new project. Value returned indicates success of creating a project:  
  
|Incoming|Interpretation|  
|--------------|--------------------|  
|TRUE|The user may create a new project.|  
|FALSE|The user may not create a new project.|  
  
|Outgoing|Interpretation|  
|--------------|--------------------|  
|TRUE|A new project was created.|  
|FALSE|An existing project was selected.|  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The project was successfully created or retrieved.|  
|SCC_I_OPERATIONCANCELED|The operation was canceled.|  
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|  
|SCC_E_CONNECTIONFAILURE|There was a problem trying to connect to the source control system.|  
|SCC_E_NONSPECIFICERROR|An unspecified error occurred.|  
  
## Remarks  
 The purpose of this function is for the IDE to acquire the parameters <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. After the source control plug-in prompts the user for this information, it passes these two strings back to the IDE. The IDE persists these strings in its solution file and passes them to the [SccOpenProject Function](../vs140/sccopenproject-function.md) whenever the user opens this project. These strings enable the plug-in to track information associated with a project.  
  
 When the function is first called, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to an empty string. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> may also be empty, or it may contain the IDE project name, which the source control plug-in may use or ignore. When the function successfully returns, the plug-in returns the two corresponding strings. The IDE makes no assumptions about these strings, will not use them, and will not allow the user to modify them. If the user wants to change the settings, the IDE will call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> again, passing in the same values it had received the previous time. This gives the plug-in complete control over these two strings.  
  
 For <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the IDE may pass in a user name, or it may simply pass in a pointer to an empty string. If there is a user name, the source control plug-in should use it as a default. However, if no name was passed or if the login failed with the given name, the plug-in should prompt the user for a login and pass the name back in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when it receives a valid login. Because the plug-in may change this string, the IDE will always allocate a buffer of size (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>+1).  
  
> [!NOTE]
>  The first action that the IDE performs may be a call to either the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function or the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function. Hence, both of them have an identical <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter, which enables the source control plug-in to log the user in at either time. Even if the return from the function indicates a failure, the plug-in must fill this string with a valid login name.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the directory where the user keeps the project. It may be an empty string. If there is no directory currently defined (as in the case of a user attempting to download a project from the source control system) and if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the source control plug-in can prompt the user for input or use some other method to place its own string into <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the plug-in should not change the string, because the user is already working in the specified directory.  
  
 If the user creates a new project to be put under source control, the source control plug-in might not actually create it in the source control system at the time <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is called. Instead, it passes back the string along with a nonzero value for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, indicating that the project will be created in the source control system.  
  
 For example, if a user in the **New Project** wizard in Visual Studio adds his or her project to source control, Visual Studio calls this function, and the plug-in determines if it is okay to create a new project in the source control system to contain the Visual Studio project. If the user clicks **Cancel** before completing the wizard, the project is never created. If the user clicks **OK**, Visual Studio calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, passing in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and the source controlled project is created at that time.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccOpenProject Function](../vs140/sccopenproject-function.md)