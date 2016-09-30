---
title: "_com_ptr_t::QueryInterface"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_ptr_t::QueryInterface"
  - "_com_ptr_t.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: d03292f1-6b02-40db-9756-8b0837a97319
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_ptr_t::QueryInterface
**Microsoft Specific**  
  
 Calls the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function of **IUnknown** on the encapsulated interface pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **IID** of an interface pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Raw interface pointer.  
  
## Remarks  
 Calls **IUnknown::QueryInterface** on the encapsulated interface pointer with the specified **IID** and returns the resulting raw interface pointer in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This routine returns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to indicate success or failure.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_ptr_t Class](../vs140/_com_ptr_t-class.md)