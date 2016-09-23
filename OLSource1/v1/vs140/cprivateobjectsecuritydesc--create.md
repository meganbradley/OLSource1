---
title: "CPrivateObjectSecurityDesc::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CPrivateObjectSecurityDesc.Create
  - ATL::CPrivateObjectSecurityDesc::Create
  - CPrivateObjectSecurityDesc.Create
  - CPrivateObjectSecurityDesc::Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method [C++]
ms.assetid: 3b170181-a27f-46e3-b6bc-392c42b18b05
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrivateObjectSecurityDesc::Create
Call this method to allocate and initialize a self-relative security descriptor for the private object created by the calling resource manager.  
  
## Syntax  
  
```  
  
      bool Create(  
   const CSecurityDesc* pParent,  
   const CSecurityDesc* pCreator,  
   bool bIsDirectoryObject,  
   const CAccessToken& Token,  
   PGENERIC_MAPPING GenericMapping   
) throw( );  
bool Create(  
   const CSecurityDesc* pParent,  
   const CSecurityDesc* pCreator,  
   GUID* ObjectType,  
   bool bIsContainerObject,  
   ULONG AutoInheritFlags,  
   const CAccessToken& Token,  
   PGENERIC_MAPPING GenericMapping   
) throw( );  
```  
  
#### Parameters  
 `pParent`  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object referencing the parent directory in which a new object is being created. Set to NULL if there is no parent directory.  
  
 `pCreator`  
 Pointer to a security descriptor provided by the creator of the object. If the object's creator does not explicitly pass security information for the new object, set this parameter to NULL.  
  
 `bIsDirectoryObject`  
 Specifies whether the new object can contain other objects. A value of true indicates that the new object is a container. A value of false indicates that the new object is not a container.  
  
 `Token`  
 Reference to the [CAccessToken](../vs140/caccesstoken-class.md) object for the client process on whose behalf the object is being created.  
  
 `GenericMapping`  
 Pointer to a [GENERIC_MAPPING](http://msdn.microsoft.com/library/windows/desktop/aa446633) structure that specifies the mapping from each generic right to specific rights for the object.  
  
 `ObjectType`  
 Pointer to a **GUID** structure that identifies the type of object associated with the current object. Set `ObjectType` to NULL if the object does not have a GUID.  
  
 *bIsContainerObject*  
 Specifies whether the new object can contain other objects. A value of true indicates that the new object is a container. A value of false indicates that the new object is not a container.  
  
 `AutoInheritFlags`  
 A set of bit flags that control how access-control entries (ACEs) are inherited from `pParent`. See [CreatePrivateObjectSecurityEx](http://msdn.microsoft.com/library/windows/desktop/aa446581) for more details.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 This method calls [CreatePrivateObjectSercurity](http://msdn.microsoft.com/library/windows/desktop/aa376405) or [CreatePrivateObjectSecurityEx](http://msdn.microsoft.com/library/windows/desktop/aa446581).  
  
 The second method, which permits specifying the object type GUID of the new object or controlling how ACEs are inherited, is only available on systems running Windows 2000 and later.  
  
> [!NOTE]
>  A self-relative security descriptor is a security descriptor that stores all of its security information in a contiguous block of memory.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CPrivateObjectSecurityDesc Class](../vs140/cprivateobjectsecuritydesc-class.md)