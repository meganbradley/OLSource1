---
title: "CAccessToken::GetDefaultDacl"
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
  - "ATL::CAccessToken::GetDefaultDacl"
  - "CAccessToken::GetDefaultDacl"
  - "ATL.CAccessToken.GetDefaultDacl"
  - "GetDefaultDacl"
  - "CAccessToken.GetDefaultDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDefaultDacl method"
ms.assetid: c6df3410-427a-4228-bfcc-6d9c7cd2999c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetDefaultDacl
Call this method to return the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object's default DACL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the [CDacl Class](../vs140/cdacl-class.md) object which will receive the **CAccessToken** object's default DACL.  
  
## Return Value  
 Returns true if the default DACL has been recovered, false otherwise.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::SetDefaultDacl](../vs140/caccesstoken--setdefaultdacl.md)