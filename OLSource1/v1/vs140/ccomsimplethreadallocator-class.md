---
title: "CComSimpleThreadAllocator Class"
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
  - "CComSimpleThreadAllocator"
  - "ATL::CComSimpleThreadAllocator"
  - "ATL.CComSimpleThreadAllocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "threading [ATL], selecting threads"
  - "ATL threads"
  - "CComSimpleThreadAllocator class"
  - "ATL threads, allocating"
ms.assetid: 66b2166a-8c50-49fd-b8e4-7f293470327d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSimpleThreadAllocator Class
This class manages thread selection for the class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComSimpleThreadAllocator::GetThread](../vs140/ccomsimplethreadallocator--getthread.md)|Selects a thread.|  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> manages thread selection for [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md). <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> simply cycles through each thread and returns the next one in the sequence.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccomsimplethreadallocator__getthread">\</a>  CComSimpleThreadAllocator::GetThread  
 Selects a thread by specifying the next thread in the sequence.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Not used in ATL's default implementation.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The maximum number of threads in the EXE module.  
  
### Return Value  
 An integer between zero and ( <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> – 1). Identifies one of the threads in the EXE module.  
  
### Remarks  
 You can override <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to provide a different method of selection or to make use of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is called by [CComAutoThreadModule::CreateInstance](../vs140/ccomautothreadmodule--createinstance.md).  
  
## See Also  
 [CComApartment Class](../vs140/ccomapartment-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)