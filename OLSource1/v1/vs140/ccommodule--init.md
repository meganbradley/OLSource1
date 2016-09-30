---
title: "CComModule::Init"
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
  - "ATL.CComModule.Init"
  - "ATL::CComModule::Init"
  - "CComModule::Init"
  - "CComModule.Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: 8b584e2c-d416-4d02-99e8-0a6698d1fc22
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::Init
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to an array of object map entries.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> passed to **DLLMain** or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A pointer to the LIBID of the type library associated with the project.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Initializes all data members.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::Term](../vs140/ccommodule--term.md)