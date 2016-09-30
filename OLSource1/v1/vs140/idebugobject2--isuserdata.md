---
title: "IDebugObject2::IsUserData"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugObject2::IsUserData"
helpviewer_keywords: 
  - "IDebugObject2::IsUserData method"
ms.assetid: 6ffa0d0e-f742-496d-acc7-db74c248bc45
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject2::IsUserData
Determines whether the object represents user data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns nonzero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if the object represents user data; zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if it does not.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 User data is any object that is part of a module designated as JustMyCode (a user-configurable option that marks a module as user code and therefore visible in a stack trace).  
  
## See Also  
 [IDebugObject2](../vs140/idebugobject2.md)