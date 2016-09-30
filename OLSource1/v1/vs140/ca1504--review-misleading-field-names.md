---
title: "CA1504: Review misleading field names"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ReviewMisleadingFieldNames"
  - "CA1504"
helpviewer_keywords: 
  - "CA1504"
  - "ReviewMisleadingFieldNames"
ms.assetid: 94136ff1-4aaf-4dc2-9170-48c171ab7499
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1504: Review misleading field names
|||  
|-|-|  
|TypeName|ReviewMisleadingFieldNames|  
|CheckId|CA1504|  
|Category|Microsoft.Maintainability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 The name of an instance field starts with "s_" or the name of a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]) field starts with "m_".  
  
## Rule Description  
 Field names that start with "s_" are associated with static data by many users. Similarly, field names that start with "m_" are associated with instance (member) data. For more easily maintained code, names should follow generally used conventions.  
  
## How to Fix Violations  
 To fix a violation of this rule, rename the field by using the appropriate prefix. Alternatively, make the field agree with the current suffix by adding or removing the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.