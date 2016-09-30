---
title: "CSid::Domain"
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
  - "CSid.Domain"
  - "CSid::Domain"
  - "ATL.CSid.Domain"
  - "Domain"
  - "ATL::CSid::Domain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Domain method"
ms.assetid: 39d27616-f4a1-478a-9f6e-941ab8c45c90
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::Domain
Returns the name of the domain associated with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointing to the domain.  
  
## Remarks  
 This method attempts to find a name for the specified <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (security identifier). For full details, see [LookupAccountSid](http://msdn.microsoft.com/library/windows/desktop/aa379166).  
  
 If no account name for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be found, **Domain** returns the domain as an empty string. This can occur if a network timeout prevents this method from finding the name. It also occurs for security identifiers with no corresponding account name, such as a logon <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that identifies a logon session.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)   
 [CSid::AccountName](../vs140/csid--accountname.md)   
 [LookupAccountSid](http://msdn.microsoft.com/library/windows/desktop/aa379166)