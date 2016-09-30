---
title: "CSid::GetSubAuthorityCount"
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
  - "CSid.GetSubAuthorityCount"
  - "CSid::GetSubAuthorityCount"
  - "ATL::CSid::GetSubAuthorityCount"
  - "GetSubAuthorityCount"
  - "ATL.CSid.GetSubAuthorityCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSubAuthorityCount method"
ms.assetid: bfc9d1ec-ff61-40d9-b3f9-d1abf4dfb7a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::GetSubAuthorityCount
Returns the subauthority count.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the method succeeds, the return value is the subauthority count.  
  
 If the method fails, the return value is undefined. The method fails if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is invalid. To get extended error information, call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is not valid.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)   
 [CSid::GetSubAuthority](../vs140/csid--getsubauthority.md)