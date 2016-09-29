---
title: "CSid::SidNameUse"
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
  - "SidNameUse"
  - "ATL.CSid.SidNameUse"
  - "CSid::SidNameUse"
  - "CSid.SidNameUse"
  - "ATL::CSid::SidNameUse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SidTypeWellKnownGroup"
  - "SidTypeDeletedAccount"
  - "SidTypeGroup"
  - "SidTypeUser"
  - "SidTypeComputer"
  - "SidNameUse method"
  - "SidTypeAlias"
  - "SidTypeDomain"
  - "SidTypeInvalid"
  - "SidTypeUnknown"
ms.assetid: 25a19e5a-85e5-46b2-a4a3-77f68a86dbcb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::SidNameUse
Returns a description of the state of the `CSid` object.  
  
## Syntax  
  
```  
  
SID_NAME_USE SidNameUse( ) const throw( );  
  
```  
  
## Return Value  
 Returns the value of the data member that stores a value describing the state of the `CSid` object.  
  
|Value|Description|  
|-----------|-----------------|  
|SidTypeUser|Indicates a user `SID` (security identifier).|  
|SidTypeGroup|Indicates a group `SID`.|  
|SidTypeDomain|Indicates a domain `SID`.|  
|SidTypeAlias|Indicates an alias `SID`.|  
|SidTypeWellKnownGroup|Indicates a `SID` for a well-known group.|  
|SidTypeDeletedAccount|Indicates a `SID` for a deleted account.|  
|SidTypeInvalid|Indicates an invalid `SID`.|  
|SidTypeUnknown|Indicates an unknown `SID` type.|  
|SidTypeComputer|Indicates a `SID` for a computer.|  
  
## Remarks  
 Call [CSid::LoadAccount](../vs140/csid--loadaccount.md) to update the `CSid` object before calling `SidNameUse` to return its state. `SidNameUse` does not change the state of the object (by calling to **LookupAccountName** or **LookupAccountSid**), but only returns the current state.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)