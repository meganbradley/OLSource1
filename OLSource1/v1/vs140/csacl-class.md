---
title: "CSacl Class"
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
  - "ATL.CSacl"
  - "ATL::CSacl"
  - "CSacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSacl class"
ms.assetid: 8624889b-aebc-4183-9d29-a20f07837f05
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSacl Class
This class is a wrapper for a SACL (system access-control list) structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSacl::CSacl](../vs140/csacl--csacl.md)|The constructor.|  
|[CSacl::~CSacl](../vs140/csacl--~csacl.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSacl::AddAuditAce](../vs140/csacl--addauditace.md)|Adds an audit access-control entry (ACE) to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[CSacl::GetAceCount](../vs140/csacl--getacecount.md)|Returns the number of access-control entries (ACEs) in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[CSacl::RemoveAce](../vs140/csacl--removeace.md)|Removes a specific ACE (access-control entry) from the **CSacl** object.|  
|[CSacl::RemoveAllAces](../vs140/csacl--removeallaces.md)|Removes all of the ACEs contained in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSacl::operator =](../vs140/csacl--operator-=.md)|Assignment operator.|  
  
## Remarks  
 A SACL contains access-control entries (ACEs) that specify the types of access attempts that generate audit records in the security event log of a domain controller. Note that a SACL generates log entries only on the domain controller where the access attempt occurred, not on every domain controller that contains a replica of the object.  
  
 To set or retrieve the SACL in an object's security descriptor, the SE_SECURITY_NAME privilege must be enabled in the access token of the requesting thread. The administrators group has this privilege granted by default, and it can be granted to other users or groups. Having the privilege granted is not all that is required: before the operation defined by the privilege can be performed, the privilege must be enabled in the security access token in order to take effect. The model allows privileges to be enabled only for specific system operations, and then disabled when they are no longer needed. See [AtlGetSacl](../vs140/atlgetsacl.md) and [AtlSetSacl](../vs140/atlsetsacl.md) for examples of enabling SE_SECURITY_NAME.  
  
 Use the class methods provided to add, remove, create, and delete ACEs from the **SACL** object. See also [AtlGetSacl](../vs140/atlgetsacl.md) and [AtlSetSacl](../vs140/atlsetsacl.md).  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Inheritance Hierarchy  
 [CAcl](../vs140/cacl-class.md)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="csacl__addauditace">\</a>  CSacl::AddAuditAce  
 Adds an audit access-control entry (ACE) to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the mask of access rights to be audited for the specified <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies whether allowed access attempts are to be audited. Set this flag to true to enable auditing; otherwise, set it to false.  
  
 *bFailure*  
 Specifies whether denied access attempts are to be audited. Set this flag to true to enable auditing; otherwise, set it to false.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A set of bit flags that control ACE inheritance.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The object type.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The inherited object type.  
  
### Return Value  
 Returns **true** if the ACE is added to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object,                         **false** on failure.  
  
### Remarks  
 A <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object contains access-control entries (ACEs) that specify the types of access attempts that generate audit records in the security event log. This method adds such an ACE to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. The second form of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is only available on Windows 2000 and later.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for a description of the various flags which can be set in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="csacl__csacl">\</a>  CSacl::CSacl  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An existing **ACL** (access-control list) structure.  
  
### Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object can be optionally created using an existing **ACL** structure. Ensure that this parameter is a system access-control list (SACL) and not a discretionary access-control list (DACL). In debug builds, if a DACL is supplied an assertion will occur. In release builds any entries from a DACL are ignored.  
  
##  \<a name="csacl___dtorcsacl">\</a>  CSacl::~CSacl  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees any resources acquired by the object, including all access-control entries (ACEs).  
  
##  \<a name="csacl__getacecount">\</a>  CSacl::GetAceCount  
 Returns the number of access-control entries (ACEs) in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of ACEs contained in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
##  \<a name="csacl__operator__eq">\</a>  CSacl::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The **ACL** (access-control list) to assign to the existing object.  
  
### Return Value  
 Returns a reference to the updated <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object. Ensure that the **ACL** parameter is actually a system access-control list (SACL) and not a discretionary access-control list (DACL). In debug builds an assertion will occur, and in release builds the **ACL** parameter will be ignored.  
  
##  \<a name="csacl__removeace">\</a>  CSacl::RemoveAce  
 Removes a specific ACE (access-control entry) from the **CSacl** object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Index to the ACE entry to remove.  
  
### Remarks  
 This method is derived from [CAtlArray::RemoveAt](../vs140/catlarray--removeat.md).  
  
##  \<a name="csacl__removeallaces">\</a>  CSacl::RemoveAllAces  
 Removes all of the access-control entries (ACEs) contained in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Removes every **ACE** structure (if any) in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
## See Also  
 [CAcl Class](../vs140/cacl-class.md)   
 [ACLs](http://msdn.microsoft.com/library/windows/desktop/aa374872)   
 [ACEs](http://msdn.microsoft.com/library/windows/desktop/aa374868)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)