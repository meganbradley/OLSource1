---
title: "CComAutoCriticalSection Class"
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
  - "ATL.CComAutoCriticalSection"
  - "ATL::CComAutoCriticalSection"
  - "CComAutoCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComAutoCriticalSection class"
ms.assetid: 491a9d90-3398-4f90-88f5-fd2172a46b30
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoCriticalSection Class
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComAutoCriticalSection::CComAutoCriticalSection](../vs140/ccomautocriticalsection--ccomautocriticalsection.md)|The constructor.|  
|[CComAutoCriticalSection::~CComAutoCriticalSection](../vs140/ccomautocriticalsection--~ccomautocriticalsection.md)|The destructor.|  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is similar to class [CComCriticalSection](../vs140/ccomcriticalsection-class.md), except <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> automatically initializes the critical section object in the constructor.  
  
 Typically, you use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> through the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> name [AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md). This name references <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) is being used.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> methods from [CComCriticalSection](../vs140/ccomcriticalsection-class.md) are not available when using this class.  
  
## Inheritance Hierarchy  
 [CComCriticalSection](../vs140/ccomcriticalsection-class.md)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcore.h  
  
##  \<a name="ccomautocriticalsection__ccomautocriticalsection">\</a>  CComAutoCriticalSection::CComAutoCriticalSection  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Calls the Win32 function [InitializeCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms683472), which initializes the critical section object.  
  
##  \<a name="ccomautocriticalsection___dtorccomautocriticalsection">\</a>  CComAutoCriticalSection::~CComAutoCriticalSection  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The destructor calls [DeleteCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682552), which releases all system resources used by the critical section object.  
  
## See Also  
 [CComFakeCriticalSection Class](../vs140/ccomfakecriticalsection-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)