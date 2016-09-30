---
title: "CStringT::GetEnvironmentVariable"
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
  - "CStringT::GetEnvironmentVariable"
  - "ATL.CStringT.GetEnvironmentVariable"
  - "ATL::CStringT::GetEnvironmentVariable"
  - "GetEnvironmentVariable"
  - "CStringT.GetEnvironmentVariable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEnvironmentVariable method"
ms.assetid: 614669e6-01ce-4dc8-afdb-4a49fc393451
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::GetEnvironmentVariable
Sets the string to the value of the specified environment variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the environment variable.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Retrieves the value of the specified variable from the environment block of the calling process. The value is in the form of a null-terminated string of characters.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#121](../vs140/codesnippet/CPP/cstringt--getenvironmentvariable_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)