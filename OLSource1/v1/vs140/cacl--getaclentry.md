---
title: "CAcl::GetAclEntry"
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
  - "CAcl::GetAclEntry"
  - "GetAclEntry"
  - "ATL.CAcl.GetAclEntry"
  - "CAcl.GetAclEntry"
  - "ATL::CAcl::GetAclEntry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAclEntry method"
ms.assetid: 5cd2593b-88aa-4bbc-a606-e2add6e61f33
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAcl::GetAclEntry
Retrieves all of the information about an entry in an access-control list (ACL).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index to the ACL entry to retrieve.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object to which the ACL entry applies.  
  
 *pMask*  
 The mask specifying permissions to grant or deny access.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The ACE type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ACE flags.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The object type. This will be set to GUID_NULL if the object type is not specified in the ACE, or if the ACE is not an OBJECT ACE.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The inherited object type. This will be set to GUID_NULL if the inherited object type is not specified in the ACE, or if the ACE is not an OBJECT ACE.  
  
## Remarks  
 This method will retrieve all of the information about an individual ACE, providing more information than [CAcl::GetAclEntries](../vs140/cacl--getaclentries.md) alone makes available.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for more details on ACE types and flags.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAcl Class](../vs140/cacl-class.md)   
 [CAcl::CAceFlagArray](../vs140/cacl--caceflagarray.md)   
 [CAcl::CAceTypeArray](../vs140/cacl--cacetypearray.md)   
 [ACCESS_MASK](http://msdn.microsoft.com/library/windows/desktop/aa374892)   
 [CAcl::GetAclEntries](../vs140/cacl--getaclentries.md)