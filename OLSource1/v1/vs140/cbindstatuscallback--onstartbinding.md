---
title: "CBindStatusCallback::OnStartBinding"
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
  - "OnStartBinding"
  - "CBindStatusCallback::OnStartBinding"
  - "CBindStatusCallback.OnStartBinding"
  - "ATL::CBindStatusCallback::OnStartBinding"
  - "ATL.CBindStatusCallback.OnStartBinding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStartBinding method"
ms.assetid: dd21f766-d2ec-4498-857d-ea7fc17f3842
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::OnStartBinding
Sets the data member [m_spBinding](../vs140/cbindstatuscallback--m_spbinding.md) to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Address of the IBinding interface of the current bind operation. This cannot be NULL. The client should call AddRef on this pointer to keep a reference to the binding object.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::OnStopBinding](../vs140/cbindstatuscallback--onstopbinding.md)