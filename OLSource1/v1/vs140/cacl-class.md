---
title: "CAcl Class"
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
  - "CAcl"
  - "ATL::CAcl"
  - "ATLSECURITY/CAcl"
  - "ATL.CAcl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAcl class"
ms.assetid: 20bcb9af-dc1c-4737-b923-3864776680d6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAcl Class
This class is a wrapper for an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (access-control list) structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CAcl::AccessMaskArray](../vs140/cacl--caccessmaskarray.md)|An array of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>s.|  
|[CAcl::CAceFlagArray](../vs140/cacl--caceflagarray.md)|An array of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>s.|  
|[CAcl::CAceTypeArray](../vs140/cacl--cacetypearray.md)|An array of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>s.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAcl::CAcl](../vs140/cacl--cacl.md)|The constructor.|  
|[CAcl::~CAcl](../vs140/cacl--~cacl.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAcl::GetAceCount](../vs140/cacl--getacecount.md)|Returns the number of access-control entry (ACE) objects.|  
|[CAcl::GetAclEntries](../vs140/cacl--getaclentries.md)|Retrieves the access-control list (ACL) entries from the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|[CAcl::GetAclEntry](../vs140/cacl--getaclentry.md)|Retrieves all of the information about an entry in a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
|[CAcl::GetLength](../vs140/cacl--getlength.md)|Returns the length of the ACL.|  
|[CAcl::GetPACL](../vs140/cacl--getpacl.md)|Returns a PACL (pointer to an ACL).|  
|[CAcl::IsEmpty](../vs140/cacl--isempty.md)|Tests the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object for entries.|  
|[CAcl::IsNull](../vs140/cacl--isnull.md)|Returns the status of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[CAcl::RemoveAce](../vs140/cacl--removeace.md)|Removes a specific ACE (access-control entry) from the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
|[CAcl::RemoveAces](../vs140/cacl--removeaces.md)|Removes all ACEs (access-control entries) from the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> that apply to the given <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
|[CAcl::SetEmpty](../vs140/cacl--setempty.md)|Marks the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object as empty.|  
|[CAcl::SetNull](../vs140/cacl--setnull.md)|Marks the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAcl::operator const ACL *](../vs140/cacl--operator-const-acl--.md)|Casts a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> structure.|  
|[CAcl::operator =](../vs140/cacl--operator-=.md)|Assignment operator.|  
  
