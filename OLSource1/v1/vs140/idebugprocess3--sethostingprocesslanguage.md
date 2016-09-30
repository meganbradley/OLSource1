---
title: "IDebugProcess3::SetHostingProcessLanguage"
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
  - "IDebugProcess3::SetHostingProcessLanguage"
helpviewer_keywords: 
  - "IDebugProcess3::SetHostingProcessLanguage"
ms.assetid: e42f33ed-f29c-4e45-92ce-ab504b72d77c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess3::SetHostingProcessLanguage
This method sets the language that the process will be hosted under. This language can then be used by the debug engine (DE) to load the appropriate expression evaluator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the language that the DE should use. Specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (C++) or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (C#) to have the DE use the default language.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns error code.  
  
## Remarks  
 [IDebugProcess3::GetHostingProcessLanguage](../vs140/idebugprocess3--gethostingprocesslanguage.md) can be used to retrieve the current language setting.  
  
## See Also  
 [IDebugProcess3](../vs140/idebugprocess3.md)   
 [IDebugProcess3::GetHostingProcessLanguage](../vs140/idebugprocess3--gethostingprocesslanguage.md)