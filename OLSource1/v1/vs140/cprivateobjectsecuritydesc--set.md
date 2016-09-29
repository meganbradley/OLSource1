---
title: "CPrivateObjectSecurityDesc::Set"
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
  - "Set"
  - "CPrivateObjectSecurityDesc::Set"
  - "CPrivateObjectSecurityDesc.Set"
  - "ATL::CPrivateObjectSecurityDesc::Set"
  - "ATL.CPrivateObjectSecurityDesc.Set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Set method"
ms.assetid: 21abfb5f-c6a5-4df5-99c5-c68eeb183d28
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrivateObjectSecurityDesc::Set
Call this method to modify a private object's security descriptor.  
  
## Syntax  
  
```  
  
      bool Set(  
   SECURITY_INFORMATION si,  
   const CSecurityDesc& Modification,  
   PGENERIC_MAPPING GenericMapping,  
   const CAccessToken& Token   
) throw( );  
bool Set(  
   SECURITY_INFORMATION si,  
   const CSecurityDesc& Modification,  
   ULONG AutoInheritFlags,  
   PGENERIC_MAPPING GenericMapping,  
   const CAccessToken& Token   
) throw( );  
```  
  
#### Parameters  
 `si`  
 A set of bit flags that indicate the parts of the security descriptor to set. This value can be a combination of the [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) bit flags.  
  
 *Modification*  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object. The parts of this security descriptor indicated by the `si` parameter are applied to the object's security descriptor.  
  
 `GenericMapping`  
 Pointer to a [GENERIC_MAPPING](http://msdn.microsoft.com/library/windows/desktop/aa446633) structure that specifies the mapping from each generic right to specific rights for the object.  
  
 `Token`  
 Reference to the [CAccessToken](../vs140/caccesstoken-class.md) object for the client process on whose behalf the object is being created.  
  
 `AutoInheritFlags`  
 A set of bit flags that control how access-control entries (ACEs) are inherited from `pParent`. See [CreatePrivateObjectSecurityEx](http://msdn.microsoft.com/library/windows/desktop/aa446581) for more details.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The second method, which permits specifying the object type GUID of the object or controlling how ACEs are inherited, is only available on systems running Windows 2000 and later.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CPrivateObjectSecurityDesc Class](../vs140/cprivateobjectsecuritydesc-class.md)   
 [SetPrivateObjectSecurity](http://msdn.microsoft.com/library/windows/desktop/aa379580)   
 [CPrivateObjectSecurityDesc::Get](../vs140/cprivateobjectsecuritydesc--get.md)