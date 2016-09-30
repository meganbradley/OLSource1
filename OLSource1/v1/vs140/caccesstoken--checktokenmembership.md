---
title: "CAccessToken::CheckTokenMembership"
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
  - "ATL.CAccessToken.CheckTokenMembership"
  - "CheckTokenMembership"
  - "CAccessToken.CheckTokenMembership"
  - "CAccessToken::CheckTokenMembership"
  - "ATL::CAccessToken::CheckTokenMembership"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckTokenMembership method"
ms.assetid: 630c4b8c-25f2-415b-8020-bb5e484baa04
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::CheckTokenMembership
Call this method to determine if a specified SID is enabled in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to a [CSid Class](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a variable that receives the results of the check.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method checks for the presence of the SID in the user and group SIDs of the access token. If the SID is present and has the SE_GROUP_ENABLED attribute, *pbIsMember* is set to true; otherwise, it is set to false.  
  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not a valid pointer.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object must be an impersonation token and not a primary token.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CheckTokenMembership](http://msdn.microsoft.com/library/windows/desktop/aa376389)