## Remarks  
 The **ACL** structure is the header of an ACL (access-control list). An ACL includes a sequential list of zero or more [ACEs](http://msdn.microsoft.com/library/windows/desktop/aa374868) (access-control entries). The individual ACEs in an ACL are numbered from 0 to *n-1*, where *n* is the number of ACEs in the ACL. When editing an ACL, an application refers to an access-control entry (ACE) within the ACL by its index.  
  
 There are two ACL types:  
  
-   Discretionary  
  
-   System  
  
 A discretionary ACL is controlled by the owner of an object or anyone granted **WRITE_DAC** access to the object. It specifies the access particular users and groups can have to an object. For example, the owner of a file can use a discretionary ACL to control which users and groups can and cannot have access to the file.  
  
 An object can also have system-level security information associated with it, in the form of a system ACL controlled by a system administrator. A system ACL can allow the system administrator to audit any attempts to gain access to an object.  
  
 For more details, see the [ACL](http://msdn.microsoft.com/library/windows/desktop/aa374872) discussion in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="cacl__caccessmaskarray">\</a>  CAcl::CAccessMaskArray  
 An array of ACCESS_MASK objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This typedef specifies the array type that can be used to store access rights used in access-control entries (ACEs).  
  
##  \<a name="cacl__caceflagarray">\</a>  CAcl::CAceFlagArray  
 An array of BYTEs.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This typedef specifies the array type used to define the access-control entry (ACE) type-specific control flags. See the [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) definition for the complete list of possible flags.  
  
##  \<a name="cacl__cacetypearray">\</a>  CAcl::CAceTypeArray  
 An array of BYTEs.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This typedef specifies the array type used to define the nature of the access-control entry (ACE) objects, such as ACCESS_ALLOWED_ACE_TYPE or ACCESS_DENIED_ACE_TYPE. See the [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) definition for the complete list of possible types.  
  
##  \<a name="cacl__cacl">\</a>  CAcl::CAcl  
 The constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object can be optionally created using an existing <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
##  \<a name="cacl___dtorcacl">\</a>  CAcl::~CAcl  
 The destructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees any resources acquired by the object.  
  
##  \<a name="cacl__getacecount">\</a>  CAcl::GetAceCount  
 Returns the number of access-control entry (ACE) objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of ACE entries in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
##  \<a name="cacl__getaclentries">\</a>  CAcl::GetAclEntries  
 Retrieves the access-control list (ACL) entries from the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to an array of [CSid](../vs140/csid-class.md) objects.  
  
 *pAccessMasks*  
 The access masks.  
  
 *pAceTypes*  
 The access-control entry (                                **ACE**) types.  
  
 *pAceFlags*  
 The **ACE** flags.  
  
### Remarks  
 This method fills the array parameters with the details of every **ACE** object contained in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object. Use NULL when the details for that particular array are not required.  
  
 The contents of each array correspond to each other, that is, the first element of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> array corresponds to the first element in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> array, and so on.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for more details on ACE types and flags.  
  
##  \<a name="cacl__getaclentry">\</a>  CAcl::GetAclEntry  
 Retrieves all of the information about an entry in an access-control list (ACL).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Index to the ACL entry to retrieve.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object to which the ACL entry applies.  
  
 *pMask*  
 The mask specifying permissions to grant or deny access.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The ACE type.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The ACE flags.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The object type. This will be set to GUID_NULL if the object type is not specified in the ACE, or if the ACE is not an OBJECT ACE.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The inherited object type. This will be set to GUID_NULL if the inherited object type is not specified in the ACE, or if the ACE is not an OBJECT ACE.  
  
### Remarks  
 This method will retrieve all of the information about an individual ACE, providing more information than [CAcl::GetAclEntries](../vs140/cacl--getaclentries.md) alone makes available.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for more details on ACE types and flags.  
  
##  \<a name="cacl__getlength">\</a>  CAcl::GetLength  
 Returns the length of the access-control list (ACL).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the required length in bytes necessary to hold the **ACL** structure.  
  
##  \<a name="cacl__getpacl">\</a>  CAcl::GetPACL  
 Returns a pointer to an access-control list (ACL).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the **ACL** structure.  
  
##  \<a name="cacl__isempty">\</a>  CAcl::IsEmpty  
 Tests the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object for entries.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Returns **true** if the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object is not NULL, and contains no entries. Returns **false** if the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object is either NULL, or contains at least one entry.  
  
##  \<a name="cacl__isnull">\</a>  CAcl::IsNull  
 Returns the status of the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object is NULL,                         **false** otherwise.  
  
##  \<a name="cacl__operator_const_acl__star">\</a>  CAcl::operator const ACL *  
 Casts a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object to an **ACL** (access-control list) structure.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 Returns the address of the **ACL** structure.  
  
##  \<a name="cacl__operator__eq">\</a>  CAcl::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to assign to the existing object.  
  
### Return Value  
 Returns a reference to the updated <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
##  \<a name="cacl__removeace">\</a>  CAcl::RemoveAce  
 Removes a specific ACE (access-control entry) from the **CAcl** object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Index to the ACE entry to remove.  
  
### Remarks  
 This method is derived from [CAtlArray::RemoveAt](../vs140/catlarray--removeat.md).  
  
##  \<a name="cacl__removeaces">\</a>  CAcl::RemoveAces  
 Removes alls ACEs (access-control entries) from the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> that apply to the given <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
##  \<a name="cacl__setempty">\</a>  CAcl::SetEmpty  
 Marks the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object as empty.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> can be set to empty or to NULL: the two states are distinct.  
  
##  \<a name="cacl__setnull">\</a>  CAcl::SetNull  
 Marks the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object as NULL.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> can be set to empty or to NULL: the two states are distinct.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)