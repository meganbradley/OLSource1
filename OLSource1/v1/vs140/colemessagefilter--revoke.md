---
title: "COleMessageFilter::Revoke"
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
  - "Revoke"
  - "COleMessageFilter::Revoke"
  - "COleMessageFilter.Revoke"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Revoke method"
  - "COleMessageFilter class, operations"
ms.assetid: 40cc99b5-8a67-46aa-ab69-68a9ac125b8f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::Revoke
Revokes a previous registration performed by a call to [Register](../vs140/colemessagefilter--register.md).  
  
## Syntax  
  
```  
  
void Revoke( );  
```  
  
## Remarks  
 A message filter should be revoked before the program terminates.  
  
 The default message filter, which is created and registered automatically by the framework, is also automatically revoked.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::Register](../vs140/colemessagefilter--register.md)