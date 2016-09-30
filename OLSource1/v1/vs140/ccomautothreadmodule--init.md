---
title: "CComAutoThreadModule::Init"
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
  - "ATL.CComAutoThreadModule.Init"
  - "CComAutoThreadModule::Init"
  - "CComAutoThreadModule.Init"
  - "ATL::CComAutoThreadModule::Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: c4471fcd-34db-4ec4-a2bd-d8605e98307f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule::Init
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
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The number of threads to be created. By default, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the value returned by [GetDefaultThreads](../vs140/ccomautothreadmodule--getdefaultthreads.md).  
  
## Remarks  
 Initializes data members and creates the number of threads specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAutoThreadModule Class](../vs140/ccomautothreadmodule-class.md)   
 [CComAutoThreadModule::m_nThreads](../vs140/ccomautothreadmodule--m_nthreads.md)