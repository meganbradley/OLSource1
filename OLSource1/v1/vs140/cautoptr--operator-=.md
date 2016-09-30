---
title: "CAutoPtr::operator ="
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
  - "CAutoPtr.operator="
  - "CAutoPtr::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, pointers"
  - "operator=, pointers"
ms.assetid: 8c17d902-8115-4e85-8b61-a4ee145f50e6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtr::operator =
The assignment operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A class type.  
  
## Return Value  
 Returns a reference to a **CAutoPtr\< T >**.  
  
## Remarks  
 The assignment operator detaches the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object from any current pointer and attaches the new pointer, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, in its place.  
  
## Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)   
 [CAutoPtr::Attach](../vs140/cautoptr--attach.md)   
 [CAutoPtr::Detach](../vs140/cautoptr--detach.md)