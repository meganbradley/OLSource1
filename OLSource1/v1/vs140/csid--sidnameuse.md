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
Returns a description of the state of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the value of the data member that stores a value describing the state of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
|Value|Description|  
|-----------|-----------------|  
|SidTypeUser|Indicates a user <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (security identifier).|  
|SidTypeGroup|Indicates a group <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|SidTypeDomain|Indicates a domain <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|SidTypeAlias|Indicates an alias <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|SidTypeWellKnownGroup|Indicates a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for a well-known group.|  
|SidTypeDeletedAccount|Indicates a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for a deleted account.|  
|SidTypeInvalid|Indicates an invalid <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|SidTypeUnknown|Indicates an unknown <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type.|  
|SidTypeComputer|Indicates a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for a computer.|  
  
## Remarks  
 Call [CSid::LoadAccount](../vs140/csid--loadaccount.md) to update the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object before calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to return its state. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not change the state of the object (by calling to **LookupAccountName** or **LookupAccountSid**), but only returns the current state.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)