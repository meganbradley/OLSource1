---
title: "CSid::GetSubAuthority"
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
  - "ATL.CSid.GetSubAuthority"
  - "CSid.GetSubAuthority"
  - "GetSubAuthority"
  - "CSid::GetSubAuthority"
  - "ATL::CSid::GetSubAuthority"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSubAuthority method"
ms.assetid: 8d7da004-f037-4066-9537-b818662a2b7d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::GetSubAuthority
Returns a specified subauthority in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (security identifier) structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nSubAuthority*  
 The subauthority.  
  
## Return Value  
 Returns the subauthority referenced by *nSubAuthority.* The subauthority value is a relative identifier (RID).  
  
## Remarks  
 The *nSubAuthority* parameter specifies an index value identifying the subauthority array element the method will return. The method performs no validation tests on this value. An application can call [CSid::GetSubAuthorityCount](../vs140/csid--getsubauthoritycount.md) to discover the range of acceptable values.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is not valid.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)   
 [CSid::GetPSID_IDENTIFIER_AUTHORITY](../vs140/csid--getpsid_identifier_authority.md)