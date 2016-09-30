---
title: "CPrivateObjectSecurityDesc::ConvertToAutoInherit"
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
  - "ATL.CPrivateObjectSecurityDesc.ConvertToAutoInherit"
  - "CPrivateObjectSecurityDesc.ConvertToAutoInherit"
  - "CPrivateObjectSecurityDesc::ConvertToAutoInherit"
  - "ConvertToAutoInherit"
  - "ATL::CPrivateObjectSecurityDesc::ConvertToAutoInherit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConvertToAutoInherit method"
ms.assetid: 9e686b0b-f54c-4b95-93c0-ad27d994cb57
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrivateObjectSecurityDesc::ConvertToAutoInherit
Call this method to convert a security descriptor and its access-control lists (ACLs) to a format that supports automatic propagation of inheritable access-control entries (ACEs).  
  
## Syntax  
  
```  
  
      bool ConvertToAutoInherit(  
   const CSecurityDesc* pParent,  
   GUID* ObjectType,  
   bool bIsDirectoryObject,  
   PGENERIC_MAPPING GenericMapping   
) throw( );  
```  
  
#### Parameters  
 `pParent`  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object referencing the parent container of the object. If there is no parent container, this parameter is NULL.  
  
 `ObjectType`  
 Pointer to a **GUID** structure that identifies the type of object associated with the current object. Set `ObjectType` to NULL if the object does not have a GUID.  
  
 `bIsDirectoryObject`  
 Specifies whether the new object can contain other objects. A value of true indicates that the new object is a container. A value of false indicates that the new object is not a container.  
  
 `GenericMapping`  
 Pointer to a [GENERIC_MAPPING](http://msdn.microsoft.com/library/windows/desktop/aa446633) structure that specifies the mapping from each generic right to specific rights for the object.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 This method attempts to determine whether the ACEs in the discretionary access-control list (DACL) and system access-control list (SACL) of the current security descriptor were inherited from the parent security descriptor. It calls the [ConvertToAutoInheritPrivateObjectSecurity](http://msdn.microsoft.com/library/windows/desktop/aa376403) function.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CPrivateObjectSecurityDesc Class](../vs140/cprivateobjectsecuritydesc-class.md)