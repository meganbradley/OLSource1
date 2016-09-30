---
title: "CPrivateObjectSecurityDesc Class"
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
  - "ATL.CPrivateObjectSecurityDesc"
  - "ATL::CPrivateObjectSecurityDesc"
  - "CPrivateObjectSecurityDesc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrivateObjectSecurityDesc class"
ms.assetid: 2c4bbb13-bf99-4833-912a-197f6815bb5d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrivateObjectSecurityDesc Class
This class represents a private object security descriptor object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPrivateObjectSecurityDesc::CPrivateObjectSecurityDesc](../vs140/cprivateobjectsecuritydesc--cprivateobjectsecuritydesc.md)|The constructor.|  
|[CPrivateObjectSecurityDesc::~CPrivateObjectSecurityDesc](../vs140/cprivateobjectsecuritydesc--~cprivateobjectsecuritydesc.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPrivateObjectSecurityDesc::ConvertToAutoInherit](../vs140/cprivateobjectsecuritydesc--converttoautoinherit.md)|Call this method to convert a security descriptor and its access-control lists (ACLs) to a format that supports automatic propagation of inheritable access-control entries (ACEs).|  
|[CPrivateObjectSecurityDesc::Create](../vs140/cprivateobjectsecuritydesc--create.md)|Call this method to allocate and initialize a self-relative security descriptor for the private object created by the calling resource manager.|  
|[CPrivateObjectSecurityDesc::Get](../vs140/cprivateobjectsecuritydesc--get.md)|Call this method to retrieve information from a private object's security descriptor.|  
|[CPrivateObjectSecurityDesc::Set](../vs140/cprivateobjectsecuritydesc--set.md)|Call this method to modify a private object's security descriptor.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/cprivateobjectsecuritydesc--operator-=.md)|Assignment operator.|  
  
## Remarks  
 This class, derived from [CSecurityDesc](../vs140/csecuritydesc-class.md), provides methods for creating and managing the security descriptor of a private object.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Inheritance Hierarchy  
 [CSecurityDesc](../vs140/csecuritydesc-class.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="cprivateobjectsecuritydesc__converttoautoinherit">\</a>  CPrivateObjectSecurityDesc::ConvertToAutoInherit  
 Call this method to convert a security descriptor and its access-control lists (ACLs) to a format that supports automatic propagation of inheritable access-control entries (ACEs).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object referencing the parent container of the object. If there is no parent container, this parameter is NULL.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to a **GUID** structure that identifies the type of object associated with the current object. Set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to NULL if the object does not have a GUID.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specifies whether the new object can contain other objects. A value of true indicates that the new object is a container. A value of false indicates that the new object is not a container.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Pointer to a [GENERIC_MAPPING](http://msdn.microsoft.com/library/windows/desktop/aa446633) structure that specifies the mapping from each generic right to specific rights for the object.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 This method attempts to determine whether the ACEs in the discretionary access-control list (DACL) and system access-control list (SACL) of the current security descriptor were inherited from the parent security descriptor. It calls the [ConvertToAutoInheritPrivateObjectSecurity](http://msdn.microsoft.com/library/windows/desktop/aa376403) function.  
  
##  \<a name="cprivateobjectsecuritydesc__cprivateobjectsecuritydesc">\</a>  CPrivateObjectSecurityDesc::CPrivateObjectSecurityDesc  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
##  \<a name="cprivateobjectsecuritydesc___dtorcprivateobjectsecuritydesc">\</a>  CPrivateObjectSecurityDesc::~CPrivateObjectSecurityDesc  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees all allocated resources and deletes the private object's security descriptor.  
  
##  \<a name="cprivateobjectsecuritydesc__create">\</a>  CPrivateObjectSecurityDesc::Create  
 Call this method to allocate and initialize a self-relative security descriptor for the private object created by the calling resource manager.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object referencing the parent directory in which a new object is being created. Set to NULL if there is no parent directory.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Pointer to a security descriptor provided by the creator of the object. If the object's creator does not explicitly pass security information for the new object, set this parameter to NULL.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies whether the new object can contain other objects. A value of true indicates that the new object is a container. A value of false indicates that the new object is not a container.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Reference to the [CAccessToken](../vs140/caccesstoken-class.md) object for the client process on whose behalf the object is being created.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Pointer to a [GENERIC_MAPPING](http://msdn.microsoft.com/library/windows/desktop/aa446633) structure that specifies the mapping from each generic right to specific rights for the object.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Pointer to a **GUID** structure that identifies the type of object associated with the current object. Set <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to NULL if the object does not have a GUID.  
  
 *bIsContainerObject*  
 Specifies whether the new object can contain other objects. A value of true indicates that the new object is a container. A value of false indicates that the new object is not a container.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A set of bit flags that control how access-control entries (ACEs) are inherited from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. See [CreatePrivateObjectSecurityEx](http://msdn.microsoft.com/library/windows/desktop/aa446581) for more details.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 This method calls [CreatePrivateObjectSercurity](http://msdn.microsoft.com/library/windows/desktop/aa376405) or [CreatePrivateObjectSecurityEx](http://msdn.microsoft.com/library/windows/desktop/aa446581).  
  
 The second method, which permits specifying the object type GUID of the new object or controlling how ACEs are inherited, is only available on systems running Windows 2000 and later.  
  
> [!NOTE]
>  A self-relative security descriptor is a security descriptor that stores all of its security information in a contiguous block of memory.  
  
##  \<a name="cprivateobjectsecuritydesc__get">\</a>  CPrivateObjectSecurityDesc::Get  
 Call this method to retrieve information from a private object's security descriptor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A set of bit flags that indicate the parts of the security descriptor to retrieve. This value can be a combination of the [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) bit flags.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object that receives a copy of the requested information from the specified security descriptor.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The security descriptor is a structure and associated data that contains the security information for a securable object.  
  
##  \<a name="cprivateobjectsecuritydesc__operator__eq">\</a>  CPrivateObjectSecurityDesc::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object to assign to the current object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
##  \<a name="cprivateobjectsecuritydesc__set">\</a>  CPrivateObjectSecurityDesc::Set  
 Call this method to modify a private object's security descriptor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A set of bit flags that indicate the parts of the security descriptor to set. This value can be a combination of the [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) bit flags.  
  
 *Modification*  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object. The parts of this security descriptor indicated by the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter are applied to the object's security descriptor.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to a [GENERIC_MAPPING](http://msdn.microsoft.com/library/windows/desktop/aa446633) structure that specifies the mapping from each generic right to specific rights for the object.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Reference to the [CAccessToken](../vs140/caccesstoken-class.md) object for the client process on whose behalf the object is being created.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A set of bit flags that control how access-control entries (ACEs) are inherited from <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. See [CreatePrivateObjectSecurityEx](http://msdn.microsoft.com/library/windows/desktop/aa446581) for more details.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 The second method, which permits specifying the object type GUID of the object or controlling how ACEs are inherited, is only available on systems running Windows 2000 and later.  
  
## See Also  
 [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)   
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)