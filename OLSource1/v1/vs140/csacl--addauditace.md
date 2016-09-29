---
title: "CSacl::AddAuditAce"
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
  - "AddAuditAce"
  - "CSacl.AddAuditAce"
  - "CSacl::AddAuditAce"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddAuditAce method"
ms.assetid: 9c558e04-d797-4e05-9c43-17bcc4852199
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSacl::AddAuditAce
Adds an audit access-control entry (ACE) to the `CSacl` object.  
  
## Syntax  
  
```  
  
      bool AddAuditAce(  
   const CSid & rSid,  
   ACCESS_MASK AccessMask,  
   bool bSuccess,  
   bool bFailure,  
   BYTE AceFlags = 0  
) throw(...);  
bool AddAuditAce(  
   const CSid & rSid,  
   ACCESS_MASK AccessMask,  
   bool bSuccess,  
   bool bFailure,  
   BYTE AceFlags,  
   const GUID * pObjectType,  
   const GUID * pInheritedObjectType   
) throw(...);  
```  
  
#### Parameters  
 `rSid`  
 The [CSid](../vs140/csid-class.md) object.  
  
 `AccessMask`  
 Specifies the mask of access rights to be audited for the specified `CSid` object.  
  
 `bSuccess`  
 Specifies whether allowed access attempts are to be audited. Set this flag to true to enable auditing; otherwise, set it to false.  
  
 *bFailure*  
 Specifies whether denied access attempts are to be audited. Set this flag to true to enable auditing; otherwise, set it to false.  
  
 `AceFlags`  
 A set of bit flags that control ACE inheritance.  
  
 `pObjectType`  
 The object type.  
  
 `pInheritedObjectType`  
 The inherited object type.  
  
## Return Value  
 Returns **true** if the ACE is added to the `CSacl` object, **false** on failure.  
  
## Remarks  
 A `CSacl` object contains access-control entries (ACEs) that specify the types of access attempts that generate audit records in the security event log. This method adds such an ACE to the `CSacl` object. The second form of `AddAuditAce` is only available on Windows 2000 and later.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for a description of the various flags which can be set in the `AceFlags` parameter.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSacl Class](../vs140/csacl-class.md)   
 [CSid Class](../vs140/csid-class.md)   
 [ACCESS_MASK](http://msdn.microsoft.com/library/windows/desktop/aa374892)   
 [CSacl::RemoveAllAces](../vs140/csacl--removeallaces.md)