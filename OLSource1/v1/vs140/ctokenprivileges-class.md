---
title: "CTokenPrivileges Class"
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
  - "ATL::CTokenPrivileges"
  - "CTokenPrivileges"
  - "ATL.CTokenPrivileges"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTokenPrivileges class"
ms.assetid: 89590105-f001-4014-870d-142926091231
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges Class
This class is a wrapper for the **TOKEN_PRIVILEGES** structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CTokenPrivileges::CTokenPrivileges](../vs140/ctokenprivileges--ctokenprivileges.md)|The constructor.|  
|[CTokenPrivileges::~CTokenPrivileges](../vs140/ctokenprivileges--~ctokenprivileges.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTokenPrivileges::Add](../vs140/ctokenprivileges--add.md)|Adds one or more privileges to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::Delete](../vs140/ctokenprivileges--delete.md)|Deletes a privilege from the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::DeleteAll](../vs140/ctokenprivileges--deleteall.md)|Deletes all privileges from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::GetCount](../vs140/ctokenprivileges--getcount.md)|Returns the number of privilege entries in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::GetDisplayNames](../vs140/ctokenprivileges--getdisplaynames.md)|Retrieves display names for the privileges contained in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::GetLength](../vs140/ctokenprivileges--getlength.md)|Returns the buffer size in bytes required to hold the **TOKEN_PRIVILEGES** structure represented by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::GetLuidsAndAttributes](../vs140/ctokenprivileges--getluidsandattributes.md)|Retrieves the locally unique identifiers (LUIDs) and attribute flags from the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::GetNamesAndAttributes](../vs140/ctokenprivileges--getnamesandattributes.md)|Retrieves the privilege names and attribute flags from the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[CTokenPrivileges::GetPTOKEN_PRIVILEGES](../vs140/ctokenprivileges--getptoken_privileges.md)|Returns a pointer to the **TOKEN_PRIVILEGES** structure.|  
|[CTokenPrivileges::LookupPrivilege](../vs140/ctokenprivileges--lookupprivilege.md)|Retrieves the attribute associated with a given privilege name.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CTokenPrivileges::operator const TOKEN_PRIVILEGES*](../vs140/ctokenprivileges--operator-const-token_privileges--.md)|Casts a value to a pointer to the **TOKEN_PRIVILEGES** structure.|  
|[CTokenPrivileges::operator=](../vs140/ctokenprivileges--operator-=.md)|Assignment operator.|  
  
