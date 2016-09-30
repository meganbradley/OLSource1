---
title: "IDebugProcess3::GetHostingProcessLanguage"
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
  - "IDebugProcess3::GetHostingProcessLanguage"
helpviewer_keywords: 
  - "IDebugProcess3::GetHostingProcessLanguage"
ms.assetid: 52fca002-a9ef-43b1-9192-afbe7bb59ad4
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess3::GetHostingProcessLanguage
This method returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> representing the language of this process as set by a call to [IDebugProcess3::SetHostingProcessLanguage](../vs140/idebugprocess3--sethostingprocesslanguage.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of the language of this process. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (C++) or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (C#) means that the language is not set.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns error code.  
  
## See Also  
 [IDebugProcess3](../vs140/idebugprocess3.md)   
 [IDebugProcess3::SetHostingProcessLanguage](../vs140/idebugprocess3--sethostingprocesslanguage.md)