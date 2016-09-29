---
title: "CDacl::AddDeniedAce"
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
  - "CDacl.AddDeniedAce"
  - "AddDeniedAce"
  - "CDacl::AddDeniedAce"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddDeniedAce method"
ms.assetid: e51f21ce-796d-490f-8c8e-9957ae4ace76
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDacl::AddDeniedAce
Adds a denied ACE (access-control entry) to the `CDacl` object.  
  
## Syntax  
  
```  
  
      bool AddDeniedAce(  
   const CSid & rSid,  
   ACCESS_MASK AccessMask,  
   BYTE AceFlags = 0  
) throw(...);  
bool AddDeniedAce(  
   const CSid & rSid,  
   ACCESS_MASK AccessMask,  
   BYTE AceFlags,  
   const GUID * pObjectType,  
   const GUID * pInheritedObjectType   
) throw(...);  
```  
  
#### Parameters  
 `rSid`  
 A `CSid` object.  
  
 `AccessMask`  
 Specifies the mask of access rights to be denied for the specified `CSid` object.  
  
 `AceFlags`  
 A set of bit flags that control ACE inheritance. Defaults to 0 in the first form of the method.  
  
 `pObjectType`  
 The object type.  
  
 `pInheritedObjectType`  
 The inherited object type.  
  
## Return Value  
 Returns **true** if the ACE is added to the `CDacl` object, **false** on failure.  
  
## Remarks  
 A `CDacl` object contains zero or more ACEs (access-control entries) that identify the users and groups who can access the object. This method adds an ACE that denies access to the `CDacl` object.  
  
> [!NOTE]
>  The second form of `AddDeniedAce` is only available on Windows 2000 and later.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for a description of the various flags which can be set in the `AceFlags` parameter.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CDacl Class](../vs140/cdacl-class.md)   
 [CDacl::AddAllowedAce](../vs140/cdacl--addallowedace.md)   
 [CDacl::RemoveAllAces](../vs140/cdacl--removeallaces.md)   
 [ACCESS_MASK](http://msdn.microsoft.com/library/windows/desktop/aa374892)