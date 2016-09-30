---
title: "CTokenGroups::LookupSid"
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
  - "CTokenGroups::LookupSid"
  - "ATL::CTokenGroups::LookupSid"
  - "LookupSid"
  - "CTokenGroups.LookupSid"
  - "ATL.CTokenGroups.LookupSid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LookupSid method"
ms.assetid: ff9e2352-985a-47b8-a8d9-becdbad0c347
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenGroups::LookupSid
Retrieves the attributes associated with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a DWORD which will accept the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object's attribute. If omitted or NULL, the attribute will not be retrieved.  
  
## Return Value  
 Returns true if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is found, false otherwise.  
  
## Remarks  
 Setting <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to NULL provides a way of confirming the existence of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> without accessing the attribute. Note that this method should not be used to check access rights as incorrect results may occur under Windows 2000. Applications should instead use the [CAccessToken::CheckTokenMembership](../vs140/caccesstoken--checktokenmembership.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenGroups Class](../vs140/ctokengroups-class.md)   
 [CTokenGroups::GetSidsAndAttributes](../vs140/ctokengroups--getsidsandattributes.md)