---
title: "CAccessToken::CreateProcessAsUser"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CAccessToken::CreateProcessAsUser"
  - "CreateProcessAsUser"
  - "ATL::CAccessToken::CreateProcessAsUser"
  - "ATL.CAccessToken.CreateProcessAsUser"
  - "CAccessToken.CreateProcessAsUser"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateProcessAsUser method"
ms.assetid: a068dfde-6400-43ba-a2fb-3b73152557b5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::CreateProcessAsUser
Call this method to create a new process running in the security context of the user represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pApplicationName*  
 Pointer to a null-terminated string that specifies the module to execute. This parameter may not be NULL.  
  
 *pCommandLine*  
 Pointer to a null-terminated string that specifies the command line to execute.  
  
 *pProcessInformation*  
 Pointer to a [PROCESS_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/ms684873) structure that receives identification information about the new process.  
  
 *pStartupInfo*  
 Pointer to a [STARTUPINFO](http://msdn.microsoft.com/library/windows/desktop/ms686331) structure that specifies how the main window for the new process should appear.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies additional flags that control the priority class and the creation of the process. See the Win32 function [CreateProcessAsUser](http://msdn.microsoft.com/library/windows/desktop/ms682429) for a list of flags.  
  
 *bLoadProfile*  
 If true, the user's profile is loaded with [LoadUserProfile](http://msdn.microsoft.com/library/windows/desktop/bb762281).  
  
 *pProcessAttributes*  
 Pointer to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies a security descriptor for the new process and determines whether child processes can inherit the returned handle. If *pProcessAttributes* is NULL, the process gets a default security descriptor and the handle cannot be inherited.  
  
 *pThreadAttributes*  
 Pointer to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies a security descriptor for the new thread and determines whether child processes can inherit the returned handle. If *pThreadAttributes* is NULL, the thread gets a default security descriptor and the handle cannot be inherited.  
  
 *bInherit*  
 Indicates whether the new process inherits handles from the calling process. If true, each inheritable open handle in the calling process is inherited by the new process. Inherited handles have the same value and access privileges as the original handles.  
  
 *pCurrentDirectory*  
 Pointer to a null-terminated string that specifies the current drive and directory for the new process. The string must be a full path that includes a drive letter. If this parameter is NULL, the new process will have the same current drive and directory as the calling process.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 **CreateProcessAsUser** uses the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Win32 function to create a new process that runs in the security context of the user represented by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. See the description of the [CreateProcessAsUser](http://msdn.microsoft.com/library/windows/desktop/ms682429) function for a full discussion of the parameters required.  
  
 For this method to succeed, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object must hold AssignPrimaryToken (unless it is a restricted token) and IncreaseQuota privileges.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)