## Remarks  
 An [access token](http://msdn.microsoft.com/library/windows/desktop/aa374909) is an object that describes the security context of a process or thread and is allocated to each user logged onto a Windows NT or Windows 2000 system.  
  
 The access token is used to describe the various security privileges granted to each user. A privilege consists of a 64-bit number called a locally unique identifier ( [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261)) and a descriptor string.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class is a wrapper for the [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure and contains 0 or more privileges. Privileges can be added, deleted, or queried using the supplied class methods.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="ctokenprivileges__add">\</a>  CTokenPrivileges::Add  
 Adds one or more privileges to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> access token object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the privilege, as defined in the WINNT.H header file.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 If true, the privilege is enabled. If false, the privilege is disabled.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Reference to a [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure. The privileges and attributes are copied from this structure and added to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first form of this method returns true if the privileges are successfully added, false otherwise.  
  
##  \<a name="ctokenprivileges__ctokenprivileges">\</a>  CTokenPrivileges::CTokenPrivileges  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object to assign to the new object.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure to assign to the new <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object can optionally be created using a **TOKEN_PRIVILEGES** structure or a previously defined <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokenprivileges___dtorctokenprivileges">\</a>  CTokenPrivileges::~CTokenPrivileges  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees all allocated resources.  
  
##  \<a name="ctokenprivileges__delete">\</a>  CTokenPrivileges::Delete  
 Deletes a privilege from the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> access token object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the privilege, as defined in the WINNT.H header file. For example, this parameter could specify the constant SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege."  
  
### Return Value  
 Returns true if the privilege was successfully deleted, false otherwise.  
  
### Remarks  
 This method is useful as a tool for creating restricted tokens under Windows 2000.  
  
##  \<a name="ctokenprivileges__deleteall">\</a>  CTokenPrivileges::DeleteAll  
 Deletes all privileges from the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> access token object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Deletes all privileges contained in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> access token object.  
  
##  \<a name="ctokenprivileges__getdisplaynames">\</a>  CTokenPrivileges::GetDisplayNames  
 Retrieves display names for the privileges contained in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> access token object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A pointer to an array of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects. **CNames** is defined as a typedef:                                 **CTokenPrivileges::CAtlArray\<CString>**.  
  
### Remarks  
 The parameter <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is a pointer to an array of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> objects which will receive the display names corresponding to the privileges contained in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object. This method retrieves display names only for the privileges specified in the Defined Privileges section of WINNT.H.  
  
 This method retrieves a displayable name: for example, if the attribute name is SE_REMOTE_SHUTDOWN_NAME, the displayable name is "Force shutdown from a remote system." To obtain the system name, use [CTokenPrivileges::GetNamesAndAttributes](../vs140/ctokenprivileges--getnamesandattributes.md).  
  
##  \<a name="ctokenprivileges__getcount">\</a>  CTokenPrivileges::GetCount  
 Returns the number of privilege entries in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of privileges contained in the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokenprivileges__getlength">\</a>  CTokenPrivileges::GetLength  
 Returns the length of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of bytes required to hold a **TOKEN_PRIVILEGES** structure represented by the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object, including all of the privilege entries it contains.  
  
##  \<a name="ctokenprivileges__getluidsandattributes">\</a>  CTokenPrivileges::GetLuidsAndAttributes  
 Retrieves the locally unique identifiers (LUIDs) and attribute flags from the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to an array of [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261) objects. **CLUIDArray** is a typedef defined as **CAtlArray\<LUID> CLUIDArray**.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Pointer to an array of DWORD objects. If this parameter is omitted or NULL, the attributes are not retrieved. **CAttributes** is a typedef defined as **CAtlArray \<DWORD> CAttributes**.  
  
### Remarks  
 This method will enumerate all of the privileges contained in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> access token object and place the individual LUIDs and (optionally) the attribute flags into array objects.  
  
##  \<a name="ctokenprivileges__getnamesandattributes">\</a>  CTokenPrivileges::GetNamesAndAttributes  
 Retrieves the name and attribute flags from the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pNames*  
 Pointer to an array of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> objects. **CNames** is a typedef defined as **CAtlArray \<CString> CNames**.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Pointer to an array of DWORD objects. If this parameter is omitted or NULL, the attributes are not retrieved. **CAttributes** is a typedef defined as **CAtlArray \<DWORD> CAttributes**.  
  
### Remarks  
 This method will enumerate all of the privileges contained in the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object, placing the name and (optionally) the attribute flags into array objects.  
  
 This method retrieves the attribute name, rather than the displayable name: for example, if the attribute name is SE_REMOTE_SHUTDOWN_NAME, the system name is "SeRemoteShutdownPrivilege." To obtain the displayable name, use the method [CTokenPrivileges::GetDisplayNames](../vs140/ctokenprivileges--getdisplaynames.md).  
  
##  \<a name="ctokenprivileges__getptoken_privileges">\</a>  CTokenPrivileges::GetPTOKEN_PRIVILEGES  
 Returns a pointer to the **TOKEN_PRIVILEGES** structure.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure.  
  
##  \<a name="ctokenprivileges__lookupprivilege">\</a>  CTokenPrivileges::LookupPrivilege  
 Retrieves the attribute associated with a given privilege name.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the privilege, as defined in the WINNT.H header file. For example, this parameter could specify the constant SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege."  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Pointer to a variable that receives the attributes.  
  
### Return Value  
 Returns true if the attribute is successfully retrieved, false otherwise.  
  
##  \<a name="ctokenprivileges__operator__eq">\</a>  CTokenPrivileges::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure to assign to the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object to assign to the object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokenprivileges__operator_const_token_privileges__star">\</a>  CTokenPrivileges::operator const TOKEN_PRIVILEGES *  
 Casts a value to a pointer to the **TOKEN_PRIVILEGES** structure.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 Casts a value to a pointer to the [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure.  
  
## See Also  
 [Security Sample](../vs140/visual-c---samples.md)   
 [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630)   
 [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261)   
 [LUID_AND_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379263)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)