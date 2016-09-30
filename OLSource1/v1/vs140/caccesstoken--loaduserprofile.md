---
title: "CAccessToken::LoadUserProfile"
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
  - "CAccessToken::LoadUserProfile"
  - "CAccessToken.LoadUserProfile"
  - "ATL.CAccessToken.LoadUserProfile"
  - "ATL::CAccessToken::LoadUserProfile"
  - "LoadUserProfile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadUserProfile method"
ms.assetid: e3182aaf-987a-407d-9dd8-6f40a723bf80
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::LoadUserProfile
Call this method to load the user profile associated with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> does not contain a valid token, or if a user profile already exists.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::ImpersonateLoggedOnUser](../vs140/caccesstoken--impersonateloggedonuser.md)   
 [CAccessToken::HKeyCurrentUser](../vs140/caccesstoken--hkeycurrentuser.md)