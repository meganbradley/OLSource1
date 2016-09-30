---
title: "CAccessToken Class"
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
  - "ATLSECURITY/CAccessToken"
  - "ATL.CAccessToken"
  - "CAccessToken"
  - "ATL::CAccessToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAccessToken class"
ms.assetid: bb5c5945-56a5-4083-b442-76573cee83ab
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken Class
This class is a wrapper for an access token.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAccessToken::~CAccessToken](../vs140/caccesstoken--~caccesstoken.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAccessToken::Attach](../vs140/caccesstoken--attach.md)|Call this method to take ownership of the given access token handle.|  
|[CAccessToken::CheckTokenMembership](../vs140/caccesstoken--checktokenmembership.md)|Call this method to determine if a specified SID is enabled in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[CAccessToken::CreateImpersonationToken](../vs140/caccesstoken--createimpersonationtoken.md)|Call this method to create a new impersonation access token.|  
|[CAccessToken::CreatePrimaryToken](../vs140/caccesstoken--createprimarytoken.md)|Call this method to create a new primary token.|  
|[CAccessToken::CreateProcessAsUser](../vs140/caccesstoken--createprocessasuser.md)|Call this method to create a new process running in the security context of the user represented by the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
|[CAccessToken::CreateRestrictedToken](../vs140/caccesstoken--createrestrictedtoken.md)|Call this method to create a new, restricted <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.|  
|[CAccessToken::Detach](../vs140/caccesstoken--detach.md)|Call this method to revoke ownership of the access token.|  
|[CAccessToken::DisablePrivilege](../vs140/caccesstoken--disableprivilege.md)|Call this method to disable a privilege in the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.|  
|[CAccessToken::DisablePrivileges](../vs140/caccesstoken--disableprivileges.md)|Call this method to disable one or more privileges in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.|  
|[CAccessToken::EnablePrivilege](../vs140/caccesstoken--enableprivilege.md)|Call this method to enable a privilege in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.|  
|[CAccessToken::EnablePrivileges](../vs140/caccesstoken--enableprivileges.md)|Call this method to enable one or more privileges in the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetDefaultDacl](../vs140/caccesstoken--getdefaultdacl.md)|Call this method to return the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object's default DACL.|  
|[CAccessToken::GetEffectiveToken](../vs140/caccesstoken--geteffectivetoken.md)|Call this method to get the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object equal to the access token in effect for the current thread.|  
|[CAccessToken::GetGroups](../vs140/caccesstoken--getgroups.md)|Call this method to return the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object's token groups.|  
|[CAccessToken::GetHandle](../vs140/caccesstoken--gethandle.md)|Call this method to retrieve a handle to the access token.|  
|[CAccessToken::GetImpersonationLevel](../vs140/caccesstoken--getimpersonationlevel.md)|Call this method to get the impersonation level from the access token.|  
|[CAccessToken::GetLogonSessionId](../vs140/caccesstoken--getlogonsessionid.md)|Call this method to get the Logon Session ID associated with the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetLogonSid](../vs140/caccesstoken--getlogonsid.md)|Call this method to get the Logon SID associated with the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetOwner](../vs140/caccesstoken--getowner.md)|Call this method to get the owner associated with the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetPrimaryGroup](../vs140/caccesstoken--getprimarygroup.md)|Call this method to get the primary group associated with the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetPrivileges](../vs140/caccesstoken--getprivileges.md)|Call this method to get the privileges associated with the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetProcessToken](../vs140/caccesstoken--getprocesstoken.md)|Call this method to initialize the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> with the access token from the given process.|  
|[CAccessToken::GetProfile](../vs140/caccesstoken--getprofile.md)|Call this method to get the handle pointing to the user profile associated with the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetSource](../vs140/caccesstoken--getsource.md)|Call this method to get the source of the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetStatistics](../vs140/caccesstoken--getstatistics.md)|Call this method to get information associated with the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetTerminalServicesSessionId](../vs140/caccesstoken--getterminalservicessessionid.md)|Call this method to get the Terminal Services Session ID associated with the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetThreadToken](../vs140/caccesstoken--getthreadtoken.md)|Call this method to initialize the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> with the token from the given thread.|  
|[CAccessToken::GetTokenId](../vs140/caccesstoken--gettokenid.md)|Call this method to get the Token ID associated with the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetType](../vs140/caccesstoken--gettype.md)|Call this method to get the token type of the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.|  
|[CAccessToken::GetUser](../vs140/caccesstoken--getuser.md)|Call this method to identify the user associated with the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.|  
|[CAccessToken::HKeyCurrentUser](../vs140/caccesstoken--hkeycurrentuser.md)|Call this method to get the handle pointing to the user profile associated with the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.|  
|[CAccessToken::Impersonate](../vs140/caccesstoken--impersonate.md)|Call this method to assign an impersonation <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> to a thread.|  
|[CAccessToken::ImpersonateLoggedOnUser](../vs140/caccesstoken--impersonateloggedonuser.md)|Call this method to allow the calling thread to impersonate the security context of a logged-on user.|  
|[CAccessToken::IsTokenRestricted](../vs140/caccesstoken--istokenrestricted.md)|Call this method to test if the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object contains a list of restricted SIDs.|  
|[CAccessToken::LoadUserProfile](../vs140/caccesstoken--loaduserprofile.md)|Call this method to load the user profile associated with the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object.|  
|[CAccessToken::LogonUser](../vs140/caccesstoken--logonuser.md)|Call this method to create a logon session for the user associated with the given credentials.|  
|[CAccessToken::OpenCOMClientToken](../vs140/caccesstoken--opencomclienttoken.md)|Call this method from within a COM server handling a call from a client to initialize the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> with the access token from the COM client.|  
|[CAccessToken::OpenNamedPipeClientToken](../vs140/caccesstoken--opennamedpipeclienttoken.md)|Call this method from within a server taking requests over a named pipe to initialize the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> with the access token from the client.|  
|[CAccessToken::OpenRPCClientToken](../vs140/caccesstoken--openrpcclienttoken.md)|Call this method from within a server handling a call from an RPC client to initialize the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> with the access token from the client.|  
|[CAccessToken::OpenThreadToken](../vs140/caccesstoken--openthreadtoken.md)|Call this method to set the impersonation level and then initialize the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> with the token from the given thread.|  
|[CAccessToken::PrivilegeCheck](../vs140/caccesstoken--privilegecheck.md)|Call this method to determine whether a specified set of privileges are enabled in the **CAccessToken** object.|  
|[CAccessToken::Revert](../vs140/caccesstoken--revert.md)|Call this method to stop a thread that is using an impersonation token.|  
|[CAccessToken::SetDefaultDacl](../vs140/caccesstoken--setdefaultdacl.md)|Call this method to set the default DACL of the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.|  
|[CAccessToken::SetOwner](../vs140/caccesstoken--setowner.md)|Call this method to set the owner of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.|  
|[CAccessToken::SetPrimaryGroup](../vs140/caccesstoken--setprimarygroup.md)|Call this method to set the primary group of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 An [access token](http://msdn.microsoft.com/library/windows/desktop/aa374909) is an object that describes the security context of a process or thread and is allocated to each user logged onto a Windows NT or Windows 2000 system.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="caccesstoken__attach">\</a>  CAccessToken::Attach  
 Call this method to take ownership of the given access token handle.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *hToken*  
 A handle to the access token.  
  
### Remarks  
 In debug builds, an assertion error will occur if the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object already has ownership of an access token.  
  
##  \<a name="caccesstoken___dtorcaccesstoken">\</a>  CAccessToken::~CAccessToken  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="caccesstoken__checktokenmembership">\</a>  CAccessToken::CheckTokenMembership  
 Call this method to determine if a specified SID is enabled in the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Reference to a [CSid Class](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Pointer to a variable that receives the results of the check.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> method checks for the presence of the SID in the user and group SIDs of the access token. If the SID is present and has the SE_GROUP_ENABLED attribute, *pbIsMember* is set to true; otherwise, it is set to false.  
  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> is not a valid pointer.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object must be an impersonation token and not a primary token.  
  
##  \<a name="caccesstoken__createimpersonationtoken">\</a>  CAccessToken::CreateImpersonationToken  
 Call this method to create an impersonation access token.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Pointer to the new <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Specifies a [SECURITY_IMPERSONATION_LEVEL](http://msdn.microsoft.com/library/windows/desktop/aa379572) enumerated type that supplies the impersonation level of the new token.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> calls [DuplicateToken](http://msdn.microsoft.com/library/windows/desktop/aa446616) to create a new impersonation token.  
  
##  \<a name="caccesstoken__createprimarytoken">\</a>  CAccessToken::CreatePrimaryToken  
 Call this method to create a new primary token.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pPri*  
 Pointer to the new <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Specifies the requested access rights for the new token. The default, MAXIMUM_ALLOWED, requests all access rights that are valid for the caller. See [Access Rights and Access Masks](http://msdn.microsoft.com/library/windows/desktop/aa374902) for more on access rights.  
  
 *pTokenAttributes*  
 Pointer to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies a security descriptor for the new token and determines whether child processes can inherit the token. If *pTokenAttributes* is NULL, the token gets a default security descriptor and the handle cannot be inherited.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> calls [DuplicateTokenEx](http://msdn.microsoft.com/library/windows/desktop/aa446617) to create a new primary token.  
  
##  \<a name="caccesstoken__createprocessasuser">\</a>  CAccessToken::CreateProcessAsUser  
 Call this method to create a new process running in the security context of the user represented by the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *pApplicationName*  
 Pointer to a null-terminated string that specifies the module to execute. This parameter may not be NULL.  
  
 *pCommandLine*  
 Pointer to a null-terminated string that specifies the command line to execute.  
  
 *pProcessInformation*  
 Pointer to a [PROCESS_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/ms684873) structure that receives identification information about the new process.  
  
 *pStartupInfo*  
 Pointer to a [STARTUPINFO](http://msdn.microsoft.com/library/windows/desktop/ms686331) structure that specifies how the main window for the new process should appear.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
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
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 **CreateProcessAsUser** uses the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> Win32 function to create a new process that runs in the security context of the user represented by the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object. See the description of the [CreateProcessAsUser](http://msdn.microsoft.com/library/windows/desktop/ms682429) function for a full discussion of the parameters required.  
  
 For this method to succeed, the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object must hold AssignPrimaryToken (unless it is a restricted token) and IncreaseQuota privileges.  
  
##  \<a name="caccesstoken__createrestrictedtoken">\</a>  CAccessToken::CreateRestrictedToken  
 Call this method to create a new, restricted <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *pRestrictedToken*  
 The new, restricted <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object that specifies the deny-only SIDs.  
  
 *SidsToRestrict*  
 A <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object that specifies the restricting SIDs.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object that specifies the privileges to delete in the restricted token. The default creates an empty object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> uses the [CreateRestrictedToken](http://msdn.microsoft.com/library/windows/desktop/aa446583) Win32 function to create a new <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object, with restrictions.  
  
> [!NOTE]
>  This method is only available on Windows 2000 or later.  
  
> [!IMPORTANT]
>  When using <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, ensure the following: the existing token is valid (and not entered by the user) and <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> are both valid (and not entered by the user). If the method returns false, deny functionality.  
  
##  \<a name="caccesstoken__detach">\</a>  CAccessToken::Detach  
 Call this method to revoke ownership of the access token.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the handle to the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> which has been detached.  
  
### Remarks  
 This method revokes the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>'s ownership of the access token.  
  
##  \<a name="caccesstoken__disableprivilege">\</a>  CAccessToken::DisablePrivilege  
 Call this method to disable a privilege in the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Pointer to a string containing the privilege to disable in the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object which will contain the previous state of the privileges.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__disableprivileges">\</a>  CAccessToken::DisablePrivileges  
 Call this method to disable one or more privileges in the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Pointer to an array of strings containing the privileges to disable in the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object which will contain the previous state of the privileges.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__enableprivilege">\</a>  CAccessToken::EnablePrivilege  
 Call this method to enable a privilege in the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Pointer to a string containing the privilege to enable in the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object which will contain the previous state of the privileges.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__enableprivileges">\</a>  CAccessToken::EnablePrivileges  
 Call this method to enable one or more privileges in the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Pointer to an array of strings containing the privileges to enable in the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> object which will contain the previous state of the privileges.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getdefaultdacl">\</a>  CAccessToken::GetDefaultDacl  
 Call this method to return the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object's default DACL.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Pointer to the [CDacl Class](../vs140/cdacl-class.md) object which will receive the **CAccessToken** object's default DACL.  
  
### Return Value  
 Returns true if the default DACL has been recovered, false otherwise.  
  
##  \<a name="caccesstoken__geteffectivetoken">\</a>  CAccessToken::GetEffectiveToken  
 Call this method to get the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object equal to the access token in effect for the current thread.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getgroups">\</a>  CAccessToken::GetGroups  
 Call this method to return the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object's token groups.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *pGroups*  
 Pointer to the [CTokenGroups Class](../vs140/ctokengroups-class.md) object which will receive the group information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__gethandle">\</a>  CAccessToken::GetHandle  
 Call this method to retrieve a handle to the access token.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Returns a handle to the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object's access token.  
  
##  \<a name="caccesstoken__getimpersonationlevel">\</a>  CAccessToken::GetImpersonationLevel  
 Call this method to get the impersonation level from the access token.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *pImpersonationLevel*  
 Pointer to a [SECURITY_IMPERSONATION_LEVEL](http://msdn.microsoft.com/library/windows/desktop/aa379572) enumeration type which will receive the impersonation level information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getlogonsessionid">\</a>  CAccessToken::GetLogonSessionId  
 Call this method to get the Logon Session ID associated with the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Pointer to a [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261) which will receive the Logon Session ID.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> is an invalid value.  
  
##  \<a name="caccesstoken__getlogonsid">\</a>  CAccessToken::GetLogonSid  
 Call this method to get the Logon SID associated with the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Pointer to a [CSid Class](../vs140/csid-class.md) object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if *pSid* is an invalid value.  
  
##  \<a name="caccesstoken__getowner">\</a>  CAccessToken::GetOwner  
 Call this method to get the owner associated with the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Pointer to a [CSid Class](../vs140/csid-class.md) object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The owner is set by default on any objects created while this access token is in effect.  
  
##  \<a name="caccesstoken__getprimarygroup">\</a>  CAccessToken::GetPrimaryGroup  
 Call this method to get the primary group associated with the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Pointer to a [CSid Class](../vs140/csid-class.md) object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The group is set by default on any objects created while this access token is in effect.  
  
##  \<a name="caccesstoken__getprivileges">\</a>  CAccessToken::GetPrivileges  
 Call this method to get the privileges associated with the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to a [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md) object which will receive the privileges.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getprocesstoken">\</a>  CAccessToken::GetProcessToken  
 Call this method to initialize the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> with the access token from the given process.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 *hProcess*  
 Handle to the process whose access token is opened. If the default value of <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> is used, the current process is used.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> on success, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Calls the [OpenProcessToken](http://msdn.microsoft.com/library/aa379295\(VS.85\).aspx) Win32 function.  
  
##  \<a name="caccesstoken__getprofile">\</a>  CAccessToken::GetProfile  
 Call this method to get the handle pointing to the user profile associated with the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 Returns a handle pointing to the user profile, or NULL if no profile exists.  
  
##  \<a name="caccesstoken__getsource">\</a>  CAccessToken::GetSource  
 Call this method to get the source of the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *pSource*  
 Pointer to a [TOKEN_SOURCE](http://msdn.microsoft.com/library/windows/desktop/aa379631) structure.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getstatistics">\</a>  CAccessToken::GetStatistics  
 Call this method to get information associated with the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *pStatistics*  
 Pointer to a [TOKEN_STATISTICS](http://msdn.microsoft.com/library/windows/desktop/aa379632) structure.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getterminalservicessessionid">\</a>  CAccessToken::GetTerminalServicesSessionId  
 Call this method to get the Terminal Services Session ID associated with the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 *pdwSessionId*  
 The Terminal Services Session ID.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__getthreadtoken">\</a>  CAccessToken::GetThreadToken  
 Call this method to initialize the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> with the token from the given thread.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Handle to the thread whose access token is opened.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Indicates whether the access check is to be made against the security context of the thread calling the <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__gettokenid">\</a>  CAccessToken::GetTokenId  
 Call this method to get the Token ID associated with the <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Pointer to a [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261) which will receive the Token ID.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__gettype">\</a>  CAccessToken::GetType  
 Call this method to get the token type of the <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 Address of the [TOKEN_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379633) variable that, on success, receives the type of the token.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The **TOKEN_TYPE** enumeration type contains values that differentiate between a primary token and an impersonation token.  
  
##  \<a name="caccesstoken__getuser">\</a>  CAccessToken::GetUser  
 Call this method to identify the user associated with the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Pointer to a [CSid Class](../vs140/csid-class.md) object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="caccesstoken__hkeycurrentuser">\</a>  CAccessToken::HKeyCurrentUser  
 Call this method to get the handle pointing to the user profile associated with the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 Returns a handle pointing to the user profile, or NULL if no profile exists.  
  
##  \<a name="caccesstoken__impersonate">\</a>  CAccessToken::Impersonate  
 Call this method to assign an impersonation <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> to a thread.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Handle to the thread to assign the impersonation token to. This handle must have been opened with TOKEN_IMPERSONATE access rights. If <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> is NULL, the method causes the thread to stop using an impersonation token.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> does not have a valid pointer to a token.  
  
 The [CAutoRevertImpersonation class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens.  
  
##  \<a name="caccesstoken__impersonateloggedonuser">\</a>  CAccessToken::ImpersonateLoggedOnUser  
 Call this method to allow the calling thread to impersonate the security context of a logged-on user.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
  
> [!IMPORTANT]
>  If a call to an impersonation function fails for any reason, the client is not impersonated and the client request is made in the security context of the process from which the call was made. If the process is running as a highly privileged account, or as a member of an administrative group, the user might be able to perform actions he or she would otherwise be disallowed. Therefore, the return value for this function should always be confirmed.  
  
##  \<a name="caccesstoken__istokenrestricted">\</a>  CAccessToken::IsTokenRestricted  
 Call this method to test if the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> object contains a list of restricted SIDs.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the object contains a list of restricting SIDs, false if there are no restricting SIDs or if the method fails.  
  
##  \<a name="caccesstoken__loaduserprofile">\</a>  CAccessToken::LoadUserProfile  
 Call this method to load the user profile associated with the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> does not contain a valid token, or if a user profile already exists.  
  
##  \<a name="caccesstoken__logonuser">\</a>  CAccessToken::LogonUser  
 Call this method to create a logon session for the user associated with the given credentials.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the user name. This is the name of the user account to log on to.  
  
 *pszDomain*  
 Pointer to a null-terminated string that specifies the name of the domain or server whose account database contains the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> account.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the clear-text password for the user account specified by <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 *dwLogonType*  
 Specifies the type of logon operation to perform. See [LogonUser](http://msdn.microsoft.com/library/windows/desktop/aa378184) for more details.  
  
 *dwLogonProvider*  
 Specifies the logon provider. See [LogonUser](http://msdn.microsoft.com/library/windows/desktop/aa378184) for more details.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The access token resulting from the logon will be associated with the <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. For this method to succeed, the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> object must hold SE_TCB_NAME privileges, identifying the holder as part of the trusted computer base. See [LogonUser](http://msdn.microsoft.com/library/windows/desktop/aa378184) for more information regarding the privileges required.  
  
##  \<a name="caccesstoken__opencomclienttoken">\</a>  CAccessToken::OpenCOMClientToken  
 Call this method from within a COM server handling a call from a client to initialize the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> with the access token from the COM client.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 If true, the current thread will impersonate the calling COM client if this call completes successfully. If false, the access token will be opened, but the thread will not have an impersonation token when this call completes.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Indicates whether the access check is to be made against the security context of the thread calling the [GetThreadToken](http://msdn.microsoft.com/library/windows/desktop/ms683182) method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens created by setting the <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> flag to *true*.  
  
##  \<a name="caccesstoken__opennamedpipeclienttoken">\</a>  CAccessToken::OpenNamedPipeClientToken  
 Call this method from within a server taking requests over a named pipe to initialize the <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> with the access token from the client.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 *hPipe*  
 Handle to a named pipe.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 If true, the current thread will impersonate the calling pipe client if this call completes successfully. If false, the access token will be opened, but the thread will not have an impersonation token when this call completes.  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Indicates whether the access check is to be made against the security context of the thread calling the [GetThreadToken](http://msdn.microsoft.com/library/windows/desktop/ms683182) method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens created by setting the <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> flag to *true*.  
  
##  \<a name="caccesstoken__openrpcclienttoken">\</a>  CAccessToken::OpenRPCClientToken  
 Call this method from within a server handling a call from an RPC client to initialize the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> with the access token from the client.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 *BindingHandle*  
 Binding handle on the server that represents a binding to a client.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 If true, the current thread will impersonate the calling RPC client if this call completes successfully. If false, the access token will be opened, but the thread will not have an impersonation token when this call completes.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 Indicates whether the access check is to be made against the security context of the thread calling the [GetThreadToken](http://msdn.microsoft.com/library/windows/desktop/ms683182) method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens created by setting the <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> flag to *true*.  
  
##  \<a name="caccesstoken__openthreadtoken">\</a>  CAccessToken::OpenThreadToken  
 Call this method to set the impersonation level and then initialize the <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> with the token from the given thread.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 If true, the thread will be left at the requested impersonation level after this method completes. If false, the thread will revert to its original impersonation level.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 Indicates whether the access check is to be made against the security context of the thread calling the [GetThreadToken](http://msdn.microsoft.com/library/windows/desktop/ms683182) method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 Specifies a [SECURITY_IMPERSONATION_LEVEL](http://msdn.microsoft.com/library/windows/desktop/aa379572) enumerated type that supplies the impersonation level of the token.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> is similar to [CAccessToken::GetThreadToken](../vs140/caccesstoken--getthreadtoken.md), but sets the impersonation level before initializing the <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> from the thread's access token.  
  
 The [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens created by setting the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> flag to *true*.  
  
##  \<a name="caccesstoken__privilegecheck">\</a>  CAccessToken::PrivilegeCheck  
 Call this method to determine whether a specified set of privileges are enabled in the **CAccessToken** object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 *RequiredPrivileges*  
 Pointer to a [PRIVILEGE_SET](http://msdn.microsoft.com/library/windows/desktop/aa379307) structure.  
  
 *pbResult*  
 Pointer to a value the method sets to indicate whether any or all of the specified privilege are enabled in the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 When <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> returns, the **Attributes** member of each [LUID_AND_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379263) structure is set to SE_PRIVILEGE_USED_FOR_ACCESS if the corresponding privilege is enabled. This method calls the [PrivilegeCheck](http://msdn.microsoft.com/library/windows/desktop/aa379304) Win32 function.  
  
##  \<a name="caccesstoken__revert">\</a>  CAccessToken::Revert  
 Call this method to stop a thread from using an impersonation token.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 Handle to the thread to revert from impersonation. If *hThread* is NULL, the current thread is assumed.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The reversion of impersonation tokens can be performed automatically with the [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md).  
  
##  \<a name="caccesstoken__setdefaultdacl">\</a>  CAccessToken::SetDefaultDacl  
 Call this method to set the default DACL of the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 The new default [CDacl Class](../vs140/cdacl-class.md) information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The default DACL is the DACL that is used by default when new objects are created with this access token in effect.  
  
##  \<a name="caccesstoken__setowner">\</a>  CAccessToken::SetOwner  
 Call this method to set the owner of the <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The [CSid Class](../vs140/csid-class.md) object containing the owner information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The owner is the default owner that is used for new objects created while this access token is in effect.  
  
##  \<a name="caccesstoken__setprimarygroup">\</a>  CAccessToken::SetPrimaryGroup  
 Call this method to set the primary group of the <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 The [CSid Class](../vs140/csid-class.md) object containing the primary group information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The primary group is the default group for new objects created while this access token is in effect.  
  
## See Also  
 [ATLSecurity Sample](../vs140/visual-c---samples.md)   
 [Access Tokens](http://msdn.microsoft.com/library/windows/desktop/aa374909)   
 [Class Overview](../vs140/atl-class-overview.md)