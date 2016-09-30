---
title: "CHandle::Close"
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
  - "ATL::CHandle::Close"
  - "CHandle::Close"
  - "ATL.CHandle.Close"
  - "CHandle.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
ms.assetid: ab874ce3-587d-4ac8-97fb-98930d519ac5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHandle::Close
Call this method to close a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Closes an open object handle. If the handle is NULL, which will be the case if **Close** has already been called, an ATLASSERT will be raised in debug builds.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CHandle Class](../vs140/chandle-class.md)   
 [CHandle::~CHandle](../vs140/chandle--~chandle.md)