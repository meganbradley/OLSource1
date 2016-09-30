---
title: "CHandle::Attach"
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
  - "ATL.CHandle.Attach"
  - "CHandle.Attach"
  - "ATL::CHandle::Attach"
  - "CHandle::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: 6099c224-c847-417f-98bc-81842c26f59b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHandle::Attach
Call this method to attach the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to an existing handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will take ownership of the handle <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Assigns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> handle. In debugs builds, an ATLASSERT will be raised if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is NULL. No other check as to the validity of the handle is made.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CHandle Class](../vs140/chandle-class.md)   
 [CHandle::Detach](../vs140/chandle--detach.md)