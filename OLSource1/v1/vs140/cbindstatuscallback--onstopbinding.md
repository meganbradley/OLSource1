---
title: "CBindStatusCallback::OnStopBinding"
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
  - "CBindStatusCallback::OnStopBinding"
  - "OnStopBinding"
  - "ATL.CBindStatusCallback.OnStopBinding"
  - "ATL::CBindStatusCallback::OnStopBinding"
  - "CBindStatusCallback.OnStopBinding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStopBinding method"
ms.assetid: da3e4a90-529a-47b3-af2a-b6188ade541a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::OnStopBinding
Releases the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer in the data member [m_spBinding](../vs140/cbindstatuscallback--m_spbinding.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Status code returned from the bind operation.  
  
 szStatusText  
 Address of a string value Unused.  
  
## Remarks  
 Called by the system-supplied asynchronous moniker to indicate the end of the bind operation.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::OnStartBinding](../vs140/cbindstatuscallback--onstartbinding.md)