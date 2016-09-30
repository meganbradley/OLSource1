---
title: "IDebugProgramHost2::GetHostName"
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
  - "IDebugProgramHost2::GetHostName"
helpviewer_keywords: 
  - "IDebugProgramHost2::GetHostName"
ms.assetid: 48bbb089-e59a-471a-9965-24b42a8dabf3
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramHost2::GetHostName
Gets the title, friendly name, or file name of the hosting process of this program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [GETHOSTNAME_TYPE](../vs140/gethostname_type.md) enumeration.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the requested name of the hosting process.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 In a typical implementation of this method, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is ignored and a friendly name of the host machine is returned. Another possible implementation is to pass the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter to a call to the [IDebugProgramNode2::GetHostName](../vs140/idebugprogramnode2--gethostname.md) method to get the name.  
  
## See Also  
 [IDebugProgramHost2](../vs140/idebugprogramhost2.md)   
 [IDebugProgramNode2::GetHostName](../vs140/idebugprogramnode2--gethostname.md)