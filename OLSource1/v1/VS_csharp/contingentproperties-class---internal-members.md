---
title: "ContingentProperties Class - Internal Members"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "ContingentProperties class [.NET Framework debug engines]"
  - "debug engines, ContingentProperties class [.NET Framework]"
ms.assetid: c49d1362-ab1c-4b6d-9950-fcae40e0e66b
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ContingentProperties Class - Internal Members
Contains additional properties for a <xref:System.Threading.Tasks.Task*> object.  
  
 **Namespace:** <xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class auto ansi nested assembly beforefieldinit ContingentProperties  
       extends System.Object  
```  
  
## Members  
  
### Fields  
  
|Name|Description|  
|----------|-----------------|  
|[m_children](../VS_csharp/m_children-field.md)|The list of child tasks that are registered with this task.|  
  
## Remarks  
 The .NET Framework initializes the fields of this class only when they are needed.  
  
## See Also  
 [Parallel Extension Internals for the .NET Framework](../VS_csharp/parallel-extension-internals-for-the-.net-framework.md)